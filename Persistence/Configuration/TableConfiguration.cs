using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Entities;

namespace PuntoDeVenta.Persistence.Configuration
{
    public class TableConfiguration : IEntityTypeConfiguration<Table>
    {
        public void Configure(EntityTypeBuilder<Table> builder)
        {
            builder.ToTable("Tables");
            builder.HasKey(c => c.Id);
            builder.HasAlternateKey(c => c.Number);

            builder.Property(c => c.Number).IsRequired();
            builder.Property(c => c.Description).IsRequired(false).HasMaxLength(150);
            builder.Property(c => c.Seats).IsRequired();
            builder.Property(c => c.IsAvailable).IsRequired().HasDefaultValue(true);
        }
    }
}
