using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Entities.Dimension
{
    public class NewFeature : DBBasic
    {
        [ColumnName("New features")]
        public string NFeatureName { get; set; } = string.Empty;

        [ColumnName("Handoff date")]
        public DateTime NHandoffDate { get; set; } = new DateTime(2016, 1, 1);

        [ColumnName("Supplier resources ramp up a new feature testing task within x days")]
        public float NRampupDays { get; set; } = 0;

        //public string MetaData { get; set; }

    }
}
