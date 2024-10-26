using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Configuration;

namespace PuntoDeVenta.Persistence.Entities
{
    [EntityTypeConfiguration(typeof(EmployeeConfiguration))]
    public class Employee
    {
        public Employee(string firstName, string lastName, DateTime dateOfbirth, DateTime dateOfJoining)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfbirth;
            DateOfJoining = dateOfJoining;
            IsActive = true;
        }

        public Employee() { }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime? DateOfLeaving { get; set; }
        public bool IsActive { get; set; }
    }
}
