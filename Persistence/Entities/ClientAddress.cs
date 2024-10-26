using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Configuration;

namespace PuntoDeVenta.Persistence.Entities
{
    [EntityTypeConfiguration(typeof(ClientAddressConfiguration))]
    public class ClientAddress
    {
        public ClientAddress() { }

        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string? ZipCode { get; set; }

        public Client Client { get; set; }
    }
}
