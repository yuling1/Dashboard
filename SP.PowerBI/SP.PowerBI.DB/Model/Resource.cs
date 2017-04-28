using SP.PowerBI.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Model
{
    public class Resource
    {
        [ColumnName("Name")]
        public string ResourceName { set; get; } = string.Empty;

        [ColumnName("Alias")]
        public string RAlias { set; get; } = string.Empty;

        [ColumnName("Onboard Date")]
        public DateTime ROnboardDate { set; get; } = new DateTime(2016, 1, 1);

        [ColumnName("Title")]
        public string MicroTitle { set; get; } = string.Empty;

        [ColumnName("Skillset")]
        public int Level { set; get; } = 0;

        [ColumnName("Ramp up time")]
        public float RRampUpTime { set; get; } = 2;

        [ColumnName("Attrition")]
        public string RHasAttrition { set; get; } = string.Empty;

        //public string MetaData { set; get; }

        public string TeamName { set; get; } = "SharePoint";
    }
}
