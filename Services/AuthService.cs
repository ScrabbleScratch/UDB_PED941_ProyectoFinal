using PuntoDeVenta.Interfaces.Repositories;
using PuntoDeVenta.Interfaces.Services;

namespace PuntoDeVenta.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IHashService _hashService;

        public AuthService(IUserRepository userRepository, IHashService hashService)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _hashService = hashService ?? throw new ArgumentNullException(nameof(hashService));
        }

        public Guid? Login(string username, string password)
        {
            var user = _userRepository.GetByUsername(username);
            if (user != null && _hashService.VerifyPassword(password, user.Password))
                return user.Id;
            else
                return null;
        }
    }
}
