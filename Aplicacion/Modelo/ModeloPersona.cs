﻿using Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloPersona : EntidadBase
    {
        public string Nombre { get; set; }
        public bool EsClienteVip { get; set; }
    }
}
