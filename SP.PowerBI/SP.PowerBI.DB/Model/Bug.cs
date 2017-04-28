using SP.PowerBI.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Model
{
    public class Bug
    {
        [ColumnName("Bug ID")]
        public int BugID { get; set; } = -1;

        [ColumnName("Area")]
        public string BArea { get; set; } = string.Empty;

        [ColumnName("Feature")]
        public string BFeature { get; set; } = string.Empty;

        [ColumnName("Severity")]
        public int BSeverity { get; set; } = 0;

        [ColumnName("Open date")]
        public DateTime BOpenDate { set; get; } = new DateTime(2016, 1, 1);

        [ColumnName("Change date")]
        public DateTime BChangeDate { set; get; } = new DateTime(2016, 1, 1);

        [ColumnName("Status")]
        public string BStatus { set; get; } = string.Empty;

        [ColumnName("Resolution")]
        public string BResolution { set; get; } = string.Empty;

        [ColumnName("Open by")]
        public string BOpenBy { set; get; } = string.Empty;

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

        [ColumnName("Comments")]
        public string BComments { set; get; } = string.Empty;

        public string TeamName { set; get; } = "SharePoint";

    }
}
