using SP.PowerBI.DB.Entities.Dimension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.Entities.Fact
{
    public class ResourceChanges : DBBasic
    {
        public MSTitle Title { set; get; }

        public SkillSet Skillset { set; get; }

        public Resource ResourceInfo { set; get; }

        public ResourceAdditionalInfo ResoureAdditionalInfo { set; get; }

        public Team RTeamInfo { set; get; }
    }
}
