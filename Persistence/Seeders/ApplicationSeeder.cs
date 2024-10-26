using PuntoDeVenta.Interfaces.Services;
using PuntoDeVenta.Persistence.Entities;
using PuntoDeVenta.Primitives;

namespace PuntoDeVenta.Persistence.Seeders
{
    public class ApplicationSeeder : IApplicationSeeder
    {
        private readonly ApplicationDbContext _context;
        private readonly IHashService _hashService;

        public ApplicationSeeder(ApplicationDbContext context, IHashService hashService)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _hashService = hashService ?? throw new ArgumentNullException(nameof(hashService));
        }

        public void SeedDatabase()
        {
            SeedEmployees();
            SeedUsers();
            SeedProductCategories();
            SeedProducts();
            SeedTables();
        }

        private void SeedEmployees()
        {
            if (_context.Employees.Any()) return;

            _context.Employees.AddRange(
                new Employee("Admin", "Admin", DateTime.Now, DateTime.Now)
            );
            _context.SaveChanges();
        }

        private void SeedUsers()
        {
            if (_context.Users.Any()) return;

            var adminEmployee = _context.Employees.FirstOrDefault(e => e.FirstName == "Admin");
            if (adminEmployee == null) return;

            _context.Users.AddRange(
                new User(adminEmployee.Id, "admin", _hashService.HashPassword("admin"), UserRole.Admin)
            );
            _context.SaveChanges();
        }

        private void SeedProductCategories()
        {
            if (_context.ProductCategories.Any()) return;

            _context.ProductCategories.AddRange(
                new ProductCategory("Comida"),
                new ProductCategory("Bebidas"),
                new ProductCategory("Postres"),
                new ProductCategory("Otros")
            );

            _context.SaveChanges();
        }

        private void SeedProducts()
        {
            if (!_context.ProductCategories.Any() || _context.Products.Any()) return;

            var foodCategory = _context.ProductCategories.FirstOrDefault(pc => pc.Name == "Comida");
            if (foodCategory != null)
            {
                _context.Products.AddRange(
                    new Product("Pupusa de Queso", 15, foodCategory.Id),
                    new Product("Pupusa de Firjol y Queso", 15, foodCategory.Id),
                    new Product("Pupusa de Chicharron y Queso", 15, foodCategory.Id),
                    new Product("Pupusa Revuelta", 15, foodCategory.Id)
                );
            }

            var drinksCategory = _context.ProductCategories.FirstOrDefault(pc => pc.Name == "Bebidas");
            if (drinksCategory != null)
            {
                _context.Products.AddRange(
                    new Product("Horchata", 12, drinksCategory.Id),
                    new Product("Kolashanpan", 10, drinksCategory.Id),
                    new Product("Gaseosa", 6, drinksCategory.Id),
                    new Product("Chocolate", 8, drinksCategory.Id),
                    new Product("Café", 8, drinksCategory.Id)
                );
            }

            _context.SaveChanges();
        }

        private void SeedTables()
        {
            if (_context.Tables.Any()) return;

            _context.Tables.AddRange(
                new Table(1, 2),
                new Table(2, 2),
                new Table(3, 2),
                new Table(4, 4),
                new Table(5, 4)
            );

            _context.SaveChanges();
        }
    }
}
