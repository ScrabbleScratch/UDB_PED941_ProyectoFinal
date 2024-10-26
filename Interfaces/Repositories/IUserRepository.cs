using PuntoDeVenta.Persistence.Entities;

namespace PuntoDeVenta.Interfaces.Repositories
{
    public interface IUserRepository
    {
        User? GetByUsername(string username);
    }
}
