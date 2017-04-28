using SP.PowerBI.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Model
{
    public class Handoff 
    {
        [ColumnName("Test pass x")]
        public string HTestPass { set; get; } = string.Empty;

        [ColumnName("Total test cases")]
        public int HTotalCount { set; get; } = 0;

        [ColumnName("Excution test cases count")]
        public int HExcutionCount { set; get; } = 0;

        [ColumnName("Required QFE bugs Number")]
        public int HRequiredQFEBugNum { set; get; } = 0;

        [ColumnName("Validated QFE bugs Number")]
        public int HValidatedQFEBugNum { set; get; } = 0;

        [ColumnName("Test pass time(day)")]
        public float HTestPassTime { set; get; } = 0;

        public string TeamName { set; get; } = "SharePoint";
    }
}
