
namespace DailyWorkManagement
{
    partial class Statistical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistical));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAllJob = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLine = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiThisWeek = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThisMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpEndTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dtpStartTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.dgvJobLists = new Guna.UI2.WinForms.Guna2DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslNumJob = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslProcessing = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslFinish = new System.Windows.Forms.ToolStripStatusLabel();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tsslComing = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobLists)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(141)))));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiJobs,
            this.tsmiExit});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(665, 29);
            this.msMenu.TabIndex = 2;
            // 
            // tsmiJobs
            // 
            this.tsmiJobs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAllJob,
            this.tsmiLine,
            this.tsmiThisWeek,
            this.tsmiThisMonth});
            this.tsmiJobs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiJobs.ForeColor = System.Drawing.Color.White;
            this.tsmiJobs.Image = ((System.Drawing.Image)(resources.GetObject("tsmiJobs.Image")));
            this.tsmiJobs.Name = "tsmiJobs";
            this.tsmiJobs.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tsmiJobs.Size = new System.Drawing.Size(96, 25);
            this.tsmiJobs.Text = "Công việc";
            // 
            // tsmiAllJob
            // 
            this.tsmiAllJob.Name = "tsmiAllJob";
            this.tsmiAllJob.Size = new System.Drawing.Size(175, 22);
            this.tsmiAllJob.Text = "Tất cả công việc";
            this.tsmiAllJob.Click += new System.EventHandler(this.tsmiAllJob_Click);
            // 
            // tsmiLine
            // 
            this.tsmiLine.Name = "tsmiLine";
            this.tsmiLine.Size = new System.Drawing.Size(172, 6);
            // 
            // tsmiThisWeek
            // 
            this.tsmiThisWeek.Name = "tsmiThisWeek";
            this.tsmiThisWeek.Size = new System.Drawing.Size(175, 22);
            this.tsmiThisWeek.Text = "Tuần này";
            this.tsmiThisWeek.Click += new System.EventHandler(this.tsmiThisWeek_Click);
            // 
            // tsmiThisMonth
            // 
            this.tsmiThisMonth.Name = "tsmiThisMonth";
            this.tsmiThisMonth.Size = new System.Drawing.Size(175, 22);
            this.tsmiThisMonth.Text = "Tháng này";
            this.tsmiThisMonth.Click += new System.EventHandler(this.tsmiThisMonth_Click);
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
            // dtpEndTime
            // 
            this.dtpEndTime.CheckedState.Parent = this.dtpEndTime;
            this.dtpEndTime.CustomFormat = "dddd dd/MM/yyyy";
            this.dtpEndTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.dtpEndTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndTime.ForeColor = System.Drawing.Color.White;
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.HoverState.Parent = this.dtpEndTime;
            this.dtpEndTime.Location = new System.Drawing.Point(355, 32);
            this.dtpEndTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShadowDecoration.Parent = this.dtpEndTime;
            this.dtpEndTime.Size = new System.Drawing.Size(175, 25);
            this.dtpEndTime.TabIndex = 6;
            this.dtpEndTime.Value = new System.DateTime(2021, 7, 20, 0, 0, 0, 0);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(108, 36);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(23, 17);
            this.lblStartTime.TabIndex = 8;
            this.lblStartTime.Text = "Từ";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CheckedState.Parent = this.dtpStartTime;
            this.dtpStartTime.CustomFormat = "dddd dd/MM/yyyy";
            this.dtpStartTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.dtpStartTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartTime.ForeColor = System.Drawing.Color.White;
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.HoverState.Parent = this.dtpStartTime;
            this.dtpStartTime.Location = new System.Drawing.Point(137, 32);
            this.dtpStartTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShadowDecoration.Parent = this.dtpStartTime;
            this.dtpStartTime.Size = new System.Drawing.Size(175, 25);
            this.dtpStartTime.TabIndex = 7;
            this.dtpStartTime.Value = new System.DateTime(2021, 7, 20, 0, 0, 0, 0);
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(318, 36);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(30, 17);
            this.lblEndTime.TabIndex = 9;
            this.lblEndTime.Text = "đến";
            // 
            // btnFilter
            // 
            this.btnFilter.CheckedState.Parent = this.btnFilter;
            this.btnFilter.CustomImages.Parent = this.btnFilter;
            this.btnFilter.FillColor = System.Drawing.Color.Transparent;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.HoverState.Parent = this.btnFilter;
            this.btnFilter.Image = global::DailyWorkManagement.Properties.Resources.filter;
            this.btnFilter.Location = new System.Drawing.Point(536, 32);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ShadowDecoration.Parent = this.btnFilter;
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dgvJobLists
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvJobLists.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJobLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvJobLists.BackgroundColor = System.Drawing.Color.White;
            this.dgvJobLists.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvJobLists.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvJobLists.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJobLists.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJobLists.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJobLists.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvJobLists.EnableHeadersVisualStyles = false;
            this.dgvJobLists.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvJobLists.Location = new System.Drawing.Point(12, 63);
            this.dgvJobLists.Name = "dgvJobLists";
            this.dgvJobLists.ReadOnly = true;
            this.dgvJobLists.RowHeadersVisible = false;
            this.dgvJobLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobLists.Size = new System.Drawing.Size(643, 308);
            this.dgvJobLists.TabIndex = 11;
            this.dgvJobLists.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvJobLists.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvJobLists.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvJobLists.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvJobLists.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvJobLists.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvJobLists.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvJobLists.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvJobLists.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvJobLists.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvJobLists.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvJobLists.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvJobLists.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvJobLists.ThemeStyle.ReadOnly = true;
            this.dgvJobLists.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvJobLists.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvJobLists.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvJobLists.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvJobLists.ThemeStyle.RowsStyle.Height = 22;
            this.dgvJobLists.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvJobLists.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvJobLists.DataSourceChanged += new System.EventHandler(this.dgvJobLists_DataSourceChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslNumJob,
            this.tsslLine,
            this.tsslComing,
            this.tsslProcessing,
            this.tsslFinish,
            this.tsslLate});
            this.statusStrip.Location = new System.Drawing.Point(0, 374);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(665, 26);
            this.statusStrip.TabIndex = 12;
            // 
            // tsslNumJob
            // 
            this.tsslNumJob.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslNumJob.ForeColor = System.Drawing.Color.White;
            this.tsslNumJob.Name = "tsslNumJob";
            this.tsslNumJob.Padding = new System.Windows.Forms.Padding(2);
            this.tsslNumJob.Size = new System.Drawing.Size(78, 21);
            this.tsslNumJob.Text = "0 công việc";
            // 
            // tsslProcessing
            // 
            this.tsslProcessing.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslProcessing.ForeColor = System.Drawing.Color.White;
            this.tsslProcessing.Name = "tsslProcessing";
            this.tsslProcessing.Padding = new System.Windows.Forms.Padding(2);
            this.tsslProcessing.Size = new System.Drawing.Size(110, 21);
            this.tsslProcessing.Text = "0 đang thực hiện";
            // 
            // tsslFinish
            // 
            this.tsslFinish.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslFinish.ForeColor = System.Drawing.Color.White;
            this.tsslFinish.Name = "tsslFinish";
            this.tsslFinish.Padding = new System.Windows.Forms.Padding(2);
            this.tsslFinish.Size = new System.Drawing.Size(88, 21);
            this.tsslFinish.Text = "0 hoàn thành";
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.msMenu;
            // 
            // tsslComing
            // 
            this.tsslComing.ForeColor = System.Drawing.Color.White;
            this.tsslComing.Name = "tsslComing";
            this.tsslComing.Size = new System.Drawing.Size(57, 21);
            this.tsslComing.Text = "0 sắp đến";
            // 
            // tsslLate
            // 
            this.tsslLate.ForeColor = System.Drawing.Color.White;
            this.tsslLate.Name = "tsslLate";
            this.tsslLate.Size = new System.Drawing.Size(53, 21);
            this.tsslLate.Text = "0 trễ hạn";
            // 
            // tsslLine
            // 
            this.tsslLine.ForeColor = System.Drawing.Color.White;
            this.tsslLine.Name = "tsslLine";
            this.tsslLine.Size = new System.Drawing.Size(10, 21);
            this.tsslLine.Text = "|";
            // 
            // Statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 400);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dgvJobLists);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Statistical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistical";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobLists)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiJobs;
        private System.Windows.Forms.ToolStripMenuItem tsmiAllJob;
        private System.Windows.Forms.ToolStripSeparator tsmiLine;
        private System.Windows.Forms.ToolStripMenuItem tsmiThisWeek;
        private System.Windows.Forms.ToolStripMenuItem tsmiThisMonth;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvJobLists;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslNumJob;
        private System.Windows.Forms.ToolStripStatusLabel tsslProcessing;
        private System.Windows.Forms.ToolStripStatusLabel tsslFinish;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.ToolStripStatusLabel tsslComing;
        private System.Windows.Forms.ToolStripStatusLabel tsslLine;
        private System.Windows.Forms.ToolStripStatusLabel tsslLate;
    }
}