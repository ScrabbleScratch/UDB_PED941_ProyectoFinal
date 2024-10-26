using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Configuration;
using PuntoDeVenta.Primitives;

namespace PuntoDeVenta.Persistence.Entities
{
    [EntityTypeConfiguration(typeof(UserConfiguration))]
    public class User
    {
        public User(Guid employeeId, string username, string password, UserRole role)
        {
            EmployeeId = employeeId;
            Username = username;
            Password = password;
            Role = role;
            IsActive = true;
        }

        public User() { }

        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public bool IsActive { get; set; }

        public Employee Employee { get; set; }
    }
}
