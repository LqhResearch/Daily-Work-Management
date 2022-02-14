
namespace DailyWorkManagement
{
    partial class DailyWorkMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyWorkMain));
            this.pnlDayOfMonth = new System.Windows.Forms.Panel();
            this.btnSunday = new System.Windows.Forms.Label();
            this.btnSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.btnThursday = new System.Windows.Forms.Label();
            this.btnWednesday = new System.Windows.Forms.Label();
            this.btnTuesday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.pnlNotify = new System.Windows.Forms.Panel();
            this.nudNotifyTime = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.ckbNotify = new Guna.UI2.WinForms.Guna2CheckBox();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tmrNotify = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiAllJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToday = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNextMonth = new Guna.UI2.WinForms.Guna2Button();
            this.btnPreviousMonth = new Guna.UI2.WinForms.Guna2Button();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNotifyTime)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDayOfMonth
            // 
            this.pnlDayOfMonth.Location = new System.Drawing.Point(58, 123);
            this.pnlDayOfMonth.Name = "pnlDayOfMonth";
            this.pnlDayOfMonth.Size = new System.Drawing.Size(561, 270);
            this.pnlDayOfMonth.TabIndex = 1;
            // 
            // btnSunday
            // 
            this.btnSunday.BackColor = System.Drawing.Color.White;
            this.btnSunday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSunday.Location = new System.Drawing.Point(544, 80);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(75, 40);
            this.btnSunday.TabIndex = 0;
            this.btnSunday.Text = "Chủ nhật";
            this.btnSunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaturday
            // 
            this.btnSaturday.BackColor = System.Drawing.Color.White;
            this.btnSaturday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSaturday.Location = new System.Drawing.Point(463, 80);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(75, 40);
            this.btnSaturday.TabIndex = 0;
            this.btnSaturday.Text = "Thứ bảy";
            this.btnSaturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriday
            // 
            this.lblFriday.BackColor = System.Drawing.Color.White;
            this.lblFriday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFriday.Location = new System.Drawing.Point(382, 80);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(75, 40);
            this.lblFriday.TabIndex = 0;
            this.lblFriday.Text = "Thứ sáu";
            this.lblFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThursday
            // 
            this.btnThursday.BackColor = System.Drawing.Color.White;
            this.btnThursday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnThursday.Location = new System.Drawing.Point(301, 80);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(75, 40);
            this.btnThursday.TabIndex = 0;
            this.btnThursday.Text = "Thứ năm";
            this.btnThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWednesday
            // 
            this.btnWednesday.BackColor = System.Drawing.Color.White;
            this.btnWednesday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnWednesday.Location = new System.Drawing.Point(220, 80);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(75, 40);
            this.btnWednesday.TabIndex = 0;
            this.btnWednesday.Text = "Thứ tư";
            this.btnWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTuesday
            // 
            this.btnTuesday.BackColor = System.Drawing.Color.White;
            this.btnTuesday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnTuesday.Location = new System.Drawing.Point(139, 80);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(75, 40);
            this.btnTuesday.TabIndex = 0;
            this.btnTuesday.Text = "Thứ ba";
            this.btnTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonday
            // 
            this.lblMonday.BackColor = System.Drawing.Color.White;
            this.lblMonday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonday.Location = new System.Drawing.Point(58, 80);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(75, 40);
            this.lblMonday.TabIndex = 0;
            this.lblMonday.Text = "Thứ hai";
            this.lblMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNotify
            // 
            this.pnlNotify.Controls.Add(this.nudNotifyTime);
            this.pnlNotify.Controls.Add(this.ckbNotify);
            this.pnlNotify.Location = new System.Drawing.Point(3, 32);
            this.pnlNotify.Name = "pnlNotify";
            this.pnlNotify.Size = new System.Drawing.Size(175, 42);
            this.pnlNotify.TabIndex = 3;
            // 
            // nudNotifyTime
            // 
            this.nudNotifyTime.BackColor = System.Drawing.Color.Transparent;
            this.nudNotifyTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNotifyTime.DisabledState.Parent = this.nudNotifyTime;
            this.nudNotifyTime.Enabled = false;
            this.nudNotifyTime.FocusedState.Parent = this.nudNotifyTime;
            this.nudNotifyTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudNotifyTime.ForeColor = System.Drawing.Color.Black;
            this.nudNotifyTime.Location = new System.Drawing.Point(100, 3);
            this.nudNotifyTime.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudNotifyTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNotifyTime.Name = "nudNotifyTime";
            this.nudNotifyTime.ShadowDecoration.Parent = this.nudNotifyTime;
            this.nudNotifyTime.Size = new System.Drawing.Size(72, 36);
            this.nudNotifyTime.TabIndex = 1;
            this.nudNotifyTime.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.nudNotifyTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNotifyTime.ValueChanged += new System.EventHandler(this.nudNotifyTime_ValueChanged);
            // 
            // ckbNotify
            // 
            this.ckbNotify.AutoSize = true;
            this.ckbNotify.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbNotify.CheckedState.BorderRadius = 0;
            this.ckbNotify.CheckedState.BorderThickness = 0;
            this.ckbNotify.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbNotify.Location = new System.Drawing.Point(3, 11);
            this.ckbNotify.Name = "ckbNotify";
            this.ckbNotify.Size = new System.Drawing.Size(91, 21);
            this.ckbNotify.TabIndex = 0;
            this.ckbNotify.Text = "Thông báo";
            this.ckbNotify.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckbNotify.UncheckedState.BorderRadius = 0;
            this.ckbNotify.UncheckedState.BorderThickness = 0;
            this.ckbNotify.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckbNotify.CheckedChanged += new System.EventHandler(this.ckbNotify_CheckedChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CheckedState.Parent = this.dtpDate;
            this.dtpDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.ForeColor = System.Drawing.Color.White;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.HoverState.Parent = this.dtpDate;
            this.dtpDate.Location = new System.Drawing.Point(282, 35);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShadowDecoration.Parent = this.dtpDate;
            this.dtpDate.Size = new System.Drawing.Size(120, 36);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Value = new System.DateTime(2021, 7, 10, 17, 23, 18, 217);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // tmrNotify
            // 
            this.tmrNotify.Enabled = true;
            this.tmrNotify.Interval = 60000;
            this.tmrNotify.Tick += new System.EventHandler(this.tmrNotify_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Lập lịch công việc";
            this.notifyIcon.Visible = true;
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAllJobs,
            this.tsmiToday,
            this.tsmiExit});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(666, 29);
            this.msMenu.TabIndex = 1;
            // 
            // tsmiAllJobs
            // 
            this.tsmiAllJobs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiAllJobs.ForeColor = System.Drawing.Color.White;
            this.tsmiAllJobs.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAllJobs.Image")));
            this.tsmiAllJobs.Name = "tsmiAllJobs";
            this.tsmiAllJobs.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsmiAllJobs.Size = new System.Drawing.Size(115, 25);
            this.tsmiAllJobs.Text = "DS công việc";
            this.tsmiAllJobs.Click += new System.EventHandler(this.tsmiAllJobs_Click);
            // 
            // tsmiToday
            // 
            this.tsmiToday.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiToday.ForeColor = System.Drawing.Color.White;
            this.tsmiToday.Image = global::DailyWorkManagement.Properties.Resources.today;
            this.tsmiToday.Name = "tsmiToday";
            this.tsmiToday.Size = new System.Drawing.Size(92, 25);
            this.tsmiToday.Text = "Hôm nay";
            this.tsmiToday.Click += new System.EventHandler(this.tsmiToday_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiExit.ForeColor = System.Drawing.Color.White;
            this.tsmiExit.Image = global::DailyWorkManagement.Properties.Resources.closed;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(72, 25);
            this.tsmiExit.Text = "Thoát";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.CheckedState.Parent = this.btnNextMonth;
            this.btnNextMonth.CustomImages.Parent = this.btnNextMonth;
            this.btnNextMonth.FillColor = System.Drawing.Color.Transparent;
            this.btnNextMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextMonth.ForeColor = System.Drawing.Color.White;
            this.btnNextMonth.HoverState.Parent = this.btnNextMonth;
            this.btnNextMonth.Image = global::DailyWorkManagement.Properties.Resources.tomorrow;
            this.btnNextMonth.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNextMonth.Location = new System.Drawing.Point(625, 80);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.ShadowDecoration.Parent = this.btnNextMonth;
            this.btnNextMonth.Size = new System.Drawing.Size(40, 40);
            this.btnNextMonth.TabIndex = 2;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.CheckedState.Parent = this.btnPreviousMonth;
            this.btnPreviousMonth.CustomImages.Parent = this.btnPreviousMonth;
            this.btnPreviousMonth.FillColor = System.Drawing.Color.Transparent;
            this.btnPreviousMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPreviousMonth.ForeColor = System.Drawing.Color.White;
            this.btnPreviousMonth.HoverState.Parent = this.btnPreviousMonth;
            this.btnPreviousMonth.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousMonth.Image")));
            this.btnPreviousMonth.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPreviousMonth.Location = new System.Drawing.Point(12, 80);
            this.btnPreviousMonth.Name = "btnPreviousMonth";
            this.btnPreviousMonth.ShadowDecoration.Parent = this.btnPreviousMonth;
            this.btnPreviousMonth.Size = new System.Drawing.Size(40, 40);
            this.btnPreviousMonth.TabIndex = 2;
            this.btnPreviousMonth.Click += new System.EventHandler(this.btnPreviousMonth_Click);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.msMenu;
            // 
            // DailyWorkMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(666, 400);
            this.Controls.Add(this.pnlDayOfMonth);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSunday);
            this.Controls.Add(this.btnPreviousMonth);
            this.Controls.Add(this.pnlNotify);
            this.Controls.Add(this.btnSaturday);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.lblFriday);
            this.Controls.Add(this.btnThursday);
            this.Controls.Add(this.lblMonday);
            this.Controls.Add(this.btnWednesday);
            this.Controls.Add(this.btnTuesday);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DailyWorkMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule work";
            this.Load += new System.EventHandler(this.DailyWorkMain_Load);
            this.pnlNotify.ResumeLayout(false);
            this.pnlNotify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNotifyTime)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlDayOfMonth;
        private System.Windows.Forms.Label btnSunday;
        private System.Windows.Forms.Label btnSaturday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label btnThursday;
        private System.Windows.Forms.Label btnWednesday;
        private System.Windows.Forms.Label btnTuesday;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Panel pnlNotify;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNotifyTime;
        private Guna.UI2.WinForms.Guna2CheckBox ckbNotify;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.Timer tmrNotify;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiAllJobs;
        private Guna.UI2.WinForms.Guna2Button btnPreviousMonth;
        private Guna.UI2.WinForms.Guna2Button btnNextMonth;
        private System.Windows.Forms.ToolStripMenuItem tsmiToday;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}

