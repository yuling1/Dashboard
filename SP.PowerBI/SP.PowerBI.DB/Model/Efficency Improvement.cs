using SP.PowerBI.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Model
{
    public class Efficency_Improvement
    {
        [ColumnName("Save Test hours per test pass")]
        public float ESavedTestHours { set; get; } = 0;

        [ColumnName("Extra work doing")]
        public float EExtraWorkHours { set; get; } = 0;

        public string TeamName { set; get; } = "SharePoint";
    }
}
