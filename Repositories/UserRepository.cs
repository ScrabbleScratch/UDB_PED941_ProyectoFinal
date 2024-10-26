using PuntoDeVenta.Interfaces.Repositories;
using PuntoDeVenta.Persistence;
using PuntoDeVenta.Persistence.Entities;

namespace PuntoDeVenta.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public User? GetByUsername(string username) => _context.Users.FirstOrDefault(u => u.Username == username);
    }
}
