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
        public List<ModeloPersona> GetAll()
        {
            return new List<ModeloPersona>
            {
                new ModeloPersona
                {
                    Id = 1,
                    Name = "Testo"
                },
                new ModeloPersona
                {
                    Id = 2,
                    Name = "Testonio"
                }
            };
        }
    }
}
