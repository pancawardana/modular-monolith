using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ODS.DataEntry.Modules.WellMaster.Domain.WellMaster;

namespace ODS.DataEntry.Shared.Data.Configs
{
    public class WellMasterConfig : BaseEntityConfig<WellMasterEntity>
    {
        public WellMasterConfig() : base()
        {

        }

        public override void Configure(EntityTypeBuilder<WellMasterEntity> builder)
        {
            base.Configure(builder);

            builder.ToTable("WellMaster", "WellMaster");
        }
    }
}
