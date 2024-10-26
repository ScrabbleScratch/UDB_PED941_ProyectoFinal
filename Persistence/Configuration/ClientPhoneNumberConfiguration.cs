using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Entities;

namespace PuntoDeVenta.Persistence.Configuration
{
    public class ClientPhoneNumberConfiguration : IEntityTypeConfiguration<ClientPhoneNumber>
    {
        public void Configure(EntityTypeBuilder<ClientPhoneNumber> builder)
        {
            builder.ToTable("ClientPhoneNumbers");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql("NEWID()");
            builder.Property(c => c.ClientId).IsRequired();
            builder.Property(c => c.CountryCode).IsRequired().HasMaxLength(3);
            builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(10);

            builder.HasOne(c => c.Client)
                .WithMany()
                .HasForeignKey(c => c.ClientId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
