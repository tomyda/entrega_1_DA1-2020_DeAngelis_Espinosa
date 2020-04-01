using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1DDA.Dominio
{
    class Alarma
    {
        public int CantComentariosNegativos { get; set; }
        public int CantComentariosPositivos { get; set; }
        public int TiempoMaximo { get; set; } //No es int, pero por ahora le dejamos el int
        public string Motivo { get; set; }
        public Entidad Entidad { get; set; }
        public bool YaFueDesactivada { get; set; }
        public int ID { get; set; }


        public Alarma(int cantNegativos, int cantPositivos, int tiempoMaxEnDias, int tiempoMaximoEnMinutos, string descripcion, Entidad entidad, int ID)
        {
            this.CantComentariosPositivos = cantPositivos;
            this.CantComentariosNegativos = cantNegativos;
            this.TiempoMaximo = 0; //Hay que cambiarlo
            this.Motivo = descripcion;
            this.Entidad = entidad;
            this.YaFueDesactivada = false;
            this.ID = ID;
        }

        override
            public string ToString()
        {
            return ("Alarma: " + this.Motivo + "\nCantidad de comentarios: Negativos " + this.CantComentariosNegativos + "- Positivos " + this.CantComentariosPositivos + "\nTiempo Maximo: " + this.TiempoMaximo
                + "\nFue desactivada: " + this.YaFueDesactivada + "\nEntidad: " + this.Entidad + ", ID: " + this.ID);
        }
    }
}
