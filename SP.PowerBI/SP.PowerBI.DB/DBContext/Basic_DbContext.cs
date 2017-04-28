using SP.PowerBI.DB.Entities.Dimension;
using SP.PowerBI.DB.Entities.Fact;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI.DB.DBContext
{
    public class Basic_DbContext : DbContext
    {
        public Basic_DbContext() : base("name=EFConnection")
        {
            Database.SetInitializer<Basic_DbContext>(new Basic_DbContextInitializer());
        }

        public DbSet<Bug> Bug { set; get; }
        public DbSet<BugAdditionalInfo> BugAdditionalInfo { set; get; }
        public DbSet<MSTitle> MSTitle { set; get; }
        public DbSet<NewFeature> NewFeature { set; get; }
        public DbSet<Resource> Resource { get; set; }
        public DbSet<ResourceAdditionalInfo> ResourceAdditionalInfo { get; set; }
        public DbSet<SkillSet> SkillSet { set; get; }
        public DbSet<Team> Team { set; get; }
        public DbSet<BugChanges> BugChanges { set; get; }
        public DbSet<Communication> Communication { get; set; }
        public DbSet<EfficiencyImprovement> EfficiencyImprovement { get; set; }
        public DbSet<HandoffTesting> HandoffTesting { get; set; }
        public DbSet<NewFeatureChanges> NewFeatureChanges { set; get; }
        public DbSet<ResourceChanges> ResourceChanges { get; set; }
        public DbSet<ResourceAllocation> ResourceAllocation { get; set; }

        public class Basic_DbContextInitializer : CreateDatabaseIfNotExists<Basic_DbContext>
        {
            protected override void Seed(Basic_DbContext context)
            {
                context.Resource.AddRange(new List<Resource>
                {
                    //new Resource { Name ="Bin Yan", Alias = "v-yanb", OnboardDate = DateTime.Now.Date},
                    //new Resource { Name ="Yuling Jiao", Alias = "v-yuljia", OnboardDate = DateTime.Now.Date}
                });
                base.Seed(context);
            }
        }
    }
}
