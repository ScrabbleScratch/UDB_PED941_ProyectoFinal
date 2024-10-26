using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Configuration;

namespace PuntoDeVenta.Persistence.Entities
{
    [EntityTypeConfiguration(typeof(ProductConfiguration))]
    public class Product
    {
        public Product(string name, double price, int categoryId, string? description = null)
        {
            Name = name;
            Description = description;
            Price = price;
            CategoryId = categoryId;
            IsAvailable = true;
        }

        public Product() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public bool IsAvailable { get; set; }

        public ProductCategory Category { get; set; }
    }
}
