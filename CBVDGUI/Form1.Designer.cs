namespace CBVDGUI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.MainSegment = new XanderUI.XUISegment();
            this.AimPanel = new System.Windows.Forms.Panel();
            this.xuiCustomGroupbox4 = new XanderUI.XUICustomGroupbox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.xuiSlider3 = new XanderUI.XUISlider();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.xuiSlider4 = new XanderUI.XUISlider();
            this.label12 = new System.Windows.Forms.Label();
            this.xuiCustomGroupbox5 = new XanderUI.XUICustomGroupbox();
            this.xuiCheckBox2 = new XanderUI.XUICheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.xuiCustomGroupbox6 = new XanderUI.XUICustomGroupbox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.SuperButton = new XanderUI.XUISuperButton();
            this.xuiCheckBox1 = new XanderUI.XUICheckBox();
            this.AimPanel.SuspendLayout();
            this.xuiCustomGroupbox4.SuspendLayout();
            this.xuiCustomGroupbox5.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.xuiCustomGroupbox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSegment
            // 
            this.MainSegment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainSegment.Items = "General, Aim";
            this.MainSegment.Location = new System.Drawing.Point(5, 11);
            this.MainSegment.Name = "MainSegment";
            this.MainSegment.SegmentActiveTextColor = System.Drawing.Color.White;
            this.MainSegment.SegmentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(135)))));
            this.MainSegment.SegmentColor = System.Drawing.Color.White;
            this.MainSegment.SegmentInactiveTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.MainSegment.SegmentStyle = XanderUI.XUISegment.Style.Material;
            this.MainSegment.SelectedIndex = 0;
            this.MainSegment.Size = new System.Drawing.Size(348, 30);
            this.MainSegment.TabIndex = 4;
            this.MainSegment.Text = "xuiSegment1";
            this.MainSegment.TabIndexChanged += new System.EventHandler(this.MainSegment_TabIndexChanged);
            this.MainSegment.Click += new System.EventHandler(this.MainSegment_Click);
            // 
            // AimPanel
            // 
            this.AimPanel.Controls.Add(this.xuiCustomGroupbox4);
            this.AimPanel.Controls.Add(this.xuiCustomGroupbox5);
            this.AimPanel.Location = new System.Drawing.Point(384, 47);
            this.AimPanel.Name = "AimPanel";
            this.AimPanel.Size = new System.Drawing.Size(355, 241);
            this.AimPanel.TabIndex = 5;
            // 
            // xuiCustomGroupbox4
            // 
            this.xuiCustomGroupbox4.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox4.BorderWidth = 1;
            this.xuiCustomGroupbox4.Controls.Add(this.textBox8);
            this.xuiCustomGroupbox4.Controls.Add(this.xuiSlider3);
            this.xuiCustomGroupbox4.Controls.Add(this.label9);
            this.xuiCustomGroupbox4.Controls.Add(this.label10);
            this.xuiCustomGroupbox4.Controls.Add(this.textBox9);
            this.xuiCustomGroupbox4.Controls.Add(this.label11);
            this.xuiCustomGroupbox4.Controls.Add(this.textBox10);
            this.xuiCustomGroupbox4.Controls.Add(this.textBox11);
            this.xuiCustomGroupbox4.Controls.Add(this.xuiSlider4);
            this.xuiCustomGroupbox4.Controls.Add(this.label12);
            this.xuiCustomGroupbox4.Location = new System.Drawing.Point(3, 3);
            this.xuiCustomGroupbox4.Name = "xuiCustomGroupbox4";
            this.xuiCustomGroupbox4.ShowText = true;
            this.xuiCustomGroupbox4.Size = new System.Drawing.Size(340, 135);
            this.xuiCustomGroupbox4.TabIndex = 4;
            this.xuiCustomGroupbox4.TabStop = false;
            this.xuiCustomGroupbox4.Text = "In-Game Resoloution";
            this.xuiCustomGroupbox4.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(222, 47);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 14;
            // 
            // xuiSlider3
            // 
            this.xuiSlider3.BarThickness = 4;
            this.xuiSlider3.BigStepIncrement = 10;
            this.xuiSlider3.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xuiSlider3.KnobColor = System.Drawing.Color.Gray;
            this.xuiSlider3.KnobImage = null;
            this.xuiSlider3.Location = new System.Drawing.Point(52, 46);
            this.xuiSlider3.Name = "xuiSlider3";
            this.xuiSlider3.Percentage = 50;
            this.xuiSlider3.QuickHopping = false;
            this.xuiSlider3.Size = new System.Drawing.Size(164, 23);
            this.xuiSlider3.SliderStyle = XanderUI.XUISlider.Style.Windows10;
            this.xuiSlider3.TabIndex = 13;
            this.xuiSlider3.Text = "xuiSlider3";
            this.xuiSlider3.UnfilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Speed:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Snap Delay: ";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(76, 99);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Shoot Delay:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(76, 73);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 8;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(222, 21);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 7;
            // 
            // xuiSlider4
            // 
            this.xuiSlider4.BarThickness = 4;
            this.xuiSlider4.BigStepIncrement = 10;
            this.xuiSlider4.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xuiSlider4.KnobColor = System.Drawing.Color.Gray;
            this.xuiSlider4.KnobImage = null;
            this.xuiSlider4.Location = new System.Drawing.Point(52, 20);
            this.xuiSlider4.Name = "xuiSlider4";
            this.xuiSlider4.Percentage = 50;
            this.xuiSlider4.QuickHopping = false;
            this.xuiSlider4.Size = new System.Drawing.Size(164, 23);
            this.xuiSlider4.SliderStyle = XanderUI.XUISlider.Style.Windows10;
            this.xuiSlider4.TabIndex = 6;
            this.xuiSlider4.Text = "xuiSlider4";
            this.xuiSlider4.UnfilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(169)))), ((int)(((byte)(219)))));
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "FOV:";
            // 
            // xuiCustomGroupbox5
            // 
            this.xuiCustomGroupbox5.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox5.BorderWidth = 1;
            this.xuiCustomGroupbox5.Controls.Add(this.xuiCheckBox2);
            this.xuiCustomGroupbox5.Controls.Add(this.label13);
            this.xuiCustomGroupbox5.Controls.Add(this.label14);
            this.xuiCustomGroupbox5.Controls.Add(this.textBox12);
            this.xuiCustomGroupbox5.Location = new System.Drawing.Point(3, 144);
            this.xuiCustomGroupbox5.Name = "xuiCustomGroupbox5";
            this.xuiCustomGroupbox5.ShowText = true;
            this.xuiCustomGroupbox5.Size = new System.Drawing.Size(340, 86);
            this.xuiCustomGroupbox5.TabIndex = 3;
            this.xuiCustomGroupbox5.TabStop = false;
            this.xuiCustomGroupbox5.Text = "Other";
            this.xuiCustomGroupbox5.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // xuiCheckBox2
            // 
            this.xuiCheckBox2.CheckboxCheckColor = System.Drawing.Color.White;
            this.xuiCheckBox2.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiCheckBox2.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiCheckBox2.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.xuiCheckBox2.Checked = false;
            this.xuiCheckBox2.ForeColor = System.Drawing.Color.White;
            this.xuiCheckBox2.Location = new System.Drawing.Point(76, 22);
            this.xuiCheckBox2.Name = "xuiCheckBox2";
            this.xuiCheckBox2.Size = new System.Drawing.Size(100, 20);
            this.xuiCheckBox2.TabIndex = 20;
            this.xuiCheckBox2.Text = "xuiCheckBox2";
            this.xuiCheckBox2.TickThickness = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Aim Key:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Auto Shoot:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(76, 48);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 17;
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Controls.Add(this.xuiCustomGroupbox6);
            this.GeneralPanel.Location = new System.Drawing.Point(5, 46);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(355, 242);
            this.GeneralPanel.TabIndex = 6;
            // 
            // xuiCustomGroupbox6
            // 
            this.xuiCustomGroupbox6.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox6.BorderWidth = 1;
            this.xuiCustomGroupbox6.Controls.Add(this.xuiCheckBox1);
            this.xuiCustomGroupbox6.Controls.Add(this.label15);
            this.xuiCustomGroupbox6.Controls.Add(this.textBox13);
            this.xuiCustomGroupbox6.Controls.Add(this.label16);
            this.xuiCustomGroupbox6.Controls.Add(this.textBox14);
            this.xuiCustomGroupbox6.Location = new System.Drawing.Point(3, 3);
            this.xuiCustomGroupbox6.Name = "xuiCustomGroupbox6";
            this.xuiCustomGroupbox6.ShowText = true;
            this.xuiCustomGroupbox6.Size = new System.Drawing.Size(340, 100);
            this.xuiCustomGroupbox6.TabIndex = 5;
            this.xuiCustomGroupbox6.TabStop = false;
            this.xuiCustomGroupbox6.Text = "In-Game Resoloution";
            this.xuiCustomGroupbox6.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Height:";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(51, 53);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Width:";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(51, 27);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 1;
            // 
            // SuperButton
            // 
            this.SuperButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(116)))), ((int)(((byte)(79)))));
            this.SuperButton.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SuperButton.ButtonImage")));
            this.SuperButton.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.SuperButton.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.SuperButton.ButtonText = "Start";
            this.SuperButton.CornerRadius = 5;
            this.SuperButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SuperButton.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(90)))), ((int)(((byte)(166)))));
            this.SuperButton.HoverTextColor = System.Drawing.Color.White;
            this.SuperButton.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.SuperButton.Location = new System.Drawing.Point(123, 294);
            this.SuperButton.Name = "SuperButton";
            this.SuperButton.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.SuperButton.SelectedTextColor = System.Drawing.Color.White;
            this.SuperButton.Size = new System.Drawing.Size(100, 40);
            this.SuperButton.SuperSelected = false;
            this.SuperButton.TabIndex = 7;
            this.SuperButton.TextColor = System.Drawing.Color.White;
            this.SuperButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SuperButton.Click += new System.EventHandler(this.xuiSuperButton1_Click);
            // 
            // xuiCheckBox1
            // 
            this.xuiCheckBox1.CheckboxCheckColor = System.Drawing.Color.White;
            this.xuiCheckBox1.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiCheckBox1.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiCheckBox1.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.xuiCheckBox1.Checked = false;
            this.xuiCheckBox1.ForeColor = System.Drawing.Color.Black;
            this.xuiCheckBox1.Location = new System.Drawing.Point(167, 25);
            this.xuiCheckBox1.Name = "xuiCheckBox1";
            this.xuiCheckBox1.Size = new System.Drawing.Size(100, 20);
            this.xuiCheckBox1.TabIndex = 21;
            this.xuiCheckBox1.Text = "Auto Bhop";
            this.xuiCheckBox1.TickThickness = 2;
            this.xuiCheckBox1.Click += new System.EventHandler(this.xuiCheckBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 362);
            this.Controls.Add(this.SuperButton);
            this.Controls.Add(this.GeneralPanel);
            this.Controls.Add(this.AimPanel);
            this.Controls.Add(this.MainSegment);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AimPanel.ResumeLayout(false);
            this.xuiCustomGroupbox4.ResumeLayout(false);
            this.xuiCustomGroupbox4.PerformLayout();
            this.xuiCustomGroupbox5.ResumeLayout(false);
            this.xuiCustomGroupbox5.PerformLayout();
            this.GeneralPanel.ResumeLayout(false);
            this.xuiCustomGroupbox6.ResumeLayout(false);
            this.xuiCustomGroupbox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private XanderUI.XUISegment MainSegment;
        private System.Windows.Forms.Panel AimPanel;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox4;
        private System.Windows.Forms.TextBox textBox8;
        private XanderUI.XUISlider xuiSlider3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private XanderUI.XUISlider xuiSlider4;
        private System.Windows.Forms.Label label12;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox5;
        private XanderUI.XUICheckBox xuiCheckBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Panel GeneralPanel;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox14;
        private XanderUI.XUISuperButton SuperButton;
        private XanderUI.XUICheckBox xuiCheckBox1;
    }
}

