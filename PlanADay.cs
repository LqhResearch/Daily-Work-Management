using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DailyWorkManagement
{
    public partial class PlanADay : Form
    {
        #region Properties
        FlowLayoutPanel fpnlCurrentPlan = new FlowLayoutPanel(); // Lưu trữ danh sách công việc trong ngày
        public DateTime Date { get; set; } // Ngày đang chọn
        public PlanData AllPlans { get; set; }
        #endregion
        #region Default loading
        public PlanADay(PlanData job, DateTime date)
        {
            InitializeComponent();
            AllPlans = job;
            Date = date;
            Guna2HtmlToolTip toolTip = new Guna2HtmlToolTip();
            toolTip.SetToolTip(btnYesterday, "Hôm qua");
            toolTip.SetToolTip(btnTomorrow, "Ngày mai");
        }

        private void DailyPlanADay_Load(object sender, EventArgs e)
        {
            fpnlCurrentPlan.Size = pnlJobList.Size;
            fpnlCurrentPlan.AutoScroll = true;
            pnlJobList.Controls.Add(fpnlCurrentPlan);

            dtpDate.Value = Date;
        }
        #endregion
        #region Functions
        private List<PlanItem> GetJobByDay(DateTime date)
        {
            return AllPlans.PlanList.Where(p => p.StartDate.Date <= date.Date && date.Date <= p.EndDate.Date).ToList();
        }

        private void ShowWorkByDate(DateTime date)
        {
            fpnlCurrentPlan.Controls.Clear();
            if (AllPlans != null && AllPlans.PlanList != null)
            {
                List<PlanItem> todayJob = GetJobByDay(date);
                for (int i = 0; i < todayJob.Count; i++)
                    AddJob(todayJob[i]);
            }
        }

        private void AddJob(PlanItem job)
        {
            AJob aJob = new AJob(job);
            aJob.Edited += AJob_Edited;
            aJob.Deleted += AJob_Deleted;

            fpnlCurrentPlan.Controls.Add(aJob);
        }
        #endregion
        #region Events
        private void AJob_Edited(object sender, EventArgs e) { }

        private void AJob_Deleted(object sender, EventArgs e)
        {
            AJob uc = sender as AJob;
            PlanItem job = uc.Job;

            fpnlCurrentPlan.Controls.Remove(uc);
            AllPlans.PlanList.Remove(job);
        }
        private void btnYesterday_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddDays(-1);
        }

        private void btnTomorrow_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddDays(1);
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ShowWorkByDate((sender as Guna2DateTimePicker).Value);
        }
        #endregion
        #region Menu strip
        private void tsmiAddJob_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem()
            {
                WorkName = "Công việc",
                StartDate = dtpDate.Value,
                EndDate = dtpDate.Value,
                Status = "Đang thực hiện",
                Notes = ""
            };
            AllPlans.PlanList.Add(item);
            AddJob(item);
        }

        private void tsmiToday_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}