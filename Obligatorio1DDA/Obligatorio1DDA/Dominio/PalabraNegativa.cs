using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1DDA.Dominio
{
    class PalabraNegativa
    {
        public string Sentencia { get; set; }
        public Estado Estado { get; set; }


        public PalabraNegativa(string sentencia)
        {
            this.Sentencia = sentencia;
            this.Estado = Estado.NEGATIVO;
        }

        override
            public string ToString()
        {
            return this.Sentencia;
        }
    }
}
