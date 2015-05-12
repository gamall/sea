using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using System.Threading.Tasks;
using Sea.Core;
using System.Data;

namespace Sea.Data
{

    public class SeaDbContext : DbContext
    {
        static SeaDbContext()
        {
            //dont't do anything            
        }        

        public SeaDbContext() 
            : base(nameOrConnectionString: "SeaConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new OrganisationConfiguration());
            //modelBuilder.Configurations.Add(new UserConfiguration());

            //// Add ASP.NET WebPages SimpleSecurity tables
            //modelBuilder.Configurations.Add(new RoleConfiguration());
            //modelBuilder.Configurations.Add(new MembershipConfiguration());
            //modelBuilder.Configurations.Add(new OAuthMembershipConfiguration());

        }

        public DbSet<Vessel> Vessel { get; set; }
        public DbSet<VesselDocument> VesselDocument { get; set; }

    }
}
