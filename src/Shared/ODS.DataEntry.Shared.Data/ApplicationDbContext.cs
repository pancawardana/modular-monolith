using Microsoft.EntityFrameworkCore;
using ODS.DataEntry.Modules.WellMaster.Domain.WellMaster;
using ODS.DataEntry.Shared.Data.Configs;

namespace ODS.DataEntry.Shared.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<WellMasterEntity> WellMasterEntities { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new WellMasterConfig());
        }
    }
}
