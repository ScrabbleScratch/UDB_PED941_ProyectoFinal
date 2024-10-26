using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PuntoDeVenta.Persistence.Entities;

namespace PuntoDeVenta.Persistence.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql("NEWID()");
            builder.Property(c => c.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(c => c.LastName).IsRequired().HasMaxLength(30);
            builder.Property(c => c.DateOfBirth).IsRequired(false);
            builder.Property(c => c.IsActive).IsRequired().HasDefaultValue(true);
        }
    }
}
