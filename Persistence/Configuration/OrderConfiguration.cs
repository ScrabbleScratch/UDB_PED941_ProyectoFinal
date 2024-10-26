using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Entities;

namespace PuntoDeVenta.Persistence.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql("NEWID()");
            builder.Property(c => c.ClientId).IsRequired();
            builder.Property(c => c.OrderType).IsRequired();
            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.CreatedBy).IsRequired();
            builder.Property(c => c.CreationDate).IsRequired();
            builder.Property(c => c.PreparedBy).IsRequired(false);
            builder.Property(c => c.PreparationDate).IsRequired(false);
            builder.Property(c => c.DispatchedBy).IsRequired(false);
            builder.Property(c => c.DispatchDate).IsRequired(false);

            builder.HasOne(c => c.Client)
                .WithMany()
                .HasForeignKey(c => c.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.CreatedByUser)
                .WithMany()
                .HasForeignKey(c => c.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.PreparedByUser)
                .WithMany()
                .HasForeignKey(c => c.PreparedBy)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.DispatchedByUser)
                .WithMany()
                .HasForeignKey(c => c.DispatchedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
