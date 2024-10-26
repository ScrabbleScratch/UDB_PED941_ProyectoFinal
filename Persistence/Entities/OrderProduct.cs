using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Configuration;

namespace PuntoDeVenta.Persistence.Entities
{
    [EntityTypeConfiguration(typeof(OrderProductConfiguration))]
    public class OrderProduct
    {
        public OrderProduct() { }

        public int Id { get; set; }
        public Guid OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string? Comments { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
