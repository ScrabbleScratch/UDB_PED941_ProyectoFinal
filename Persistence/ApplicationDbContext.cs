using Microsoft.EntityFrameworkCore;
using PuntoDeVenta.Persistence.Entities;

namespace PuntoDeVenta.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string connectionString = "Server=localhost;Database=PuntoDeVenta;User Id=SA;Password=YourStrong@Passw0rd;TrustServerCertificate=True;";

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public ApplicationDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(connectionString);
            }
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientAddress> ClientAddresses { get; set; }
        public DbSet<ClientPhoneNumber> ClientPhoneNumbers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<TableReservation> TableReservations { get; set; }
    }
}
