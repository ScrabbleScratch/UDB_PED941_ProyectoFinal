using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Configuration;
using PuntoDeVenta.Primitives;

namespace PuntoDeVenta.Persistence.Entities
{
    [EntityTypeConfiguration(typeof(OrderConfiguration))]
    public class Order
    {
        public Order() { }

        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public OrderType OrderType{ get; set; }
        public OrderStatus Status { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid? PreparedBy { get; set; }
        public DateTime? PreparationDate { get; set; }
        public Guid? DispatchedBy { get; set; }
        public DateTime? DispatchDate { get; set; }

        public Client Client { get; set; }
        public User? CreatedByUser { get; set; }
        public User? PreparedByUser { get; set; }
        public User? DispatchedByUser { get; set; }
    }
}
