using SP.PowerBI.DB.Entities.Dimension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Entities.Fact
{
    public class ResourceAllocation : DBBasic
    {
        [ColumnName("Tasks")]
        public string TaskName { set; get; } = string.Empty;

        [ColumnName("Person")]
        public int Person { set; get; } = 0;

        public Team ATeamInfo { set; get; }
    }
}
