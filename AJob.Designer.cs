
namespace DailyWorkManagement
{
    partial class AJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtDays = new Guna.UI2.WinForms.Guna2TextBox();
            this.picStatus = new System.Windows.Forms.PictureBox();
            this.cboStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpEndTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ckbFinishJob = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dtpStartTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtJobName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.toolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.txtDays);
            this.pnlMain.Controls.Add(this.picStatus);
            this.pnlMain.Controls.Add(this.cboStatus);
            this.pnlMain.Controls.Add(this.txtNote);
            this.pnlMain.Controls.Add(this.dtpEndTime);
            this.pnlMain.Controls.Add(this.ckbFinishJob);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.lblStartTime);
            this.pnlMain.Controls.Add(this.dtpStartTime);
            this.pnlMain.Controls.Add(this.lblEndTime);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.txtJobName);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMain.Location = new System.Drawing.Point(0, 2);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(635, 90);
            this.pnlMain.TabIndex = 0;
            // 
            // txtDays
            // 
            this.txtDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDays.DefaultText = "";
            this.txtDays.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDays.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDays.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDays.DisabledState.Parent = this.txtDays;
            this.txtDays.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDays.FocusedState.Parent = this.txtDays;
            this.txtDays.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDays.ForeColor = System.Drawing.Color.Black;
            this.txtDays.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDays.HoverState.Parent = this.txtDays;
            this.txtDays.Location = new System.Drawing.Point(431, 32);
            this.txtDays.Name = "txtDays";
            this.txtDays.PasswordChar = '\0';
            this.txtDays.PlaceholderText = "";
            this.txtDays.ReadOnly = true;
            this.txtDays.SelectedText = "";
            this.txtDays.ShadowDecoration.Parent = this.txtDays;
            this.txtDays.Size = new System.Drawing.Size(56, 25);
            this.txtDays.TabIndex = 10;
            // 
            // picStatus
            // 
            this.picStatus.BackgroundImage = global::DailyWorkManagement.Properties.Resources.job_list;
            this.picStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picStatus.Location = new System.Drawing.Point(585, 48);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(40, 40);
            this.picStatus.TabIndex = 9;
            this.picStatus.TabStop = false;
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStatus.FocusedState.Parent = this.cboStatus;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStatus.ForeColor = System.Drawing.Color.Black;
            this.cboStatus.HoverState.Parent = this.cboStatus;
            this.cboStatus.ItemHeight = 30;
            this.cboStatus.Items.AddRange(new object[] {
            "Đang thực hiện",
            "Hoàn thành",
            "Sắp đến",
            "Trễ hạn"});
            this.cboStatus.ItemsAppearance.Parent = this.cboStatus;
            this.cboStatus.Location = new System.Drawing.Point(493, 1);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.ShadowDecoration.Parent = this.cboStatus;
            this.cboStatus.Size = new System.Drawing.Size(140, 36);
            this.cboStatus.StartIndex = 0;
            this.cboStatus.TabIndex = 8;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // txtNote
            // 
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.DefaultText = "";
            this.txtNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.DisabledState.Parent = this.txtNote;
            this.txtNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.FocusedState.Parent = this.txtNote;
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNote.ForeColor = System.Drawing.Color.Black;
            this.txtNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.HoverState.Parent = this.txtNote;
            this.txtNote.Location = new System.Drawing.Point(6, 63);
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.PlaceholderText = "Ghi chú";
            this.txtNote.SelectedText = "";
            this.txtNote.ShadowDecoration.Parent = this.txtNote;
            this.txtNote.Size = new System.Drawing.Size(481, 25);
            this.txtNote.TabIndex = 7;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CheckedState.Parent = this.dtpEndTime;
            this.dtpEndTime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpEndTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.dtpEndTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndTime.ForeColor = System.Drawing.Color.White;
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.HoverState.Parent = this.dtpEndTime;
            this.dtpEndTime.Location = new System.Drawing.Point(250, 32);
            this.dtpEndTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShadowDecoration.Parent = this.dtpEndTime;
            this.dtpEndTime.Size = new System.Drawing.Size(175, 25);
            this.dtpEndTime.TabIndex = 1;
            this.dtpEndTime.Value = new System.DateTime(2021, 7, 20, 0, 0, 0, 0);
            this.dtpEndTime.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            // 
            // ckbFinishJob
            // 
            this.ckbFinishJob.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbFinishJob.CheckedState.BorderRadius = 2;
            this.ckbFinishJob.CheckedState.BorderThickness = 0;
            this.ckbFinishJob.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbFinishJob.CheckedState.Parent = this.ckbFinishJob;
            this.ckbFinishJob.Location = new System.Drawing.Point(6, 3);
            this.ckbFinishJob.Name = "ckbFinishJob";
            this.ckbFinishJob.ShadowDecoration.Parent = this.ckbFinishJob;
            this.ckbFinishJob.Size = new System.Drawing.Size(20, 20);
            this.ckbFinishJob.TabIndex = 0;
            this.toolTip.SetToolTip(this.ckbFinishJob, "Trạng thái hoàn thành");
            this.ckbFinishJob.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckbFinishJob.UncheckedState.BorderRadius = 2;
            this.ckbFinishJob.UncheckedState.BorderThickness = 0;
            this.ckbFinishJob.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckbFinishJob.UncheckedState.Parent = this.ckbFinishJob;
            this.ckbFinishJob.Click += new System.EventHandler(this.ckbFinishJob_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::DailyWorkManagement.Properties.Resources.delete;
            this.btnDelete.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDelete.Location = new System.Drawing.Point(539, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnDelete, "Xoá");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(3, 36);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(23, 17);
            this.lblStartTime.TabIndex = 5;
            this.lblStartTime.Text = "Từ";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CheckedState.Parent = this.dtpStartTime;
            this.dtpStartTime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpStartTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(170)))), ((int)(((byte)(109)))));
            this.dtpStartTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartTime.ForeColor = System.Drawing.Color.White;
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.HoverState.Parent = this.dtpStartTime;
            this.dtpStartTime.Location = new System.Drawing.Point(32, 32);
            this.dtpStartTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShadowDecoration.Parent = this.dtpStartTime;
            this.dtpStartTime.Size = new System.Drawing.Size(175, 25);
            this.dtpStartTime.TabIndex = 1;
            this.dtpStartTime.Value = new System.DateTime(2021, 7, 20, 0, 0, 0, 0);
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dtpTime_ValueChanged);
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(213, 36);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(30, 17);
            this.lblEndTime.TabIndex = 5;
            this.lblEndTime.Text = "đến";
            // 
            // btnSave
            // 
            this.btnSave.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = global::DailyWorkManagement.Properties.Resources.save;
            this.btnSave.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSave.Location = new System.Drawing.Point(493, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 6;
            this.toolTip.SetToolTip(this.btnSave, "Lưu");
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtJobName
            // 
            this.txtJobName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJobName.DefaultText = "";
            this.txtJobName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJobName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJobName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJobName.DisabledState.Parent = this.txtJobName;
            this.txtJobName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJobName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJobName.FocusedState.Parent = this.txtJobName;
            this.txtJobName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJobName.ForeColor = System.Drawing.Color.Black;
            this.txtJobName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJobName.HoverState.Parent = this.txtJobName;
            this.txtJobName.Location = new System.Drawing.Point(32, 1);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.PasswordChar = '\0';
            this.txtJobName.PlaceholderText = "Tên công việc";
            this.txtJobName.SelectedText = "";
            this.txtJobName.ShadowDecoration.Parent = this.txtJobName;
            this.txtJobName.Size = new System.Drawing.Size(455, 25);
            this.txtJobName.TabIndex = 3;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.Gold;
            this.pnlLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine.Location = new System.Drawing.Point(0, 0);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(635, 2);
            this.pnlLine.TabIndex = 1;
            // 
            // toolTip
            // 
            this.toolTip.AllowLinksHandling = true;
            this.toolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // AJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlLine);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AJob";
            this.Size = new System.Drawing.Size(635, 92);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private Guna.UI2.WinForms.Guna2TextBox txtJobName;
        private Guna.UI2.WinForms.Guna2CustomCheckBox ckbFinishJob;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndTime;
        private System.Windows.Forms.Panel pnlLine;
        private Guna.UI2.WinForms.Guna2TextBox txtNote;
        private Guna.UI2.WinForms.Guna2ComboBox cboStatus;
        private System.Windows.Forms.PictureBox picStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtDays;
        private Guna.UI2.WinForms.Guna2HtmlToolTip toolTip;
        private System.Windows.Forms.Panel pnlMain;
    }
}
