using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Configuration;
using PuntoDeVenta.Primitives;

namespace PuntoDeVenta.Persistence.Entities
{
    [EntityTypeConfiguration(typeof(TableReservationConfiguration))]
    public class TableReservation
    {
        public TableReservation() { }

        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public int Seats { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime ReservationEndDate { get; set; }
        public ReservationStatus Status { get; set; }

        public Client Client { get; set; }
    }
}
