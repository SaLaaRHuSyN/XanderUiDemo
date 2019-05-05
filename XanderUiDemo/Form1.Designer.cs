namespace XanderUiDemo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.xuiJoyStick1 = new XanderUI.XUIJoyStick();
            this.xuiSegment1 = new XanderUI.XUISegment();
            this.xuiNavigationBar1 = new XanderUI.XUINavigationBar();
            this.xuiSwitch1 = new XanderUI.XUISwitch();
            this.xuiCircleProgressBar1 = new XanderUI.XUICircleProgressBar();
            this.xuiBanner1 = new XanderUI.XUIBanner();
            this.xuiBanner2 = new XanderUI.XUIBanner();
            this.xuiBanner3 = new XanderUI.XUIBanner();
            this.xuiCheckBox1 = new XanderUI.XUICheckBox();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 10;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // xuiFormDesign1
            // 
            this.xuiFormDesign1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.xuiFormDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.ExitApplication = true;
            this.xuiFormDesign1.FormStyle = XanderUI.XUIFormDesign.Style.Ubuntu;
            this.xuiFormDesign1.Location = new System.Drawing.Point(0, 0);
            this.xuiFormDesign1.MaterialBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiFormDesign1.MaterialForeColor = System.Drawing.Color.White;
            this.xuiFormDesign1.Name = "xuiFormDesign1";
            this.xuiFormDesign1.ShowMaximize = true;
            this.xuiFormDesign1.ShowMinimize = true;
            this.xuiFormDesign1.Size = new System.Drawing.Size(765, 435);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "C# Ui Academy";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiCheckBox1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiBanner3);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiBanner2);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiBanner1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiCircleProgressBar1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiSwitch1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiNavigationBar1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiSegment1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiJoyStick1);
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiClock1);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 30);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(765, 405);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // xuiClock1
            // 
            this.xuiClock1.CircleThickness = 6;
            this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuiClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.xuiClock1.Font = new System.Drawing.Font("Impact", 15F);
            this.xuiClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.Location = new System.Drawing.Point(586, 2);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = false;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(139, 142);
            this.xuiClock1.TabIndex = 0;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // xuiJoyStick1
            // 
            this.xuiJoyStick1.BackColor = System.Drawing.Color.White;
            this.xuiJoyStick1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xuiJoyStick1.BackgroundImage")));
            this.xuiJoyStick1.JoyStickColor = System.Drawing.Color.DodgerBlue;
            this.xuiJoyStick1.KeepOnScreen = true;
            this.xuiJoyStick1.Location = new System.Drawing.Point(603, 259);
            this.xuiJoyStick1.MovableObject = this.xuiClock1;
            this.xuiJoyStick1.Name = "xuiJoyStick1";
            this.xuiJoyStick1.Sensitivity = 3;
            this.xuiJoyStick1.Size = new System.Drawing.Size(122, 122);
            this.xuiJoyStick1.TabIndex = 1;
            this.xuiJoyStick1.Text = "xuiJoyStick1";
            // 
            // xuiSegment1
            // 
            this.xuiSegment1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiSegment1.Items = "Contacts, Recents, Messages, Dialer";
            this.xuiSegment1.Location = new System.Drawing.Point(51, 14);
            this.xuiSegment1.Name = "xuiSegment1";
            this.xuiSegment1.SegmentActiveTextColor = System.Drawing.Color.White;
            this.xuiSegment1.SegmentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(135)))));
            this.xuiSegment1.SegmentColor = System.Drawing.Color.White;
            this.xuiSegment1.SegmentInactiveTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.xuiSegment1.SegmentStyle = XanderUI.XUISegment.Style.iOS;
            this.xuiSegment1.SelectedIndex = 0;
            this.xuiSegment1.Size = new System.Drawing.Size(386, 62);
            this.xuiSegment1.TabIndex = 2;
            this.xuiSegment1.Text = "xuiSegment1";
            // 
            // xuiNavigationBar1
            // 
            this.xuiNavigationBar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.xuiNavigationBar1.ItemColor = System.Drawing.Color.White;
            this.xuiNavigationBar1.LeftCustomImage = null;
            this.xuiNavigationBar1.LeftCustomText = "CustomBack";
            this.xuiNavigationBar1.LeftItem = XanderUI.XUINavigationBar.NavigationItem.Back;
            this.xuiNavigationBar1.Location = new System.Drawing.Point(31, 353);
            this.xuiNavigationBar1.Name = "xuiNavigationBar1";
            this.xuiNavigationBar1.NavBarStyle = XanderUI.XUINavigationBar.Style.Android;
            this.xuiNavigationBar1.RightCustomImage = null;
            this.xuiNavigationBar1.RightCustomText = "CustomNext";
            this.xuiNavigationBar1.RightItem = XanderUI.XUINavigationBar.NavigationItem.Next;
            this.xuiNavigationBar1.Size = new System.Drawing.Size(300, 40);
            this.xuiNavigationBar1.TabIndex = 3;
            this.xuiNavigationBar1.Text = "xuiNavigationBar1";
            this.xuiNavigationBar1.Title = "Navigation Bar";
            this.xuiNavigationBar1.TitleColor = System.Drawing.Color.White;
            // 
            // xuiSwitch1
            // 
            this.xuiSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.xuiSwitch1.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiSwitch1.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiSwitch1.Location = new System.Drawing.Point(665, 150);
            this.xuiSwitch1.Name = "xuiSwitch1";
            this.xuiSwitch1.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(217)))), ((int)(((byte)(100)))));
            this.xuiSwitch1.Size = new System.Drawing.Size(60, 30);
            this.xuiSwitch1.SwitchState = XanderUI.XUISwitch.State.On;
            this.xuiSwitch1.SwitchStyle = XanderUI.XUISwitch.Style.iOS;
            this.xuiSwitch1.TabIndex = 6;
            this.xuiSwitch1.Text = "xuiSwitch1";
            // 
            // xuiCircleProgressBar1
            // 
            this.xuiCircleProgressBar1.AnimationSpeed = 5;
            this.xuiCircleProgressBar1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.xuiCircleProgressBar1.FilledColorAlpha = 130;
            this.xuiCircleProgressBar1.FilledThickness = 40;
            this.xuiCircleProgressBar1.IsAnimated = false;
            this.xuiCircleProgressBar1.Location = new System.Drawing.Point(387, 259);
            this.xuiCircleProgressBar1.Name = "xuiCircleProgressBar1";
            this.xuiCircleProgressBar1.Percentage = 54;
            this.xuiCircleProgressBar1.ShowText = true;
            this.xuiCircleProgressBar1.Size = new System.Drawing.Size(177, 167);
            this.xuiCircleProgressBar1.TabIndex = 7;
            this.xuiCircleProgressBar1.TextColor = System.Drawing.Color.Gray;
            this.xuiCircleProgressBar1.TextSize = 25;
            this.xuiCircleProgressBar1.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.xuiCircleProgressBar1.UnfilledThickness = 24;
            // 
            // xuiBanner1
            // 
            this.xuiBanner1.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner1.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiBanner1.BorderColor = System.Drawing.Color.White;
            this.xuiBanner1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiBanner1.ForeColor = System.Drawing.Color.White;
            this.xuiBanner1.Location = new System.Drawing.Point(31, 97);
            this.xuiBanner1.Name = "xuiBanner1";
            this.xuiBanner1.Size = new System.Drawing.Size(159, 167);
            this.xuiBanner1.TabIndex = 8;
            this.xuiBanner1.Text = "C#";
            // 
            // xuiBanner2
            // 
            this.xuiBanner2.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner2.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiBanner2.BorderColor = System.Drawing.Color.White;
            this.xuiBanner2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiBanner2.ForeColor = System.Drawing.Color.White;
            this.xuiBanner2.Location = new System.Drawing.Point(222, 82);
            this.xuiBanner2.Name = "xuiBanner2";
            this.xuiBanner2.Size = new System.Drawing.Size(109, 111);
            this.xuiBanner2.TabIndex = 8;
            this.xuiBanner2.Text = "Ui";
            // 
            // xuiBanner3
            // 
            this.xuiBanner3.BackColor = System.Drawing.Color.Transparent;
            this.xuiBanner3.BannerColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.xuiBanner3.BorderColor = System.Drawing.Color.White;
            this.xuiBanner3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiBanner3.ForeColor = System.Drawing.Color.White;
            this.xuiBanner3.Location = new System.Drawing.Point(421, 82);
            this.xuiBanner3.Name = "xuiBanner3";
            this.xuiBanner3.Size = new System.Drawing.Size(159, 167);
            this.xuiBanner3.TabIndex = 8;
            this.xuiBanner3.Text = "Academy";
            // 
            // xuiCheckBox1
            // 
            this.xuiCheckBox1.CheckboxCheckColor = System.Drawing.Color.White;
            this.xuiCheckBox1.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiCheckBox1.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiCheckBox1.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.xuiCheckBox1.Checked = false;
            this.xuiCheckBox1.ForeColor = System.Drawing.Color.Black;
            this.xuiCheckBox1.Location = new System.Drawing.Point(249, 223);
            this.xuiCheckBox1.Name = "xuiCheckBox1";
            this.xuiCheckBox1.Size = new System.Drawing.Size(100, 20);
            this.xuiCheckBox1.TabIndex = 9;
            this.xuiCheckBox1.Text = "Sample";
            this.xuiCheckBox1.TickThickness = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 435);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private XanderUI.XUIFormDesign xuiFormDesign1;
        private XanderUI.XUIClock xuiClock1;
        private XanderUI.XUIJoyStick xuiJoyStick1;
        private XanderUI.XUISegment xuiSegment1;
        private XanderUI.XUINavigationBar xuiNavigationBar1;
        private XanderUI.XUISwitch xuiSwitch1;
        private XanderUI.XUICheckBox xuiCheckBox1;
        private XanderUI.XUIBanner xuiBanner3;
        private XanderUI.XUIBanner xuiBanner2;
        private XanderUI.XUIBanner xuiBanner1;
        private XanderUI.XUICircleProgressBar xuiCircleProgressBar1;
    }
}

