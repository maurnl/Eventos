using Aplicacion.Dtos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion.Vista
{
    public interface IVistaPrincipal
    {
        void ActualizarListaPersonas(IEnumerable<PersonaLecturaDto> personas);
        void MostrarPersonaRandom(PersonaLecturaDto persona);

        event EventHandler ClickeoMostrarPersonas;
        event EventHandler ClickeoMostrarPersonaRandom;
    }
}
