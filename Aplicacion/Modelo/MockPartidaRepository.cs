using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Modelo
{
    public class MockPartidaRepository : IPersonaRepository
    {
        public IEnumerable<ModeloPersona> GetAll()
        {
            return new List<ModeloPersona>
            {
                new ModeloPersona
                {
                    Id = 1,
                    Nombre = "Testo"
                },
                new ModeloPersona
                {
                    Id = 2,
                    Nombre = "Testonio"
                }
            };
        }
    }
}
