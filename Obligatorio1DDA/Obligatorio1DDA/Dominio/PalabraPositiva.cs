using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1DDA.Dominio
{
    class PalabraPositiva
    {
        public string Sentencia { get; set; }
        public Estado Estado { get; set; }

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
