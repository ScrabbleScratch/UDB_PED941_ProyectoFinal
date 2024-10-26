namespace PuntoDeVenta.Interfaces.Services
{
    public interface IAuthService
    {
        Guid? Login(string username, string password);
    }
}
