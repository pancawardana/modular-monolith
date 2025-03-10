using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ODS.DataEntry.Shared.Data
{
    public abstract class BaseEntityConfig<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        private readonly string? _tableName;
        private readonly string? _schemaName;

        public BaseEntityConfig()
        {

        }

        public BaseEntityConfig(string tableName)
        {
            _tableName = tableName;
        }

        public BaseEntityConfig(string schemaName, string tableName)
        {
            _schemaName = schemaName;
            _tableName = tableName;
        }

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            if (!string.IsNullOrEmpty(_tableName))
                builder.Metadata.SetTableName(_tableName);

            if (!string.IsNullOrEmpty(_schemaName))
                builder.Metadata.SetSchema(_schemaName);

            builder.Property(e => e.ConcurrencyStamp)
                .IsConcurrencyToken()
                .HasDefaultValueSql("UPPER(CONVERT(NVARCHAR(MAX), NEWID()))");
            builder.Property(e => e.CreatedDate)
                .HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Local))
                .HasDefaultValueSql("GETDATE()");
            builder.Property(e => e.UpdatedDate).HasConversion(v => v, v => v != null ? DateTime.SpecifyKind(v.Value, DateTimeKind.Local) : null);
        }
    }
}
