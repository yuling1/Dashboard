using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Entities.Dimension
{
    public class MSTitle : DBBasic
    {
        [EqualKey]
        public string MicroTitle { get; set; } = string.Empty;
        public double Rate { get; set; } = -1;
        public int BillingYear { get; set; } = DateTime.Now.Year;
    }
}
