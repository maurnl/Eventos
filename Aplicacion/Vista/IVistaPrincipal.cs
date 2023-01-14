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
        void ActualizarBindingSource(BindingSource bindingSource);
        void MostrarPersonaRandom(PersonaLectura persona);

        event EventHandler ClickeoMostrarPersonas;
        event EventHandler ClickeoMostrarPersonaRandom;
    }
}
