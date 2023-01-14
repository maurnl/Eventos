using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicios
{
    public class ServicioDataRandom : IServicioDataRandom
    {
        private readonly string[] _nombres;

        public ServicioDataRandom()
        {
            _nombres = new string[]
            {
                "Testo",
                "Testonio",
                "Carlitos",
                "Antonio"
            };
        }

        public ModeloPersona ObtenerPersonaRandom()
        {
            var random = new Random();
            return new ModeloPersona
            {
                Id = random.Next(0, 200),
                Nombre = _nombres[random.Next(0, _nombres.Length)]
            };
        }
    }
}
