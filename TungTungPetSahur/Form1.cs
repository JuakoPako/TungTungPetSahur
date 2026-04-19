using System;
using System.Windows.Forms;
using TungTungPetSahur.Models;
using static TungTungPetSahur.Models.Mascota;
using System.Timers;

namespace TungTungPetSahur
{
    public partial class Form1 : Form
    {

        Mascota oMascota = new Mascota("Feliz", 50, 50, 50, Edad.Bebe);

        bool estaDurmiendo = false;

        public Form1()
        {
            InitializeComponent();
            Descenso();
            actualizarBarras();
            ActualizarTodo();

        }



        private static System.Timers.Timer timer;


        private void Descenso()
        {
            timer = new System.Timers.Timer(10000);
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            oMascota.descensoNecesidades();

            this.Invoke((MethodInvoker)delegate {
                actualizarBarras();
                Humor(); // si aplicaste la mejora
            });
        }





        private void Humor()
        {
            if ((oMascota.sueno + oMascota.hambre + oMascota.diversion) / 3 >= 70)
            {
                oMascota.humor = "Feliz";
            }

            else if ((oMascota.sueno + oMascota.hambre + oMascota.diversion) / 3 >= 30)
            {
                oMascota.humor = "Enfadado";
            }

            else
            {
                oMascota.humor = "Triste";
            }

        }


        private void ActualizarTodo()
        {
            actualizarBarras();
            ActualizarEstadoVisual();
        }


        private void ActualizarEstadoVisual()
        {
            
            switch (oMascota.humor)
            {
                case "Feliz":
                    pictureBox1.Image = TungTungPetSahur.Properties.Resources.tungtungsahurpieza;
                    break;

                case "Enfadado":
                    pictureBox1.Image = TungTungPetSahur.Properties.Resources.tungtungsahurpiezaenojado;
                    break;

                case "Triste":
                    pictureBox1.Image = TungTungPetSahur.Properties.Resources.tungtungsahurpiezatriste;
                    break;
            }
        }





        private void actualizarBarras()
        {
            pgrComida.Value = Math.Max(0, Math.Min(100, oMascota.hambre));
            pgrEnergia.Value = Math.Max(0, Math.Min(100, oMascota.sueno));
            pgrDiversion.Value = Math.Max(0, Math.Min(100, oMascota.diversion));
        }





        private void button2_Click(object sender, EventArgs e)
        {
            oMascota.jugar();
            actualizarBarras();
            Humor();
            ActualizarTodo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oMascota.alimentar();
            actualizarBarras();
            Humor();
            ActualizarTodo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oMascota.descansar();
            actualizarBarras();
            Humor();
            ActualizarTodo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
