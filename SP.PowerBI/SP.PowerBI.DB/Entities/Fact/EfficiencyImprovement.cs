using SP.PowerBI.DB.Entities.Dimension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Entities.Fact
{
    public class EfficiencyImprovement : DBBasic
    {
        [ColumnName("Save Test hours per test pass")]
        public float ESavedTestHours { set; get; } = 0;

        [ColumnName("Extra work doing")]
        public float EExtraWorkHours { set; get; } = 0;

        public Team ETeamInfo { set; get; }
    }
}
