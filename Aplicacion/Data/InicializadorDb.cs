using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Data
{
    public static class InicializadorDb
    {
        public static void PopularDb(IServiceProvider provider)
        {
            using (var scope = provider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                context.Database.Migrate();
                GenerarDataPersonas(context);
            }
        }

        private static void GenerarDataPersonas(AppDbContext context)
        {
            if(!context.Personas.Any())
            {
                context.Personas.AddRange(new List<ModeloPersona>
                {
                    new ModeloPersona
                    {
                        Nombre = "Carlos",
                        EsClienteVip = true
                    },
                    new ModeloPersona
                    {
                        Nombre = "Alberto",
                        EsClienteVip = true
                    },
                    new ModeloPersona
                    {
                        Nombre = "Lionel",
                        EsClienteVip = true
                    }
                });
                context.SaveChanges();
            }
        }
    }
}