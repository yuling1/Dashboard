using SP.PowerBI.DB.Entities.Dimension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Entities.Fact
{
    public class NewFeatureChanges : DBBasic
    {
        [ColumnName("One Test pass time")]
        public float NTestTime { get; set; } = 0;

        [ColumnName("Test pass")]
        public int NTestPassNum { get; set; } = 0;

        public NewFeature NewFeatureInfo { set; get; }

        public Team NTeamInfo { set; get; }
    }
}
