using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Entities.Dimension
{
    public class Team : DBBasic
    {
        [EqualKey]
        public string TeamName { set; get; } = "SharePoint";
    }
}
