using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Configuration;

namespace PuntoDeVenta.Persistence.Entities
{
    [EntityTypeConfiguration(typeof(ClientPhoneNumberConfiguration))]
    public class ClientPhoneNumber
    {
        public ClientPhoneNumber() { }

        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }

        public Client Client { get; set; }
    }
}
