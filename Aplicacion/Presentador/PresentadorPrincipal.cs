using Aplicacion.Vista;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentador
{
    public class PresentadorPrincipal
    {
        private readonly IVistaPrincipal _vistaPrincipal;
        private readonly IPersonaRepository _partidaRepository;
        private BindingSource _bindingSource;

        public PresentadorPrincipal(IVistaPrincipal vistaPrincipal, IPersonaRepository partidaRepository)
        {
            _vistaPrincipal = vistaPrincipal;
            _partidaRepository = partidaRepository;
            _bindingSource = new BindingSource();
            _vistaPrincipal.ClickeoMostrarPersonas += MostrarPersonasHandler;
        }

        private void MostrarPersonasHandler(object? sender, EventArgs e)
        {
            _bindingSource.DataSource = _partidaRepository.GetAll();
            _vistaPrincipal.ActualizarBindingSource(_bindingSource);
        }
    }
}
