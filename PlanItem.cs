using System;
using System.Collections.Generic;
using System.Drawing;

namespace DailyWorkManagement
{
    public enum EPlanItem { DONE, DOING, COMING, MISSED };

    public class PlanItem
    {
        public string WorkName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
    }

    [Serializable]
    public class PlanData
    {
        public List<PlanItem> PlanList { get; set; }
    }
}
