using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Entities.Dimension
{
    public class ResourceAdditionalInfo : DBBasic
    {
        [ColumnName("Attrition")]
        public string RHasAttrition { set; get; } = string.Empty;

        [ColumnName("Ramp up time")]
        public float RRampUpTime { set; get; } = 2;

        //public string MetaData { set; get; }

    }
}
