﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadTécnico : EntidadPersona
    {
        public int IdTecnico { get; set; }
        public string Contraseña { get; set; }
    }
}
