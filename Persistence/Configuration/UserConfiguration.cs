using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Entities;

namespace PuntoDeVenta.Persistence.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(c => c.Id);
            builder.HasAlternateKey(c => c.Username);

            builder.Property(c => c.Id).IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql("NEWID()");
            builder.Property(c => c.EmployeeId).IsRequired();
            builder.Property(c => c.Username).IsRequired().HasMaxLength(10);
            builder.Property(c => c.Password).IsRequired();
            builder.Property(c => c.Role).IsRequired();
            builder.Property(c => c.IsActive).IsRequired().HasDefaultValue(true);

            builder.HasOne(c => c.Employee)
                .WithMany()
                .HasForeignKey(c => c.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
