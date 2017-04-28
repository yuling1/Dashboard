using SP.PowerBI.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Model
{
    public class ResourceAllocation 
    {
        [ColumnName("Tasks")]
        public string TaskName { set; get; } = string.Empty;

        [ColumnName("Person")]
        public int Person { set; get; } = 0;

        public string TeamName { set; get; } = "SharePoint";
    }
}
