using Aplicacion.Modelo;
using Aplicacion.Vista;
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
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IVistaPrincipal vistaPrincipal = new VistaPrincipal();
            PresentadorPrincipal presentadorPrincipal = new PresentadorPrincipal(vistaPrincipal, new MockPartidaRepository());
            Application.Run((Form) vistaPrincipal);
        }
    }
}
