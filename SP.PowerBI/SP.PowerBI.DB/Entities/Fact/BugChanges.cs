using SP.PowerBI.DB.Entities.Dimension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Entities.Fact
{
    public class BugChanges : DBBasic
    {

        [ColumnName("Change date")]
        public DateTime BChangeDate { set; get; } = new DateTime(2016, 1, 1);

        [ColumnName("Status")]
        public string BStatus { set; get; } = string.Empty;

        [ColumnName("Resolution")]
        public string BResolution { set; get; } = string.Empty;

        [EqualKey]
        public Bug BugBasicInfo { set; get; }

        public BugAdditionalInfo BugAdditionalInfo { set; get; }

        public Team BTeamInfo { set; get; }

    }
}
