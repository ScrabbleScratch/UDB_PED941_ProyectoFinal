using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Entities;
using PuntoDeVenta.Primitives;

namespace PuntoDeVenta.Persistence.Configuration
{
    public class TableReservationConfiguration : IEntityTypeConfiguration<TableReservation>
    {
        public void Configure(EntityTypeBuilder<TableReservation> builder)
        {
            builder.ToTable("TableReservations");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql("NEWID()");
            builder.Property(c => c.ClientId).IsRequired();
            builder.Property(c => c.Seats).IsRequired();
            builder.Property(c => c.ReservationStartDate).IsRequired();
            builder.Property(c => c.ReservationEndDate).IsRequired();
            builder.Property(c => c.Status).IsRequired().HasDefaultValue(ReservationStatus.Pending);

            builder.HasOne(c => c.Client)
                .WithMany()
                .HasForeignKey(c => c.ClientId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
