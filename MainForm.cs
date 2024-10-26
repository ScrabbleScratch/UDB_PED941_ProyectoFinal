using PuntoDeVenta.Controls.MainMenu;
using PuntoDeVenta.Persistence.Seeders;

namespace PuntoDeVenta
{
    public partial class MainForm : Form
    {
        private readonly IApplicationSeeder _seeder;
        private readonly LoginControl _loginControl;
        private readonly MainMenuControl _mainMenuControl;

        public MainForm(IApplicationSeeder seeder, LoginControl loginControl, MainMenuControl mainMenuControl)
        {
            _seeder = seeder ?? throw new ArgumentNullException(nameof(seeder));
            _loginControl = loginControl ?? throw new ArgumentNullException(nameof(loginControl));
            _mainMenuControl = mainMenuControl ?? throw new ArgumentNullException(nameof(mainMenuControl));

            InitializeComponent();
            _seeder.SeedDatabase();

            // Add login control
            _loginControl.LoginSuccess += LoginControl_LoginSuccess;
            _loginControl.Size = this.Size;
            this.Controls.Add(_loginControl);
        }

        private void LoginControl_LoginSuccess(object? sender, EventArgs e)
        {
            this.Controls.Clear();
            _mainMenuControl.Size = this.Size;
            this.Controls.Add(_mainMenuControl);
        }
    }
}
