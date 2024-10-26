using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Entities;

namespace PuntoDeVenta.Persistence.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql("NEWID()");
            builder.Property(c => c.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(c => c.LastName).IsRequired().HasMaxLength(30);
            builder.Property(c => c.DateOfBirth).IsRequired();
            builder.Property(c => c.DateOfJoining).IsRequired();
            builder.Property(c => c.DateOfLeaving).IsRequired(false);
            builder.Property(c => c.IsActive).IsRequired().HasDefaultValue(true);
        }
    }
}
