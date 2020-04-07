﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1DDA.Dominio
{
    class PalabraPositiva:Palabra
    {
        public PalabraPositiva(string sentencia)
        {
            this.Sentencia = sentencia;
            this.Estado = Estado.POSITIVO;
        }

        override
            public string ToString()
        {
            return this.Sentencia;
        }
    }
}
