using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DailyWorkManagement
{
    public partial class DailyWorkMain : Form
    {
        #region Properties
        public List<List<Guna2Button>> Matrix { get; set; }
        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private string filePath = "data\\user.xml";
        private PlanData JobList { get; set; }
        private int SoftTime { get; set; }
        #endregion
        #region Default loading
        public DailyWorkMain()
        {
            InitializeComponent();
            Guna2HtmlToolTip toolTip = new Guna2HtmlToolTip();
            toolTip.SetToolTip(btnPreviousMonth, "Tháng trước");
            toolTip.SetToolTip(btnNextMonth, "Tháng sau");
        }

        private void DailyWorkMain_Load(object sender, EventArgs e)
        {
            tmrNotify.Start();
            SoftTime = 0;
            LoadMatrix();

            try
            {
                JobList = XmlSerialize.DeserializeToXML(filePath) as PlanData;
            }
            catch (Exception)
            {
                SetDefaultWork();
            }
            dtpDate.Value = DateTime.Now;
            UpdateStatus();
            TodayWork();
        }
        #endregion
        #region Functions
        private void RegisterStartWindows()
        {
            RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\NewScheduleWork");
            RegistryKey regstart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"); // Mở registry khởi động cùng win
            string keyvalue = "1";
            try
            {
                regkey.SetValue("Index", keyvalue);
                regstart.SetValue("NewScheduleWork", Application.StartupPath + "\\DailyWorkManagement.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetDefaultWork()
        {
            JobList = new PlanData();
            JobList.PlanList = new List<PlanItem>();

            JobList.PlanList.Add(new PlanItem()
            {
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddHours(1),
                WorkName = "Công việc 1",
                Status = "Đang thực hiện",
                Notes = ""
            });
        }

        private void ClearValueMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Matrix[i][j].Text = "";
                    Matrix[i][j].FillColor = Contents.btnColor;
                }
        }

        private void AddNumberIntoMatrixByDate(DateTime date)
        {
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int row = 0;

            for (int i = 1; i <= DateTime.DaysInMonth(useDate.Year, useDate.Month); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Matrix[row][column].Text = i.ToString();

                if (useDate.Date == DateTime.Now.Date) // Ngày hôm nay
                    Matrix[row][column].FillColor = Contents.todayDate;
                if (useDate.Date == dtpDate.Value.Date) // Ngày được chọn
                    Matrix[row][column].FillColor = Contents.selectDate;

                if (column == 6)
                    row++;
                useDate = useDate.AddDays(1);
            }
        }

        private void LoadMatrix()
        {
            Matrix = new List<List<Guna2Button>>();

            Guna2Button oldBtn = new Guna2Button() { Size = new Size(-Contents.margin, 0), Location = new Point(0, 0) };
            for (int i = 0; i < Contents.dayOfColumn; i++)
            {
                Matrix.Add(new List<Guna2Button>());
                for (int j = 0; j < Contents.dayOfWeek; j++)
                {
                    Guna2Button btn = new Guna2Button() { Size = new Size(Contents.dateButtonWidth, Contents.dateButtonHeight) };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Contents.margin, oldBtn.Location.Y);
                    btn.Tag = (i * Contents.dayOfWeek) + j.ToString();
                    btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    btn.FillColor = Contents.btnColor;
                    btn.ForeColor = Color.White;
                    btn.Click += Btn_Click;

                    pnlDayOfMonth.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Guna2Button() { Size = new Size(-Contents.margin, 0), Location = new Point(0, oldBtn.Location.Y + Contents.dateButtonHeight + Contents.margin) };
            }
            AddNumberIntoMatrixByDate(dtpDate.Value);
        }

        private void UpdateStatus()
        {
            for (int i = 0; i < JobList.PlanList.Count; i++)
            {
                DateTime startDate = JobList.PlanList[i].StartDate;
                DateTime endDate = JobList.PlanList[i].EndDate;
                if (DateTime.Now.Date < startDate.Date)
                    JobList.PlanList[i].Status = "Sắp đến";
                else if (DateTime.Now.Date > endDate.Date)
                    JobList.PlanList[i].Status = "Trễ hạn";
                else if (JobList.PlanList[i].Status != "Hoàn thành" && startDate.Date <= DateTime.Now.Date && DateTime.Now.Date <= endDate.Date)
                    JobList.PlanList[i].Status = "Đang thực hiện";
            }

        }
        #endregion
        #region Event
        private void Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Guna2Button).Text))
                return;

            PlanADay daily = new PlanADay(JobList, new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, Convert.ToInt32((sender as Guna2Button).Text)));
            this.Hide();
            daily.ShowDialog();
            this.Show();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ClearValueMatrix();
            AddNumberIntoMatrixByDate((sender as Guna2DateTimePicker).Value);
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddMonths(-1);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddMonths(1);
        }

        private void tmrNotify_Tick(object sender, EventArgs e)
        {
            if (!ckbNotify.Checked) // Nút thông báo không được chọn
                return;
            SoftTime++;
            if (SoftTime < Contents.notifyTime)
                return;
            if (JobList == null || JobList.PlanList == null)
                return;
            TodayWork();
            SoftTime = 0;
        }

        private void TodayWork()
        {
            int coming = 0, processing = 0, late = 0;
            for (int i = 0; i < JobList.PlanList.Count; i++)
            {
                DateTime startDate = JobList.PlanList[i].StartDate;
                DateTime endDate = JobList.PlanList[i].EndDate;

                // Thông báo công việc trong 3 ngày tới
                if (DateTime.Now.Date < startDate.Date && startDate.Date.Subtract(DateTime.Now.Date).Days <= 3)
                    coming++;
                else if (startDate.Date <= DateTime.Now.Date && DateTime.Now.Date <= endDate.Date)
                    processing++;
                else if (endDate.Date == DateTime.Now.AddDays(-1).Date) // Trễ 1 ngày
                    late++;
            }

            notifyIcon.ShowBalloonTip(Contents.notifyTimeOut, "Lịch làm việc hôm nay",
                processing + " công việc cần thực hiện\n" +
                late + " công việc đã hết hạn hôm qua\n" +
                coming + " công việc sắp đến trong 3 ngày tới",
                ToolTipIcon.Info);
        }

        private void nudNotifyTime_ValueChanged(object sender, EventArgs e)
        {
            Contents.notifyTime = (int)nudNotifyTime.Value;
        }

        private void ckbNotify_CheckedChanged(object sender, EventArgs e)
        {
            nudNotifyTime.Enabled = ckbNotify.Checked;
        }
        #endregion
        #region Menu strip
        private void tsmiAllJobs_Click(object sender, EventArgs e)
        {
            Statistical statistical = new Statistical(JobList);
            this.Hide();
            statistical.ShowDialog();
            this.Show();
        }

        private void tsmiToday_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                XmlSerialize.SerializeToXML(JobList, filePath);
                this.Close();
            }
        }
        #endregion
    }
}