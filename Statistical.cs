using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DailyWorkManagement
{
    public partial class Statistical : Form
    {
        #region Properties
        public PlanData AllPlans { get; set; }
        #endregion
        public Statistical(PlanData allPlans)
        {
            InitializeComponent();
            AllPlans = allPlans;
            dgvJobLists.DataSource = GetJobsTowDates(DateTime.Now, DateTime.Now);
            Guna2HtmlToolTip toolTip = new Guna2HtmlToolTip();
            toolTip.SetToolTip(btnFilter, "Tìm kiếm");
        }
        #region Common function
        private List<PlanItem> GetJobsTowDates(DateTime startTime, DateTime endTime)
        {
            return AllPlans.PlanList.Where(p => startTime.Date <= p.EndDate.Date && p.StartDate.Date <= endTime.Date).ToList();
        }
        #endregion
        #region Menu strip
        private void tsmiAllJob_Click(object sender, EventArgs e)
        {
            dgvJobLists.DataSource = AllPlans.PlanList;
        }

        private void tsmiThisWeek_Click(object sender, EventArgs e)
        {
            if ((int)DateTime.Now.DayOfWeek == 0)
            {
                dtpEndTime.Value = DateTime.Now;
                dtpStartTime.Value = dtpEndTime.Value.AddDays(-6);
            }
            else
            {
                dtpStartTime.Value = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek + 1);
                dtpEndTime.Value = dtpStartTime.Value.AddDays(6);
            }
            dgvJobLists.DataSource = GetJobsTowDates(dtpStartTime.Value, dtpEndTime.Value);
        }

        private void tsmiThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEndTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, (int)DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            dgvJobLists.DataSource = GetJobsTowDates(dtpStartTime.Value, dtpEndTime.Value);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Event
        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (dtpStartTime.Value <= dtpEndTime.Value)
                dgvJobLists.DataSource = GetJobsTowDates(dtpStartTime.Value, dtpEndTime.Value);
            else
                MessageBox.Show("Bạn hãy kiểm tra lại thời gian kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvJobLists_DataSourceChanged(object sender, EventArgs e)
        {
            int coming = 0, processing = 0, finish = 0, late = 0;
            for (int i = 0; i < dgvJobLists.RowCount; i++)
            {
                string temp = dgvJobLists.Rows[i].Cells[3].Value.ToString();
                if (temp == "Sắp đến")
                    coming++;
                else if (temp == "Đang thực hiện")
                    processing++;
                else if (temp == "Hoàn thành")
                    finish++;
                else
                    late++;
            }
            tsslNumJob.Text = dgvJobLists.RowCount + " công việc";
            tsslComing.Text = coming + " sắp đến";
            tsslProcessing.Text = processing + " đang thực hiện";
            tsslFinish.Text = finish + " hoàn thành";
            tsslLate.Text = late + " trễ hạn";

            dgvJobLists.Columns[0].HeaderText = "Tên công việc";
            dgvJobLists.Columns[1].HeaderText = "Thời gian bắt đầu";
            dgvJobLists.Columns[2].HeaderText = "Thời gian kết thúc";
            dgvJobLists.Columns[3].HeaderText = "Trạng thái";
            dgvJobLists.Columns[4].HeaderText = "Ghi chú";
        }
        #endregion
    }
}