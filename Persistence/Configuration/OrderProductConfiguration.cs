using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Entities;

namespace PuntoDeVenta.Persistence.Configuration
{
    public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.ToTable("OrderProducts");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.OrderId).IsRequired();
            builder.Property(c => c.ProductId).IsRequired();
            builder.Property(c => c.Quantity).IsRequired();
            builder.Property(c => c.Comments).IsRequired(false);

            builder.HasOne(c => c.Order)
                .WithMany()
                .HasForeignKey(c => c.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Product)
                .WithMany()
                .HasForeignKey(c => c.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
