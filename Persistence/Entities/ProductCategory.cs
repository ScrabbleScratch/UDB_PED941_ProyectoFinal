using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Configuration;

namespace PuntoDeVenta.Persistence.Entities
{
    [EntityTypeConfiguration(typeof(ProductCategoryConfiguration))]
    public class ProductCategory
    {
        public ProductCategory(string name, string? description = null)
        {
            Name = name;
            Description = description;
            IsAvailable = true;
        }

        public ProductCategory() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsAvailable { get; set; }
    }
}
