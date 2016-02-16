using System.Data.Entity;
using Common.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAccess.SqlServer.Core
{
    public class PeriodicalsDBContext : IdentityDbContext<User>
    {
        public PeriodicalsDBContext()
            : base("PeriodicalsConnection")
        {
            Database.SetInitializer(new PeriodicalsDBInitializer());
        }

        public DbSet<Periodical> Periodicals { get; set; }

        public DbSet<Subscription> Subscriptions { get; set; }
        
        public DbSet<Theme> Themes { get; set; }

        public DbSet<MoneyAccount> MoneyAccounts { get; set; }

        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
