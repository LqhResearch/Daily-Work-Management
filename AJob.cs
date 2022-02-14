using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DailyWorkManagement
{
    public partial class AJob : UserControl
    {
        #region Properties
        public PlanItem Job { get; set; }

        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        #endregion
        #region Default loading
        public AJob(PlanItem job)
        {
            InitializeComponent();
            this.Job = job;
            ShowInfo();
        }
        #endregion
        #region Functions
        private void ShowInfo()
        {
            txtJobName.Text = Job.WorkName;
            dtpStartTime.Value = Job.StartDate;
            dtpEndTime.Value = Job.EndDate;
            cboStatus.Text = Job.Status;
            ckbFinishJob.Checked = (cboStatus.Text == "Hoàn thành");
            txtNote.Text = Job.Notes;
        }
        #endregion
        #region Edit and delete
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpStartTime.Value >= dtpEndTime.Value)
            {
                MessageBox.Show("Bạn hãy kiểm tra thời gian kết thúc", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Job.WorkName = txtJobName.Text;
            Job.StartDate = dtpStartTime.Value;
            Job.EndDate = dtpEndTime.Value;
            Job.Status = cboStatus.Text;
            Job.Notes = txtNote.Text;
            if (edited != null)
                edited(this, new EventArgs());
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }
        #endregion

        private void ckbFinishJob_Click(object sender, EventArgs e)
        {
            if (ckbFinishJob.Checked)
                cboStatus.Text = "Hoàn thành";
            else
            {
                if (dtpStartTime.Value.Date <= DateTime.Now.Date && DateTime.Now.Date <= dtpEndTime.Value.Date)
                    cboStatus.Text = "Đang thực hiện";
                else if(DateTime.Now.Date < dtpStartTime.Value.Date)
                    cboStatus.Text = "Sắp đến";
                else
                    cboStatus.Text = "Trễ hạn";
            }
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ckbFinishJob.Checked = (cboStatus.Text == "Hoàn thành");
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan temp = dtpEndTime.Value.Subtract(dtpStartTime.Value);
            txtDays.Text = temp.Days.ToString();
            toolTip.SetToolTip(txtDays, temp.Days + " ngày, " + temp.Hours + " giờ " + temp.Minutes + " phút " + temp.Seconds + " giây");
        }
    }
}