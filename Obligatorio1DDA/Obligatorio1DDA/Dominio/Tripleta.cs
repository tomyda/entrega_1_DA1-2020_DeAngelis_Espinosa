using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1DDA.Dominio
{
    class Tripleta
    {
        public Frase Frase { get; set; }
        public Entidad Entidad{ get; set; }

        public Estado Estado { get; set; }

        public Tripleta(Frase frase, Entidad entidad)
        {
            this.Frase = frase;
            this.Entidad = entidad;
            this.Estado = frase.Estado;
        }

        override
            public string ToString()
        {
            return this.Frase + " | "+ this.Entidad + " | " + this.Estado;
        }
    }
}
