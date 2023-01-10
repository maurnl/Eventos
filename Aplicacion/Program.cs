using Aplicacion.Modelo;
using Aplicacion.Vista;
using Microsoft.Extensions.DependencyInjection;
using Modelo;
using Presentador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    internal static class Program
    {
        private static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<PresentadorPrincipal>();
            services.AddSingleton<IVistaPrincipal, VistaPrincipal>();
            services.AddTransient<IPersonaRepository, MockPartidaRepository>();
            ServiceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            IVistaPrincipal vistaPrincipal = ServiceProvider.GetRequiredService<IVistaPrincipal>();
            ServiceProvider.GetRequiredService<PresentadorPrincipal>();
            Application.Run((Form) vistaPrincipal);
        }
    }
}
