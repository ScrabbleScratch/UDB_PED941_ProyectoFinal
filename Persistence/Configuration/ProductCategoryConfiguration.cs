using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Entities;

namespace PuntoDeVenta.Persistence.Configuration
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategories");
            builder.HasKey(c => c.Id);
            builder.HasAlternateKey(c => c.Name);

            builder.Property(c => c.Name).IsRequired().HasMaxLength(25);
            builder.Property(c => c.Description).IsRequired(false).HasMaxLength(150);
            builder.Property(c => c.IsAvailable).IsRequired().HasDefaultValue(true);
        }
    }
}
