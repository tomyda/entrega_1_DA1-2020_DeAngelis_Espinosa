using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1DDA.Dominio
{
    abstract class Palabra
    {
        public string Sentencia { get; set; }
        public Estado Estado { get; set; }

    }
}
