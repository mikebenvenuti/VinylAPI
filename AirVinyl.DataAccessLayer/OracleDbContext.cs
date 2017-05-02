using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirVinyl.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AirVinyl.DataAccessLayer
{
    public class OracleDbContext : DbContext
    {
        public DbSet<CONFIG> Config { get; set; }
        public DbSet<TICKET> Ticket { get; set; }

        public OracleDbContext()
        {
            //Database.SetInitializer(new    myDBInitializer());
            Configuration.LazyLoadingEnabled = true;
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MIKE");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
