using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicios
{
    public class ServicioDataMock : IServicioDataMock
    {
        private readonly string[] _nombres;

        public ServicioDataMock()
        {
            _nombres = new string[]
            {
                "Testo",
                "Testonio",
                "Carlitos",
                "Antonio"
            };
        }

        public ModeloPersona ObtenerPersonaMock()
        {
            var random = new Random();
            return new ModeloPersona
            {
                Id = random.Next(0, 200),
                Name = _nombres[random.Next(0, _nombres.Length)]
            };
        }
    }
}
