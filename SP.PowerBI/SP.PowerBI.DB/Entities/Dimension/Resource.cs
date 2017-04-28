using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Entities.Dimension
{
    public class Resource : DBBasic
    {
        [EqualKey]
        [ColumnName("Name")]
        public string ResourceName { set; get; } = string.Empty;

        [ColumnName("Alias")]
        public string RAlias { set; get; } = string.Empty;

        [ColumnName("BeyondSoftID")]
        public int RBeyondSoftID { get; set; } = -1;

        [ColumnName("Email")]
        public string REmail { get; set; } = string.Empty;

        [ColumnName("Onboard Date")]
        public DateTime ROnboardDate { set; get; } = new DateTime(2016, 1, 1);

    }
}
