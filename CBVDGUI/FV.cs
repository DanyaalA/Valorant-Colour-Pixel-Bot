using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBVDGUI
{
    public partial class FV : Form
    {

        enum AimKey
        {
            LeftMouse = 1,
            RightMouse = 2,
            X1Mouse = 5,
            X2Button = 6,
            Shift = 160,
            Ctrl = 162,
            Alt = 164,
            Capslock = 20,
            Numpad0 = 96,
            Numlock = 144,
        }

        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public FV()
        {
            InitializeComponent();

            //this.BackColor = Color.FromArgb(255, 62, 74);
            this.Text = RandomString(16);
            this.Name = RandomString(16);
            this.ShowIcon = false;

            Width = GeneralPanel.Width + 35;
            AimPanel.Location = GeneralPanel.Location;


            GeneralPanel.BringToFront();
            GeneralPanel.Visible = true;
            AimPanel.Visible = false;

            isTriggerbot = GetKey<bool>(nameof(isTriggerbot));
            isAimbot = GetKey<bool>(nameof(isAimbot));
            speed = GetKey<decimal>(nameof(speed));
            fovX = GetKey<int>(nameof(fovX));
            fovY = GetKey<int>(nameof(fovY));
            color = (ColorType)GetKey<int>(nameof(color));
            mainAimKey = (AimKey)GetKey<int>(nameof(mainAimKey));
            isAimKey = GetKey<bool>(nameof(isAimKey));
            isHold = GetKey<bool>(nameof(isHold));
            monitor = GetKey<int>(nameof(monitor));
            isTriggerbot = GetKey<bool>(nameof(isTriggerbot));
            offsetY = GetKey<int>(nameof(offsetY));
            msShootTime = GetKey<int>(nameof(msShootTime));
            snapDelay = GetKey<int>(nameof(snapDelay));
            showFOV = GetKey<bool>(nameof(showFOV));

            switch (color)
            {
                case ColorType.Red:
                    RedRadio.Checked = true;
                    break;
                case ColorType.Purple:
                    PurpleRadio.Checked = true;
                    break;
                default:
                    break;
            }
            
            UpdateUI();
            UpdateDisplayInformation();
            TriggerbotBtt.Checked = isHold;
            AimbotBtt.Checked = isAimbot;
            AimKeyToggle.Checked = isAimKey;
            Speed.Value = speed;

            decimal fovXVal = Convert.ToDecimal(fovX) / Convert.ToDecimal(xSize) * 100;
            decimal fovYVal = Convert.ToDecimal(fovY) / Convert.ToDecimal(ySize) * 100;
            FovXSlider.Percentage = Convert.ToInt32(fovXVal);
            FovXBox.Text = Math.Round((fovXVal / 100), 2).ToString();
            FovYSlider.Percentage = Convert.ToInt32(fovYVal);
            FovYBox.Text = Math.Round((fovYVal / 100), 2).ToString();
            TriggerbotBtt.Checked = isTriggerbot;
            offsetNum.Value = offsetY;
            FireRateNum.Value = msShootTime;
            snapDelayNum.Value = snapDelay;
            ShowFov.Checked = showFOV;
            

            string[] names = Enum.GetNames(typeof(AimKey));
            foreach (var name in names)
            {
                contextMenuStrip1.Items.Add(name);
                AimKeyCombo.Items.Add(name);
            }

            AimKeyCombo.SelectedItem = Enum.GetName(typeof(AimKey), mainAimKey).ToString();
            contextMenuStrip1.ItemClicked += (o, e) => {
                mainAimKey = (AimKey)Enum.Parse(typeof(AimKey), e.ClickedItem.ToString());

                SetKey(nameof(mainAimKey), (int)mainAimKey);
                UpdateUI();
            };
            AutoSize = false;
            AutoScaleMode = AutoScaleMode.Font;
            //Font = new Font("Trebuchet MS",
            //8.0f,
            //FontStyle.Regular,
            //GraphicsUnit.Point,
            //((byte)(204))
            //);
        }

        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        public enum DeviceCap
        {
            VERTRES = 10,
            DESKTOPVERTRES = 117,

            // http://pinvoke.net/default.aspx/gdi32/GetDeviceCaps.html
        }


        private float GetScalingFactor()
        {
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            IntPtr desktop = g.GetHdc();
            int LogicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.VERTRES);
            int PhysicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.DESKTOPVERTRES);

            float ScreenScalingFactor = (float)PhysicalScreenHeight / (float)LogicalScreenHeight;

            return ScreenScalingFactor; // 1.25 = 125%
        }


        int xSize;
        int ySize;


        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vKey);
        [DllImport("USER32.dll")]
        static extern short GetKeyState(int nVirtKey);

        int msShootTime = 225;
        System.DateTime lastShot = System.DateTime.Now;

        int offsetY = 10;

        async void Update()
        {
            while (true)
            {
                if (!isRunning)
                {
                    await Task.Delay(10);
                    continue;
                }
                if (isAimKey)
                {
                    int res = GetKeyState((int)mainAimKey);
                    if (isHold)
                    {
                        if (res >= 0)
                        {
                            // if (res < 0) {
                            await Task.Delay(1);
                            //Move(0, 0, true);
                            continue;
                        }
                    }
                    else
                    {
                        if (res != 0)
                        {
                            await Task.Delay(1);
                            continue;
                        }
                    }
                }
                var mainColor = Color.FromArgb(GetColor(color));


                if (isTriggerbot && !isAimbot)
                {
                    const int triggerFovX = 10;
                    const int triggerFovY = 10;
                    var l = PixelSearch(new Rectangle((xSize - triggerFovX) / 2, (ySize - triggerFovY) / 2, triggerFovX, triggerFovY), mainColor, colorVariation);
                    if (l.Length > 0)
                    { // IF NOT ERROR
                        Move(0, 0, true);
                    }
                }
                else if (isAimbot)
                {
                    const int maxCount = 5;
                    const int size = 60;
                    const int closeSize = 10;

                    var l = PixelSearch(new Rectangle((xSize - fovX) / 2, (ySize - fovY) / 2, fovX, fovY), mainColor, colorVariation);
                    if (l.Length > 0)
                    {
                        try
                        {
                            bool pressDown = false;
                            if (isTriggerbot)
                            {
                                for (int i = 0; i < l.Length; i++)
                                {
                                    if ((new Vector2(l[i].X, l[i].Y) - new Vector2(xSize / 2, ySize / 2)).Length() < closeSize)
                                    {
                                        pressDown = true;
                                        break;
                                    }
                                }
                            }

                            var q = l.OrderBy(t => t.Y).ToArray();

                            List<Vector2> forbidden = new List<Vector2>();

                            for (int i = 0; i < q.Length; i++)
                            {
                                Vector2 current = new Vector2(q[i].X, q[i].Y);
                                if (forbidden.Where(t => (t - current).Length() < size || Math.Abs(t.X - current.X) < size).Count() < 1)
                                { // TO NOT PLACE POINTS AT THE BODY
                                    forbidden.Add(current);
                                    if (forbidden.Count > maxCount)
                                    {
                                        break;
                                    }
                                }
                            }

                            var closes = forbidden.Select(t => (t - new Vector2(xSize / 2, ySize / 2))).OrderBy(t => t.Length()).ElementAt(0) + new Vector2(1, offsetY);

                            Move((int)(closes.X * (float)speed), (int)(closes.Y * (float)speed), pressDown);
                        }
                        catch (Exception _ex)
                        {
                            Console.WriteLine("Main Ex." + _ex);
                        }
                    }
                }
            }
        }

        bool isTriggerbot = false;
        bool isAimbot = false;
        decimal speed = 1;
        int fovX = 100;
        int fovY = 100;
        bool isAimKey = false;
        bool isHold = true;
        int monitor = 0;
        int snapDelay = 0;
        int colorVariation = 25;
        bool showFOV = false;
        enum ColorType { Red = 0, Purple = 1 }
        int GetColor(ColorType color)
        {
            switch (color)
            {
                case ColorType.Red:
                    return 0xb41515;
                case ColorType.Purple:
                    return 0xaf2eaf;
                default:
                    return 0;
            }
        }

        AimKey mainAimKey = AimKey.Alt;
        ColorType color = ColorType.Purple;

        float zoom = 1;
        void UpdateDisplayInformation()
        {
            zoom = GetScalingFactor();
            Screen current = CurrentScreen();
            bool prim = current.Primary;
            xSize = (int)(current.Bounds.Width * (prim ? zoom : 1));
            ySize = (int)(current.Bounds.Height * (prim ? zoom : 1));
        }


        
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, uint dwData,
UIntPtr dwExtraInfo);

        public void Move(int xDelta, int yDelta, bool pressDown = false)
        {
            if (pressDown)
            {
                if (System.DateTime.Now.Subtract(lastShot).TotalMilliseconds < msShootTime)
                {
                    pressDown = false;
                }
                else
                {
                    lastShot = System.DateTime.Now;
                }
            }

            // if (pressDown) {
            mouse_event(pressDown ? (MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP) : 0x0001, xDelta, yDelta, 0, UIntPtr.Zero);
            //  }
            //  mouse_event(0x0001, xDelta, yDelta, 0, UIntPtr.Zero);

            //Thread.Sleep(snapDelay);
        }

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public Screen CurrentScreen()
        {
            return Screen.AllScreens[monitor];
        }

        public Point[] PixelSearch(Rectangle rect, Color Pixel_Color, int Shade_Variation)
        {
            ArrayList points = new ArrayList();
            Bitmap RegionIn_Bitmap = new Bitmap(rect.Width, rect.Height, PixelFormat.Format24bppRgb);

            if (monitor >= Screen.AllScreens.Length)
            {
                monitor = 0;
                UpdateUI();
            }

            int xOffset = Screen.AllScreens[monitor].Bounds.Left;
            int yOffset = Screen.AllScreens[monitor].Bounds.Top;

            using (Graphics GFX = Graphics.FromImage(RegionIn_Bitmap))
            {
                GFX.CopyFromScreen(rect.X + xOffset, rect.Y + yOffset, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
            }
            BitmapData RegionIn_BitmapData = RegionIn_Bitmap.LockBits(new Rectangle(0, 0, RegionIn_Bitmap.Width, RegionIn_Bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int[] Formatted_Color = new int[3] { Pixel_Color.B, Pixel_Color.G, Pixel_Color.R }; //bgr

            unsafe
            {
                for (int y = 0; y < RegionIn_BitmapData.Height; y++)
                {
                    byte* row = (byte*)RegionIn_BitmapData.Scan0 + (y * RegionIn_BitmapData.Stride);
                    for (int x = 0; x < RegionIn_BitmapData.Width; x++)
                    {
                        if (row[x * 3] >= (Formatted_Color[0] - Shade_Variation) & row[x * 3] <= (Formatted_Color[0] + Shade_Variation)) //blue
                            if (row[(x * 3) + 1] >= (Formatted_Color[1] - Shade_Variation) & row[(x * 3) + 1] <= (Formatted_Color[1] + Shade_Variation)) //green
                                if (row[(x * 3) + 2] >= (Formatted_Color[2] - Shade_Variation) & row[(x * 3) + 2] <= (Formatted_Color[2] + Shade_Variation)) //red
                                    points.Add(new Point(x + rect.X, y + rect.Y));
                    }
                }
            }
            RegionIn_Bitmap.Dispose();
            return (Point[])points.ToArray(typeof(Point));
        }

        private void Red_changed(object sender, EventArgs e)
        {
            color = ColorType.Red;
            SetKey(nameof(color), (int)color);
        }

        private void Purple_changed(object sender, EventArgs e)
        {
            color = ColorType.Purple;
            SetKey(nameof(color), (int)color);
        }

        private void Speed_changed(object sender, EventArgs e)
        {
            speed = Speed.Value;
            SetKey(nameof(speed), speed);
        }


        private void IsAimbot_changed(object sender, EventArgs e)
        {

            isAimbot = AimbotBtt.Checked;
            SetKey(nameof(isAimbot), isAimbot);

        }

        private void IsTriggerbot_changed(object sender, EventArgs e)
        {
            isTriggerbot = TriggerbotBtt.Checked;
            SetKey(nameof(isTriggerbot), isTriggerbot);
        }

        Thread mainThread;
        private void Main_load(object sender, EventArgs e)
        {
            mainThread = new Thread(() => {
                Update();
            });
            mainThread.Start();
        }

        void SetKey(string key, bool o)
        {
            Properties.Settings.Default[key] = o;
            Properties.Settings.Default.Save();
        }
        void SetKey(string key, int o)
        {
            Properties.Settings.Default[key] = o;
            Properties.Settings.Default.Save();
        }
        void SetKey(string key, decimal o)
        {
            Properties.Settings.Default[key] = o;
            Properties.Settings.Default.Save();
        }

        T GetKey<T>(string key)
        {
            return (T)Properties.Settings.Default[key];
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            mainThread.Abort();
            Properties.Settings.Default.Save();
            base.OnHandleDestroyed(e);
        }

        bool isRunning = false;
        bool isDone = false;
        private void Start_click(object sender, EventArgs e)
        {
            isRunning = !isRunning;
            Recorder rc = new Recorder(fovX, fovY);
            UpdateUI();

            FormCollection fc = Application.OpenForms;
            Form f = new Form();

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "Recorder")
                {
                    f = frm;
                }
            }

            if (f.Name != "Recorder" && !isDone)
            {
                rc.Show();
                isDone = true;



            }
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "Recorder")
                {
                    f = frm;
                }
            }

            f.Hide();

            Recorder r = (Recorder)f;

            if (isRunning)
            {
                if (showFOV)
                {
                    r.w = fovX;
                    r.h = fovY;
                    r.recEnabled = true;
                    r.startThread();
                    r.Show();
                }
                

                //Console.WriteLine(SuperButton.SuperSelected);
                StartBtt.ButtonText = "Stop";
                StartBtt.SuperSelected = true;

            }
            else
            {
                StartBtt.ButtonText = "Start";
                StartBtt.SuperSelected = false;
                r.recEnabled = false;
                r.Hide();
            }

            
        }

        void UpdateUI()
        {
            StartBtt.Text = isRunning ? "Stop" : "Start";
            UpdateDisplayInformation();
            ChangeMonitorBtt.Text = ("Monitor [" + monitor + "] " + xSize + "x" + ySize);
            //AimkeyBtt.Text = Enum.GetName(typeof(AimKey), mainAimKey);
            AimKeyCombo.SelectedValue= Enum.GetName(typeof(AimKey), mainAimKey);
        }

        private void MonitorChanged(object sender, EventArgs e)
        {
            monitor++;
            if (monitor >= Screen.AllScreens.Length)
            {
                monitor = 0;
            }
            SetKey(nameof(monitor), monitor);
            UpdateUI();
        }

        private void IsAimKeyChanged(object sender, EventArgs e)
        {
            isAimKey = AimKeyToggle.Checked;
            SetKey(nameof(isAimKey), isAimKey);
        }

        private void IsHold_changed(object sender, EventArgs e)
        {
            isHold = IsHoldToggle.Checked;
            SetKey(nameof(isHold), isHold);
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void OffsetY_changed(object sender, EventArgs e)
        {
            offsetY = (int)offsetNum.Value;
            SetKey(nameof(offsetY), offsetY);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FireRate_changed(object sender, EventArgs e)
        {
            msShootTime = (int)FireRateNum.Value;
            SetKey(nameof(msShootTime), msShootTime);
        }

        private decimal calculatePercentage(int value, XanderUI.XUISlider slider, bool doubleVal = false)
        {
            decimal percentage = slider.Percentage; //Have to put percent

            if (doubleVal)
                percentage *= 2;

            decimal calculatedFOV = value * (percentage / 100);

            calculatedFOV /= value;

            return (calculatedFOV);
        }

        private void FovXSlider_changed(object sender, EventArgs e)
        {
            FovXBox.Text = calculatePercentage(xSize, FovXSlider).ToString();
        }

        private void FOVSlider_MouseChanged(object sender, MouseEventArgs e)
        {
            FovXBox.Text = calculatePercentage(xSize, FovXSlider).ToString();
        }

        private void FOVBox_TextChanged(object sender, EventArgs e)
        {
            fovX = (int)(xSize * Convert.ToDecimal(FovXBox.Text));
            SetKey(nameof(fovX), fovX);
        }

        private void FovYBox_TextChanged(object sender, EventArgs e)
        {
            fovY = (int)(ySize * Convert.ToDecimal(FovYBox.Text));
            SetKey(nameof(fovY), fovY);
        }

        private void FovYSlider_MouseDown(object sender, MouseEventArgs e)
        {
            FovYBox.Text = calculatePercentage(ySize, FovYSlider).ToString();
        }

        private void FovYSlider_Click(object sender, EventArgs e)
        {
            FovYBox.Text = calculatePercentage(ySize, FovYSlider).ToString();

        }

        private void MainSegment_Click(object sender, EventArgs e)
        {
            if (MainSegment.SelectedIndex == 0)
            {
                GeneralPanel.BringToFront();
                GeneralPanel.Visible = true;
                AimPanel.Visible = false;
            }
            else if (MainSegment.SelectedIndex == 1)
            {
                AimPanel.BringToFront();
                AimPanel.Visible = true;
                GeneralPanel.Visible = false;
            }
        }

        private void AimKeyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainAimKey = (AimKey)Enum.Parse(typeof(AimKey), AimKeyCombo.SelectedItem.ToString());

            SetKey(nameof(mainAimKey), (int)mainAimKey);
            UpdateUI();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            snapDelay = (int)snapDelayNum.Value;
            SetKey(nameof(snapDelay), snapDelay);
        }

        private void ShowFov_CheckedStateChanged(object sender, EventArgs e)
        {
            showFOV = ShowFov.Checked;
            SetKey(nameof(showFOV), showFOV);
        }

        private void FV_Leave(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            Application.Exit();
        }

        private void FV_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }
    }
}