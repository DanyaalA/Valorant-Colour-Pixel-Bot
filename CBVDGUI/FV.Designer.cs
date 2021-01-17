namespace CBVDGUI
{
    partial class FV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FV));
            this.Speed = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.PurpleRadio = new System.Windows.Forms.RadioButton();
            this.RedRadio = new System.Windows.Forms.RadioButton();
            this.xuiCheckBox1 = new XanderUI.XUICheckBox();
            this.xuiCustomGroupbox6 = new XanderUI.XUICustomGroupbox();
            this.ShowFov = new XanderUI.XUICheckBox();
            this.ChangeMonitorBtt = new System.Windows.Forms.Button();
            this.AimPanel = new System.Windows.Forms.Panel();
            this.xuiCustomGroupbox4 = new XanderUI.XUICustomGroupbox();
            this.offsetNum = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.snapDelayNum = new System.Windows.Forms.NumericUpDown();
            this.FovYSlider = new XanderUI.XUISlider();
            this.FireRateNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.FovXSlider = new XanderUI.XUISlider();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FovYBox = new System.Windows.Forms.TextBox();
            this.FovXBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.xuiCustomGroupbox5 = new XanderUI.XUICustomGroupbox();
            this.AimKeyCombo = new System.Windows.Forms.ComboBox();
            this.AimKeyToggle = new XanderUI.XUICheckBox();
            this.IsHoldToggle = new XanderUI.XUICheckBox();
            this.TriggerbotBtt = new XanderUI.XUICheckBox();
            this.AimbotBtt = new XanderUI.XUICheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MainSegment = new XanderUI.XUISegment();
            this.StartBtt = new XanderUI.XUISuperButton();
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).BeginInit();
            this.GeneralPanel.SuspendLayout();
            this.xuiCustomGroupbox1.SuspendLayout();
            this.xuiCustomGroupbox6.SuspendLayout();
            this.AimPanel.SuspendLayout();
            this.xuiCustomGroupbox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapDelayNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireRateNum)).BeginInit();
            this.xuiCustomGroupbox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Speed
            // 
            this.Speed.DecimalPlaces = 2;
            this.Speed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Speed.Location = new System.Drawing.Point(54, 83);
            this.Speed.Margin = new System.Windows.Forms.Padding(2);
            this.Speed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(90, 20);
            this.Speed.TabIndex = 3;
            this.Speed.ValueChanged += new System.EventHandler(this.Speed_changed);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Controls.Add(this.xuiCustomGroupbox1);
            this.GeneralPanel.Controls.Add(this.xuiCustomGroupbox6);
            this.GeneralPanel.Location = new System.Drawing.Point(12, 47);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(425, 241);
            this.GeneralPanel.TabIndex = 30;
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.PurpleRadio);
            this.xuiCustomGroupbox1.Controls.Add(this.RedRadio);
            this.xuiCustomGroupbox1.Controls.Add(this.xuiCheckBox1);
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(3, 101);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(419, 114);
            this.xuiCustomGroupbox1.TabIndex = 27;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Other";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // PurpleRadio
            // 
            this.PurpleRadio.AutoSize = true;
            this.PurpleRadio.Location = new System.Drawing.Point(116, 40);
            this.PurpleRadio.Name = "PurpleRadio";
            this.PurpleRadio.Size = new System.Drawing.Size(55, 17);
            this.PurpleRadio.TabIndex = 28;
            this.PurpleRadio.TabStop = true;
            this.PurpleRadio.Text = "Purple";
            this.PurpleRadio.UseVisualStyleBackColor = true;
            this.PurpleRadio.CheckedChanged += new System.EventHandler(this.Purple_changed);
            // 
            // RedRadio
            // 
            this.RedRadio.AutoSize = true;
            this.RedRadio.Location = new System.Drawing.Point(116, 17);
            this.RedRadio.Name = "RedRadio";
            this.RedRadio.Size = new System.Drawing.Size(45, 17);
            this.RedRadio.TabIndex = 28;
            this.RedRadio.TabStop = true;
            this.RedRadio.Text = "Red";
            this.RedRadio.UseVisualStyleBackColor = true;
            this.RedRadio.CheckedChanged += new System.EventHandler(this.Red_changed);
            // 
            // xuiCheckBox1
            // 
            this.xuiCheckBox1.CheckboxCheckColor = System.Drawing.Color.White;
            this.xuiCheckBox1.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiCheckBox1.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiCheckBox1.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.xuiCheckBox1.Checked = false;
            this.xuiCheckBox1.ForeColor = System.Drawing.Color.Black;
            this.xuiCheckBox1.Location = new System.Drawing.Point(10, 19);
            this.xuiCheckBox1.Name = "xuiCheckBox1";
            this.xuiCheckBox1.Size = new System.Drawing.Size(100, 20);
            this.xuiCheckBox1.TabIndex = 22;
            this.xuiCheckBox1.Text = "Auto Bhop";
            this.xuiCheckBox1.TickThickness = 2;
            // 
            // xuiCustomGroupbox6
            // 
            this.xuiCustomGroupbox6.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox6.BorderWidth = 1;
            this.xuiCustomGroupbox6.Controls.Add(this.ShowFov);
            this.xuiCustomGroupbox6.Controls.Add(this.ChangeMonitorBtt);
            this.xuiCustomGroupbox6.Location = new System.Drawing.Point(3, 3);
            this.xuiCustomGroupbox6.Name = "xuiCustomGroupbox6";
            this.xuiCustomGroupbox6.ShowText = true;
            this.xuiCustomGroupbox6.Size = new System.Drawing.Size(419, 92);
            this.xuiCustomGroupbox6.TabIndex = 5;
            this.xuiCustomGroupbox6.TabStop = false;
            this.xuiCustomGroupbox6.Text = "In-Game Resoloution";
            this.xuiCustomGroupbox6.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // ShowFov
            // 
            this.ShowFov.CheckboxCheckColor = System.Drawing.Color.White;
            this.ShowFov.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.ShowFov.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.ShowFov.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.ShowFov.Checked = false;
            this.ShowFov.ForeColor = System.Drawing.Color.Black;
            this.ShowFov.Location = new System.Drawing.Point(183, 23);
            this.ShowFov.Name = "ShowFov";
            this.ShowFov.Size = new System.Drawing.Size(100, 20);
            this.ShowFov.TabIndex = 30;
            this.ShowFov.Text = "Show FOV";
            this.ShowFov.TickThickness = 2;
            this.ShowFov.CheckedStateChanged += new System.EventHandler(this.ShowFov_CheckedStateChanged);
            // 
            // ChangeMonitorBtt
            // 
            this.ChangeMonitorBtt.Location = new System.Drawing.Point(10, 19);
            this.ChangeMonitorBtt.Name = "ChangeMonitorBtt";
            this.ChangeMonitorBtt.Size = new System.Drawing.Size(167, 36);
            this.ChangeMonitorBtt.TabIndex = 24;
            this.ChangeMonitorBtt.Text = "Monitor";
            this.ChangeMonitorBtt.UseVisualStyleBackColor = true;
            this.ChangeMonitorBtt.Click += new System.EventHandler(this.MonitorChanged);
            // 
            // AimPanel
            // 
            this.AimPanel.Controls.Add(this.xuiCustomGroupbox4);
            this.AimPanel.Controls.Add(this.xuiCustomGroupbox5);
            this.AimPanel.Location = new System.Drawing.Point(459, 48);
            this.AimPanel.Name = "AimPanel";
            this.AimPanel.Size = new System.Drawing.Size(425, 359);
            this.AimPanel.TabIndex = 29;
            // 
            // xuiCustomGroupbox4
            // 
            this.xuiCustomGroupbox4.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox4.BorderWidth = 1;
            this.xuiCustomGroupbox4.Controls.Add(this.offsetNum);
            this.xuiCustomGroupbox4.Controls.Add(this.label7);
            this.xuiCustomGroupbox4.Controls.Add(this.snapDelayNum);
            this.xuiCustomGroupbox4.Controls.Add(this.FovYSlider);
            this.xuiCustomGroupbox4.Controls.Add(this.FireRateNum);
            this.xuiCustomGroupbox4.Controls.Add(this.label6);
            this.xuiCustomGroupbox4.Controls.Add(this.FovXSlider);
            this.xuiCustomGroupbox4.Controls.Add(this.label9);
            this.xuiCustomGroupbox4.Controls.Add(this.label10);
            this.xuiCustomGroupbox4.Controls.Add(this.Speed);
            this.xuiCustomGroupbox4.Controls.Add(this.label11);
            this.xuiCustomGroupbox4.Controls.Add(this.FovYBox);
            this.xuiCustomGroupbox4.Controls.Add(this.FovXBox);
            this.xuiCustomGroupbox4.Controls.Add(this.label12);
            this.xuiCustomGroupbox4.Location = new System.Drawing.Point(3, 149);
            this.xuiCustomGroupbox4.Name = "xuiCustomGroupbox4";
            this.xuiCustomGroupbox4.ShowText = true;
            this.xuiCustomGroupbox4.Size = new System.Drawing.Size(415, 200);
            this.xuiCustomGroupbox4.TabIndex = 4;
            this.xuiCustomGroupbox4.TabStop = false;
            this.xuiCustomGroupbox4.Text = "In-Game Resoloution";
            this.xuiCustomGroupbox4.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // offsetNum
            // 
            this.offsetNum.Location = new System.Drawing.Point(54, 106);
            this.offsetNum.Margin = new System.Windows.Forms.Padding(2);
            this.offsetNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.offsetNum.Name = "offsetNum";
            this.offsetNum.Size = new System.Drawing.Size(90, 20);
            this.offsetNum.TabIndex = 35;
            this.offsetNum.ValueChanged += new System.EventHandler(this.OffsetY_changed);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Offset:";
            // 
            // snapDelayNum
            // 
            this.snapDelayNum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.snapDelayNum.Location = new System.Drawing.Point(229, 109);
            this.snapDelayNum.Margin = new System.Windows.Forms.Padding(2);
            this.snapDelayNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.snapDelayNum.Name = "snapDelayNum";
            this.snapDelayNum.Size = new System.Drawing.Size(90, 20);
            this.snapDelayNum.TabIndex = 33;
            this.snapDelayNum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // FovYSlider
            // 
            this.FovYSlider.BarThickness = 4;
            this.FovYSlider.BigStepIncrement = 10;
            this.FovYSlider.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.FovYSlider.KnobColor = System.Drawing.Color.Gray;
            this.FovYSlider.KnobImage = null;
            this.FovYSlider.Location = new System.Drawing.Point(45, 46);
            this.FovYSlider.Name = "FovYSlider";
            this.FovYSlider.Percentage = 50;
            this.FovYSlider.QuickHopping = true;
            this.FovYSlider.Size = new System.Drawing.Size(258, 23);
            this.FovYSlider.SliderStyle = XanderUI.XUISlider.Style.MacOS;
            this.FovYSlider.TabIndex = 24;
            this.FovYSlider.Text = "xuiSlider1";
            this.FovYSlider.UnfilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            this.FovYSlider.Click += new System.EventHandler(this.FovYSlider_Click);
            this.FovYSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FovYSlider_MouseDown);
            this.FovYSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FovYSlider_MouseDown);
            // 
            // FireRateNum
            // 
            this.FireRateNum.Location = new System.Drawing.Point(229, 83);
            this.FireRateNum.Margin = new System.Windows.Forms.Padding(2);
            this.FireRateNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.FireRateNum.Name = "FireRateNum";
            this.FireRateNum.Size = new System.Drawing.Size(90, 20);
            this.FireRateNum.TabIndex = 32;
            this.FireRateNum.ValueChanged += new System.EventHandler(this.FireRate_changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "FOVY:";
            // 
            // FovXSlider
            // 
            this.FovXSlider.BarThickness = 4;
            this.FovXSlider.BigStepIncrement = 10;
            this.FovXSlider.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.FovXSlider.KnobColor = System.Drawing.Color.Gray;
            this.FovXSlider.KnobImage = null;
            this.FovXSlider.Location = new System.Drawing.Point(45, 19);
            this.FovXSlider.Name = "FovXSlider";
            this.FovXSlider.Percentage = 50;
            this.FovXSlider.QuickHopping = true;
            this.FovXSlider.Size = new System.Drawing.Size(258, 23);
            this.FovXSlider.SliderStyle = XanderUI.XUISlider.Style.MacOS;
            this.FovXSlider.TabIndex = 16;
            this.FovXSlider.Text = "xuiSlider1";
            this.FovXSlider.UnfilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            this.FovXSlider.Click += new System.EventHandler(this.FovXSlider_changed);
            this.FovXSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FOVSlider_MouseChanged);
            this.FovXSlider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FOVSlider_MouseChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Speed:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Snap Delay: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Shoot Delay:";
            // 
            // FovYBox
            // 
            this.FovYBox.Location = new System.Drawing.Point(306, 47);
            this.FovYBox.Name = "FovYBox";
            this.FovYBox.Size = new System.Drawing.Size(100, 20);
            this.FovYBox.TabIndex = 7;
            this.FovYBox.TextChanged += new System.EventHandler(this.FovYBox_TextChanged);
            // 
            // FovXBox
            // 
            this.FovXBox.Location = new System.Drawing.Point(306, 21);
            this.FovXBox.Name = "FovXBox";
            this.FovXBox.Size = new System.Drawing.Size(100, 20);
            this.FovXBox.TabIndex = 7;
            this.FovXBox.TextChanged += new System.EventHandler(this.FOVBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "FOVX:";
            // 
            // xuiCustomGroupbox5
            // 
            this.xuiCustomGroupbox5.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox5.BorderWidth = 1;
            this.xuiCustomGroupbox5.Controls.Add(this.AimKeyCombo);
            this.xuiCustomGroupbox5.Controls.Add(this.AimKeyToggle);
            this.xuiCustomGroupbox5.Controls.Add(this.IsHoldToggle);
            this.xuiCustomGroupbox5.Controls.Add(this.TriggerbotBtt);
            this.xuiCustomGroupbox5.Controls.Add(this.AimbotBtt);
            this.xuiCustomGroupbox5.Controls.Add(this.label13);
            this.xuiCustomGroupbox5.Location = new System.Drawing.Point(3, 4);
            this.xuiCustomGroupbox5.Name = "xuiCustomGroupbox5";
            this.xuiCustomGroupbox5.ShowText = true;
            this.xuiCustomGroupbox5.Size = new System.Drawing.Size(415, 122);
            this.xuiCustomGroupbox5.TabIndex = 3;
            this.xuiCustomGroupbox5.TabStop = false;
            this.xuiCustomGroupbox5.Text = "Other";
            this.xuiCustomGroupbox5.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // AimKeyCombo
            // 
            this.AimKeyCombo.FormattingEnabled = true;
            this.AimKeyCombo.Location = new System.Drawing.Point(61, 79);
            this.AimKeyCombo.Name = "AimKeyCombo";
            this.AimKeyCombo.Size = new System.Drawing.Size(121, 21);
            this.AimKeyCombo.TabIndex = 22;
            this.AimKeyCombo.SelectedIndexChanged += new System.EventHandler(this.AimKeyCombo_SelectedIndexChanged);
            this.AimKeyCombo.SelectedValueChanged += new System.EventHandler(this.AimKeyCombo_SelectedIndexChanged);
            this.AimKeyCombo.TextChanged += new System.EventHandler(this.AimKeyCombo_SelectedIndexChanged);
            // 
            // AimKeyToggle
            // 
            this.AimKeyToggle.CheckboxCheckColor = System.Drawing.Color.White;
            this.AimKeyToggle.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.AimKeyToggle.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.AimKeyToggle.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.AimKeyToggle.Checked = false;
            this.AimKeyToggle.ForeColor = System.Drawing.Color.Black;
            this.AimKeyToggle.Location = new System.Drawing.Point(10, 47);
            this.AimKeyToggle.Name = "AimKeyToggle";
            this.AimKeyToggle.Size = new System.Drawing.Size(100, 20);
            this.AimKeyToggle.TabIndex = 20;
            this.AimKeyToggle.Text = "Aim Key";
            this.AimKeyToggle.TickThickness = 2;
            this.AimKeyToggle.Click += new System.EventHandler(this.IsAimKeyChanged);
            // 
            // IsHoldToggle
            // 
            this.IsHoldToggle.CheckboxCheckColor = System.Drawing.Color.White;
            this.IsHoldToggle.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.IsHoldToggle.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.IsHoldToggle.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.IsHoldToggle.Checked = false;
            this.IsHoldToggle.ForeColor = System.Drawing.Color.Black;
            this.IsHoldToggle.Location = new System.Drawing.Point(116, 47);
            this.IsHoldToggle.Name = "IsHoldToggle";
            this.IsHoldToggle.Size = new System.Drawing.Size(100, 20);
            this.IsHoldToggle.TabIndex = 20;
            this.IsHoldToggle.Text = "Hold";
            this.IsHoldToggle.TickThickness = 2;
            this.IsHoldToggle.CheckedStateChanged += new System.EventHandler(this.IsHold_changed);
            // 
            // TriggerbotBtt
            // 
            this.TriggerbotBtt.CheckboxCheckColor = System.Drawing.Color.White;
            this.TriggerbotBtt.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.TriggerbotBtt.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.TriggerbotBtt.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.TriggerbotBtt.Checked = false;
            this.TriggerbotBtt.ForeColor = System.Drawing.Color.Black;
            this.TriggerbotBtt.Location = new System.Drawing.Point(116, 21);
            this.TriggerbotBtt.Name = "TriggerbotBtt";
            this.TriggerbotBtt.Size = new System.Drawing.Size(100, 20);
            this.TriggerbotBtt.TabIndex = 20;
            this.TriggerbotBtt.Text = "Triggerbot";
            this.TriggerbotBtt.TickThickness = 2;
            this.TriggerbotBtt.CheckedStateChanged += new System.EventHandler(this.IsTriggerbot_changed);
            // 
            // AimbotBtt
            // 
            this.AimbotBtt.CheckboxCheckColor = System.Drawing.Color.White;
            this.AimbotBtt.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.AimbotBtt.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.AimbotBtt.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.AimbotBtt.Checked = false;
            this.AimbotBtt.ForeColor = System.Drawing.Color.Black;
            this.AimbotBtt.Location = new System.Drawing.Point(10, 21);
            this.AimbotBtt.Name = "AimbotBtt";
            this.AimbotBtt.Size = new System.Drawing.Size(100, 20);
            this.AimbotBtt.TabIndex = 20;
            this.AimbotBtt.Text = "Aimbot";
            this.AimbotBtt.TickThickness = 2;
            this.AimbotBtt.CheckedStateChanged += new System.EventHandler(this.IsAimbot_changed);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Aim Key:";
            // 
            // MainSegment
            // 
            this.MainSegment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainSegment.Items = "General, Aim";
            this.MainSegment.Location = new System.Drawing.Point(9, 12);
            this.MainSegment.Name = "MainSegment";
            this.MainSegment.SegmentActiveTextColor = System.Drawing.Color.White;
            this.MainSegment.SegmentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(135)))));
            this.MainSegment.SegmentColor = System.Drawing.Color.White;
            this.MainSegment.SegmentInactiveTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.MainSegment.SegmentStyle = XanderUI.XUISegment.Style.Material;
            this.MainSegment.SelectedIndex = 0;
            this.MainSegment.Size = new System.Drawing.Size(428, 30);
            this.MainSegment.TabIndex = 28;
            this.MainSegment.Text = "xuiSegment1";
            this.MainSegment.Click += new System.EventHandler(this.MainSegment_Click);
            // 
            // StartBtt
            // 
            this.StartBtt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(116)))), ((int)(((byte)(79)))));
            this.StartBtt.ButtonImage = ((System.Drawing.Image)(resources.GetObject("StartBtt.ButtonImage")));
            this.StartBtt.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.StartBtt.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.StartBtt.ButtonText = "Start";
            this.StartBtt.CornerRadius = 5;
            this.StartBtt.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.StartBtt.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.StartBtt.HoverTextColor = System.Drawing.Color.White;
            this.StartBtt.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.StartBtt.Location = new System.Drawing.Point(160, 408);
            this.StartBtt.Name = "StartBtt";
            this.StartBtt.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.StartBtt.SelectedTextColor = System.Drawing.Color.White;
            this.StartBtt.Size = new System.Drawing.Size(100, 40);
            this.StartBtt.SuperSelected = false;
            this.StartBtt.TabIndex = 31;
            this.StartBtt.TextColor = System.Drawing.Color.White;
            this.StartBtt.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.StartBtt.Click += new System.EventHandler(this.Start_click);
            // 
            // FV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1313, 562);
            this.Controls.Add(this.GeneralPanel);
            this.Controls.Add(this.AimPanel);
            this.Controls.Add(this.MainSegment);
            this.Controls.Add(this.StartBtt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FV";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FV_FormClosing);
            this.Load += new System.EventHandler(this.Main_load);
            this.Leave += new System.EventHandler(this.FV_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.Speed)).EndInit();
            this.GeneralPanel.ResumeLayout(false);
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            this.xuiCustomGroupbox6.ResumeLayout(false);
            this.xuiCustomGroupbox6.PerformLayout();
            this.AimPanel.ResumeLayout(false);
            this.xuiCustomGroupbox4.ResumeLayout(false);
            this.xuiCustomGroupbox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offsetNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snapDelayNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FireRateNum)).EndInit();
            this.xuiCustomGroupbox5.ResumeLayout(false);
            this.xuiCustomGroupbox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown Speed;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel GeneralPanel;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private XanderUI.XUICheckBox xuiCheckBox1;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox6;
        private System.Windows.Forms.Panel AimPanel;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox4;
        private XanderUI.XUISlider FovXSlider;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox5;
        private System.Windows.Forms.ComboBox AimKeyCombo;
        private XanderUI.XUICheckBox AimbotBtt;
        private System.Windows.Forms.Label label13;
        private XanderUI.XUISegment MainSegment;
        private XanderUI.XUISuperButton StartBtt;
        private System.Windows.Forms.Button ChangeMonitorBtt;
        private XanderUI.XUISlider FovYSlider;
        private System.Windows.Forms.Label label6;
        private XanderUI.XUICheckBox AimKeyToggle;
        private XanderUI.XUICheckBox IsHoldToggle;
        private XanderUI.XUICheckBox TriggerbotBtt;
        private System.Windows.Forms.RadioButton PurpleRadio;
        private System.Windows.Forms.RadioButton RedRadio;
        private System.Windows.Forms.NumericUpDown offsetNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown snapDelayNum;
        private System.Windows.Forms.NumericUpDown FireRateNum;
        private System.Windows.Forms.TextBox FovXBox;
        private System.Windows.Forms.TextBox FovYBox;
        private XanderUI.XUICheckBox ShowFov;
    }
}