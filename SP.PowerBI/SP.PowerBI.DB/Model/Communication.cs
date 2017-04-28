using SP.PowerBI.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Model
{
    public class Communication
    {
        [ColumnName("Time")]
        public DateTime CCreatWeek { set; get; } = new DateTime(2016, 1, 1);

        [ColumnName("Average Microsoft Fulltime employee request response within x hours")]
        public float CAverageResponseTime { set; get; } = 0;

        [ColumnName("Communication to Microsoft with test Plan, test owner, test schedule")]
        public string CIsWithPlan { set; get; } = string.Empty;

        [ColumnName("Technical issues were resolved by date agreed upon by Microsoft and supplier")]
        public string CIssuesResolvedByDate { set; get; } = string.Empty;

        public string TeamName { set; get; } = "SharePoint";

    }
}
