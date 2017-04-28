using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Entities.Dimension
{
    public class Bug : DBBasic
    {
        [Required]
        [ColumnName("Bug ID")]
        [EqualKey]
        public int BugID { get; set; } = -1;

        [ColumnName("Area")]
        public string BArea { get; set; } = string.Empty;

        [ColumnName("Feature")]
        public string BFeature { get; set; } = string.Empty;

        [ColumnName("Severity")]
        public int BSeverity { get; set; } = -1;

        [ColumnName("Open date")]
        public DateTime BOpenDate { set; get; } = new DateTime(2016,1,1);

        [ColumnName("Open by")]
        public string BOpenBy { set; get; } = string.Empty;

        [ColumnName("Comments")]
        public string BComments { set; get; } = string.Empty;
    }
}
