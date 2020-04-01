using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1DDA.Dominio
{
    class Entidad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public Entidad(int id, string nombre)
        {
            this.ID = id;
            this.Nombre = nombre;
        }

        override
            public string ToString()
            {
            return this.Nombre;
            }
    }
}
