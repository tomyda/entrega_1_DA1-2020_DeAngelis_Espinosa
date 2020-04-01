using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1DDA.Dominio
{
    class Frase
    {
        public string Oracion { get; set; }
        public Estado Estado { get; set; }


        public Frase(string oracion)
        {
            this.Oracion = oracion;
            this.Estado = Estado.NO_DEFINIDO;
        }

        override
            public string ToString()
        {
            return this.Oracion;
        }
    }
}
