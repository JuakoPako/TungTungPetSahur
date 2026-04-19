using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TungTungPetSahur.Models
{
    internal class Mascota
    {

        public String humor { get; set; }

        public int hambre { get; set; }

        public int sueno { get; set; }

        public int diversion { get; set; }


        public enum Edad
        {
            Bebe,
            Joven,
            Adulto
        }

        public Edad EdadActual { get; set; }


        public Mascota(string humor, int hambre, int sueno, int diversion, Edad edad)
        {
            this.humor = humor;
            this.hambre = hambre;
            this.sueno = sueno;
            this.diversion = diversion;
            this.EdadActual = edad;
        }


        public void alimentar()
        {
            hambre = Limitar(hambre + 15);
        }

        public void descansar()
        {
            sueno = Limitar(sueno + 1);

            diversion = Limitar(diversion-1);
        }

        public void jugar()
        {
            diversion = Limitar(diversion + 10);
            hambre = Limitar(hambre - 5);
        }


        public void descensoNecesidades()
        {
            sueno = Limitar(sueno - 1);
            diversion = Limitar(diversion - 1);
            hambre = Limitar(hambre - 1);
        }

        private int Limitar(int valor)
        {
            return Math.Max(0, Math.Min(100, valor));
        }

    }


        
}
