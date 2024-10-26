using PuntoDeVenta.Interfaces.Services;

namespace PuntoDeVenta
{
    public partial class LoginControl : UserControl
    {
        public EventHandler onLoginSuccess;

        private readonly IAuthService _authService;

        public LoginControl(IAuthService authService)
        {
            _authService = authService ?? throw new ArgumentNullException(nameof(authService));

            InitializeComponent();
        }

        // Define on login success event
        public event EventHandler LoginSuccess
        {
            add
            {
                onLoginSuccess += value;
            }
            remove
            {
                onLoginSuccess -= value;
            }
        }

        private void ValidateLogin()
        {
            errorProvider.Clear();

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate fields
            if (string.IsNullOrEmpty(username))
            {
                errorProvider.SetError(lblUsername, "Usuario no puede estar vacío!");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                errorProvider.SetError(lblPassword, "Contraseña no puede estar vacía!");
                return;
            }

            // Auth with credentials
            var auth = _authService.Login(username, password);
            if (auth != null)
            {
                txtUsername.Clear();
                txtPassword.Clear();

                onLoginSuccess?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                errorProvider.SetError(btnLogin, "Credenciales inválidas!");
                return;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidateLogin();
        }

        private void inputKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) ValidateLogin();
        }
    }
}
