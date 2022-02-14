
namespace DailyWorkManagement
{
    partial class PlanADay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanADay));
            this.btnYesterday = new Guna.UI2.WinForms.Guna2Button();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnlJobList = new System.Windows.Forms.Panel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiAddJob = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToday = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTomorrow = new Guna.UI2.WinForms.Guna2Button();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYesterday
            // 
            this.btnYesterday.CheckedState.Parent = this.btnYesterday;
            this.btnYesterday.CustomImages.Parent = this.btnYesterday;
            this.btnYesterday.FillColor = System.Drawing.Color.Transparent;
            this.btnYesterday.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesterday.ForeColor = System.Drawing.Color.White;
            this.btnYesterday.HoverState.Parent = this.btnYesterday;
            this.btnYesterday.Image = global::DailyWorkManagement.Properties.Resources.yesterday;
            this.btnYesterday.ImageSize = new System.Drawing.Size(36, 36);
            this.btnYesterday.Location = new System.Drawing.Point(218, 32);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.ShadowDecoration.Parent = this.btnYesterday;
            this.btnYesterday.Size = new System.Drawing.Size(36, 36);
            this.btnYesterday.TabIndex = 3;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CheckedState.Parent = this.dtpDate;
            this.dtpDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.ForeColor = System.Drawing.Color.White;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.HoverState.Parent = this.dtpDate;
            this.dtpDate.Location = new System.Drawing.Point(260, 32);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShadowDecoration.Parent = this.dtpDate;
            this.dtpDate.Size = new System.Drawing.Size(120, 36);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.Value = new System.DateTime(2021, 7, 10, 17, 23, 18, 217);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // pnlJobList
            // 
            this.pnlJobList.BackColor = System.Drawing.Color.Transparent;
            this.pnlJobList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlJobList.Location = new System.Drawing.Point(0, 74);
            this.pnlJobList.Name = "pnlJobList";
            this.pnlJobList.Size = new System.Drawing.Size(660, 326);
            this.pnlJobList.TabIndex = 0;
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddJob,
            this.tsmiToday,
            this.tsmiExit});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(660, 29);
            this.msMenu.TabIndex = 2;
            // 
            // tsmiAddJob
            // 
            this.tsmiAddJob.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiAddJob.ForeColor = System.Drawing.Color.White;
            this.tsmiAddJob.Image = global::DailyWorkManagement.Properties.Resources.add;
            this.tsmiAddJob.Name = "tsmiAddJob";
            this.tsmiAddJob.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsmiAddJob.Size = new System.Drawing.Size(99, 25);
            this.tsmiAddJob.Text = "Thêm việc";
            this.tsmiAddJob.Click += new System.EventHandler(this.tsmiAddJob_Click);
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
            // btnTomorrow
            // 
            this.btnTomorrow.CheckedState.Parent = this.btnTomorrow;
            this.btnTomorrow.CustomImages.Parent = this.btnTomorrow;
            this.btnTomorrow.FillColor = System.Drawing.Color.Transparent;
            this.btnTomorrow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomorrow.ForeColor = System.Drawing.Color.White;
            this.btnTomorrow.HoverState.Parent = this.btnTomorrow;
            this.btnTomorrow.Image = global::DailyWorkManagement.Properties.Resources.tomorrow;
            this.btnTomorrow.ImageSize = new System.Drawing.Size(36, 36);
            this.btnTomorrow.Location = new System.Drawing.Point(386, 32);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.ShadowDecoration.Parent = this.btnTomorrow;
            this.btnTomorrow.Size = new System.Drawing.Size(36, 36);
            this.btnTomorrow.TabIndex = 3;
            this.btnTomorrow.Click += new System.EventHandler(this.btnTomorrow_Click);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.msMenu;
            // 
            // PlanADay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 400);
            this.Controls.Add(this.btnTomorrow);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.btnYesterday);
            this.Controls.Add(this.pnlJobList);
            this.Controls.Add(this.dtpDate);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PlanADay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailyPlanADay";
            this.Load += new System.EventHandler(this.DailyPlanADay_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnYesterday;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.Panel pnlJobList;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddJob;
        private System.Windows.Forms.ToolStripMenuItem tsmiToday;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private Guna.UI2.WinForms.Guna2Button btnTomorrow;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}