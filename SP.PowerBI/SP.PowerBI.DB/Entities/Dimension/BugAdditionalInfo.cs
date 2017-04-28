using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Entities.Dimension
{
    public class BugAdditionalInfo : DBBasic
    {
        [ColumnName("Found from which work item")]
        public string BWorkItemFrom { set; get; } = string.Empty;

        [ColumnName("Test pass X")]
        public string BTestPass { set; get; } = string.Empty;

        [ColumnName("From test cases")]
        public string BIsFromCases { set; get; } = string.Empty;

        [ColumnName("From Ad-hoc")]
        public string BIsFromAdHoc { set; get; } = string.Empty;

        [ColumnName("Valid or not")]
        public string BIsValid { set; get; } = string.Empty;

        [ColumnName("Bug validation time after build ready")]
        public float BugValidationTime { set; get; } = 0.5f;

        [ColumnName("Mis-opened bug")]
        public string BIsMisOpend { set; get; } = string.Empty;

        [ColumnName("Miss bug from Test cases execution")]
        public string BIsMissedFromCases { set; get; } = string.Empty;


    }
}
