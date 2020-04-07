using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1DDA.Dominio
{
    class Sistema
    {
        private List<PalabraPositiva> ListaPalabrasPositivas;
        private List<PalabraNegativa> ListaPalabrasNegativas;
        private List<Tripleta> ListaAnalisis;
        private List<Alarma> ListaAlarmas;
        private List<Frase> ListaFrases;
        private List<Entidad> ListaDeEntidades;
        private List<Tripleta> ListaTripletas;




        public Sistema()
        {
            this.ListaPalabrasPositivas = new List<PalabraPositiva>();
            this.ListaPalabrasNegativas = new List<PalabraNegativa>();
            this.ListaAnalisis = new List<Tripleta>();
            this.ListaAlarmas = new List<Alarma>();
            this.ListaFrases = new List<Frase>();
            this.ListaDeEntidades = new List<Entidad>();
            this.ListaTripletas = new List<Tripleta>();


            PalabraPositiva p1 = new PalabraPositiva("cool");
            PalabraPositiva p2 = new PalabraPositiva("lindo");

            PalabraNegativa p3 = new PalabraNegativa("feo");
            PalabraNegativa p4 = new PalabraNegativa("horrible");

            Frase f1 = new Frase("El control Apple es muy nose");
            Frase f2 = new Frase("Samsung es horrible");


            Entidad e1 = new Entidad(0, "Apple");
            Entidad e2 = new Entidad(1, "Samsung");

            this.ListaPalabrasPositivas.Add(p1);
            this.ListaPalabrasPositivas.Add(p2);
            this.ListaPalabrasNegativas.Add(p3);
            this.ListaPalabrasNegativas.Add(p4);
            this.ListaFrases.Add(f1);
            this.ListaFrases.Add(f2);
            this.ListaDeEntidades.Add(e1);
            this.ListaDeEntidades.Add(e2);


            AnalizarFrase(f1);
            Console.WriteLine(this.ListaTripletas[0]);
        }

        private void AnalizarFrase(Frase frase)
        {
            if (TienePalabrasPositivas(frase))
            {
                Entidad e = BuscarEntidadEnFrase(frase);
                if (e == null) return; //ERROR: Se encontro la opinion pero no la entidad
                frase.Estado = Estado.POSITIVO;
                Tripleta tri = new Tripleta(frase, e);
                this.ListaTripletas.Add(tri);
                return;
            }
            if (TienePalabrasNegativas(frase))
            {
                Entidad e = BuscarEntidadEnFrase(frase);
                if (e == null) return; //ERROR: Se encontro la opinion pero no la entidad
                frase.Estado = Estado.NEGATIVO;
                Tripleta tri = new Tripleta(frase, e);
                this.ListaTripletas.Add(tri);
                return;
            }
            Entidad ent = BuscarEntidadEnFrase(frase);
            if (ent == null) return; //ERROR: Se encontro la opinion pero no la entidad
            frase.Estado = Estado.NEUTRO;
            Tripleta trip = new Tripleta(frase, ent);
            this.ListaTripletas.Add(trip);
            return;
        }

        private bool TienePalabrasNegativas(Frase frase)
        {
            for (int i = 0; i < this.ListaPalabrasPositivas.Count; i++)
            {
                PalabraPositiva palabraPositiva = this.ListaPalabrasPositivas[i];
                if (estaLaPalabraEnLaFrase(palabraPositiva.Sentencia, frase.Oracion))
                {
                    return true;
                }
            }
            return false;
        }

        private bool TienePalabrasPositivas(Frase frase)
        {
            for (int i = 0; i < this.ListaPalabrasPositivas.Count; i++)
            {
                PalabraPositiva palabraPositiva = this.ListaPalabrasPositivas[i];
                if (estaLaPalabraEnLaFrase(palabraPositiva.Sentencia, frase.Oracion))
                {
                    return true;
                }
            }
            return false;
        }

        private Entidad BuscarEntidadEnFrase(Frase frase)
        {
            for (int j = 0; j < this.ListaDeEntidades.Capacity; j++)
            {
                Entidad entidadActual = this.ListaDeEntidades[j];
                if (estaLaPalabraEnLaFrase(entidadActual.Nombre, frase.Oracion))
                {
                    return entidadActual;
                }
            }
            return null;
        }

        private bool estaLaPalabraEnLaFrase(string palabra, string frase)
        {
            if (frase.Contains(palabra)) return true;
            return false;
        }
    }
}
