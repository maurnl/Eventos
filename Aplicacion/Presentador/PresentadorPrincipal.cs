using Aplicacion.Dtos;
using Aplicacion.Servicios;
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
        private IServicioDataRandom _servicioDataRandom;

        public PresentadorPrincipal(
            IVistaPrincipal vistaPrincipal,
            IPersonaRepository partidaRepository,
            IServicioDataRandom servicioDataRandom)
        {
            _vistaPrincipal = vistaPrincipal;
            _partidaRepository = partidaRepository;
            _bindingSource = new BindingSource();
            _vistaPrincipal.ClickeoMostrarPersonas += MostrarPersonasHandler;
            _vistaPrincipal.ClickeoMostrarPersonaRandom += MostrarPersonaRandom;
            _servicioDataRandom = servicioDataRandom;
        }

        private void MostrarPersonasHandler(object? sender, EventArgs e)
        {
            _bindingSource.DataSource = _partidaRepository.GetAll().Select(p => new PersonaLectura { Id = p.Id, Nombre = p.Nombre });
            _vistaPrincipal.ActualizarBindingSource(_bindingSource);
        }

        private void MostrarPersonaRandom(object? sender, EventArgs e)
        {
            var persona = _servicioDataRandom.ObtenerPersonaRandom();
            _vistaPrincipal.MostrarPersonaRandom(new PersonaLectura { Id = persona.Id, Nombre = persona.Nombre });
        }
    }
}
