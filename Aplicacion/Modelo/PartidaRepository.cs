using Aplicacion.Data;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Modelo
{
    public class PartidaRepository : IPersonaRepository
    {
        private readonly AppDbContext _context;

        public PartidaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ModeloPersona> GetAll()
        {
            return _context.Personas.ToList();
        }
    }
}
