using Aplicacion.Dtos;
using Aplicacion.Servicios;
using Aplicacion.Vista;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentador
{
    public class PresentadorPrincipal
    {
        private readonly IVistaPrincipal _vistaPrincipal;
        private readonly IPersonaRepository _personasRepository;
        private BindingSource _bindingSource;
        private IServicioDataRandom _servicioDataRandom;

        public PresentadorPrincipal(
            IVistaPrincipal vistaPrincipal,
            IPersonaRepository partidaRepository,
            IServicioDataRandom servicioDataRandom)
        {
            _vistaPrincipal = vistaPrincipal;
            _personasRepository = partidaRepository;
            _bindingSource = new BindingSource();
            _vistaPrincipal.ClickeoMostrarPersonas += MostrarPersonas;
            _vistaPrincipal.ClickeoMostrarPersonaRandom += MostrarPersonaRandom;
            _servicioDataRandom = servicioDataRandom;
        }

        private void MostrarPersonas(object? sender, EventArgs e)
        {
            _bindingSource.DataSource = _personasRepository.GetAll()
                                        .Select(p => new PersonaLectura { Id = p.Id, Nombre = p.Nombre });
            _vistaPrincipal.ActualizarBindingSource(_bindingSource);
        }

        private void MostrarPersonaRandom(object? sender, EventArgs e)
        {
            var persona = _servicioDataRandom.ObtenerPersonaRandom();
            _vistaPrincipal.MostrarPersonaRandom(new PersonaLectura { Id = persona.Id, Nombre = persona.Nombre });
        }
    }
}
