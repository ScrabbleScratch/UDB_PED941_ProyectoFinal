using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PuntoDeVenta.Interfaces.Services;
using PuntoDeVenta.Persistence;
using PuntoDeVenta.Persistence.Seeders;
using PuntoDeVenta.Services;

namespace PuntoDeVenta
{
    internal static class Program
    {
        public static IServiceProvider serviceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Inject dependencies
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            serviceProvider = serviceCollection.BuildServiceProvider();

            Application.Run(serviceProvider.GetRequiredService<MainForm>());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Register db context here
            services.AddDbContext<ApplicationDbContext>();

            // Register services here
            services.AddScoped<IHashService, HashService>();
            services.AddScoped<IApplicationSeeder, ApplicationSeeder>();
            // Register forms here
            services.AddTransient<MainForm>();
        }
    }
}