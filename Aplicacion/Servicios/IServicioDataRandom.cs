using Aplicacion.Dtos;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicios
{
    public interface IServicioDataRandom
    {
        ModeloPersona ObtenerPersonaRandom();
    }
}
