using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Configuration;

namespace PuntoDeVenta.Persistence.Entities
{
    [EntityTypeConfiguration(typeof(ClientConfiguration))]
    public class Client
    {
        public Client() { }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool IsActive { get; set; }
    }
}
