using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1DDA.Dominio
{
    class PalabraNegativa:Palabra
    {

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
