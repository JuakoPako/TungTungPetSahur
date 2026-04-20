using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TungTungPetSahur.Models
{

    public enum TipoMascota

    {
        TungTung, Capuccina, Tralalero
    }


    public class Mascota
    {

        public TipoMascota Tipo { get; set; }

        public String humor { get; set; }

        public int hambre { get; set; }

        public int sueno { get; set; }

        public int diversion { get; set; }


        public enum Edad
        {
            Bebe,
            Adulto,
            Viejo
            
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

            int danoBase = 3;
            int multiplicador = 1;
            
            if (this.EdadActual == Edad.Adulto)
            {
                multiplicador = 2;
            }

            else if (this.EdadActual == Edad.Viejo)
            {
                multiplicador = 3;
            }

            this.hambre = Math.Max(0, this.hambre - (danoBase * multiplicador));
            this.diversion = Math.Max(0, this.diversion - (danoBase * multiplicador));
            this.sueno = Math.Max(0, this.sueno - (danoBase * multiplicador));

        }

        private int Limitar(int valor)
        {
            return Math.Max(0, Math.Min(100, valor));
        }

    }


        
}
