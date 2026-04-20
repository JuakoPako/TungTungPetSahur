using System;
using System.Windows.Forms;
using TungTungPetSahur.Models;
using static TungTungPetSahur.Models.Mascota;
using System.Timers;
using System.Media;


namespace TungTungPetSahur
{
    public partial class Form1 : Form
    {
        Mascota oMascota;

        bool estaDurmiendo = false;

        int ticksParaCrecer = 0;

        SoundPlayer reproductorMusica;

        public Form1(Mascota mascotaElegida)
        {
            InitializeComponent();
            this.oMascota = mascotaElegida;

            reproductorMusica = new SoundPlayer(Properties.Resources.In_Game_Theme);
            reproductorMusica.PlayLooping();

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

        int contador = 0;
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {

            if (estaDurmiendo)
            {
                oMascota.sueno = Math.Min(100, oMascota.sueno + 5);
            }

            else
            {
                oMascota.descensoNecesidades();
            }

            ticksParaCrecer++;

            if (ticksParaCrecer == 30) // 5 MINUTOS
            {
                oMascota.EdadActual = Mascota.Edad.Adulto;
            }

            else if (ticksParaCrecer == 60) // 10 MINUTOS
            {
                oMascota.EdadActual = Mascota.Edad.Viejo;
            }
            else if (ticksParaCrecer >= 90) // 15 MINUTOS MUERTE NATURAL
            {
                FinalizarJuegoMuerteNatural();
                return;

            }
                this.Invoke((MethodInvoker)delegate {
                ActualizarTodo();
                actualizarBarras();
                Humor(); 
            });

            if (oMascota.hambre <= 0 || oMascota.diversion <= 0 || oMascota.sueno <= 0)
            {
                contador ++;
            }

            if (contador >= 3)
            {
                FinalizarJuego();
            }

        }

        private void FinalizarJuego()
        {
            
            timer.Stop();

            
            this.Invoke((MethodInvoker)delegate {

                
                reproductorMusica = new SoundPlayer(Properties.Resources.QEPDMusic);
                reproductorMusica.Play(); // O .PlayLooping() si quieres que siga sonando

                
                pictureBox1.Image = Properties.Resources.qepd;

                
                btnComer.Enabled = false;
                btnDormir.Enabled = false;
                btnJugar.Enabled = false;

                
                MessageBox.Show("FIN DE LA PARTIDA: TU BRAINROT HA FALLECIDO");
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
            
            if (estaDurmiendo)
            {
                switch (oMascota.Tipo)
                {
                    case TipoMascota.TungTung:
                        if (oMascota.EdadActual == Mascota.Edad.Bebe) pictureBox1.Image = Properties.Resources.tungtungsahurpiezadurmiendo;
                        else if (oMascota.EdadActual == Mascota.Edad.Adulto) pictureBox1.Image = Properties.Resources.tungtungsahuradultodurmiendo;
                        else pictureBox1.Image = Properties.Resources.tungtungsahurviejodurmiendo;
                        break;

                    case TipoMascota.Capuccina:
                        if (oMascota.EdadActual == Mascota.Edad.Bebe) pictureBox1.Image = Properties.Resources.ballerinacapuccinadurmiendo;
                        else if (oMascota.EdadActual == Mascota.Edad.Adulto) pictureBox1.Image = Properties.Resources.ballerinacapuccinaadultadurmiendo;
                        else pictureBox1.Image = Properties.Resources.ballerinacapuccinaviejadurmiendo;
                        break;

                    case TipoMascota.Tralalero:
                        if (oMascota.EdadActual == Mascota.Edad.Bebe) pictureBox1.Image = Properties.Resources.tralalerodurmiendo;
                        else if (oMascota.EdadActual == Mascota.Edad.Adulto) pictureBox1.Image = Properties.Resources.tralalerodurmiendo; // Ajustar si tienes específica
                        else pictureBox1.Image = Properties.Resources.tralaleroviejodurmiendo;
                        break;
                }
                return;
            }

            
            if (oMascota.Tipo == TipoMascota.TungTung)
            {
                ActualizarFotosTungTung();
            }
            else if (oMascota.Tipo == TipoMascota.Capuccina)
            {
                ActualizarFotosCapuccina();
            }
            else if (oMascota.Tipo == TipoMascota.Tralalero)
            {
                ActualizarFotosTralalero();
            }
        }

        private void ActualizarFotosCapuccina()
        {
            switch (oMascota.EdadActual)
            {
                case Mascota.Edad.Bebe:
                    if (oMascota.humor == "Feliz") pictureBox1.Image = Properties.Resources.ballerinacapuccinapieza;
                    else if (oMascota.humor == "Enfadado") pictureBox1.Image = Properties.Resources.ballerinacapuccinaenojada;
                    else pictureBox1.Image = Properties.Resources.ballerinacapuccinatriste;
                    break;
                case Mascota.Edad.Adulto:
                    if (oMascota.humor == "Feliz") pictureBox1.Image = Properties.Resources.ballerinacapuccinaadulta;
                    else if (oMascota.humor == "Enfadado") pictureBox1.Image = Properties.Resources.ballerinacapuccinaadultaenojada;
                    else pictureBox1.Image = Properties.Resources.ballerinacapuccinaadultatriste;
                    break;
                case Mascota.Edad.Viejo:
                    if (oMascota.humor == "Feliz") pictureBox1.Image = Properties.Resources.ballerinacapuccinavieja;
                    else if (oMascota.humor == "Enfadado") pictureBox1.Image = Properties.Resources.ballerinacapuccinaviejaenojada;
                    else pictureBox1.Image = Properties.Resources.ballerinacapuccinaviejatriste;
                    break;
            }
        }

        private void ActualizarFotosTralalero()
        {
            switch (oMascota.EdadActual)
            {
                case Mascota.Edad.Bebe:
                    if (oMascota.humor == "Feliz") pictureBox1.Image = Properties.Resources.tralaleropieza;
                    else if (oMascota.humor == "Enfadado") pictureBox1.Image = Properties.Resources.tralaleroenojado;
                    else pictureBox1.Image = Properties.Resources.tralalerotriste;
                    break;

                case Mascota.Edad.Adulto:
                    if (oMascota.humor == "Feliz") pictureBox1.Image = Properties.Resources.tralaleroadulto;
                    else if (oMascota.humor == "Enfadado") pictureBox1.Image = Properties.Resources.tralaleroadultoenojado;
                    else pictureBox1.Image = Properties.Resources.tralaleroadultotriste;
                    break;

                case Mascota.Edad.Viejo:
                    if (oMascota.humor == "Feliz") pictureBox1.Image = Properties.Resources.tralaleroviejo;
                    else if (oMascota.humor == "Enfadado") pictureBox1.Image = Properties.Resources.tralaleroviejoenojado;
                    else pictureBox1.Image = Properties.Resources.tralaleroviejotriste;
                    break;
            }
        }

        private void ActualizarFotosTungTung()
        {
            switch (oMascota.EdadActual)
            {
                case Mascota.Edad.Bebe:
                    if (oMascota.humor == "Feliz") pictureBox1.Image = Properties.Resources.tungtungsahurpieza;
                    else if (oMascota.humor == "Enfadado") pictureBox1.Image = Properties.Resources.tungtungsahurpiezaenojado;
                    else pictureBox1.Image = Properties.Resources.tungtungsahurpiezatriste;
                    break;

                case Mascota.Edad.Adulto:
                    if (oMascota.humor == "Feliz") pictureBox1.Image = Properties.Resources.tungtungsahuradultopieza;
                    else if (oMascota.humor == "Enfadado") pictureBox1.Image = Properties.Resources.tungtungsahuradultoenojado;
                    else pictureBox1.Image = Properties.Resources.tungtungsahuradultotriste;
                    break;

                case Mascota.Edad.Viejo:
                    if (oMascota.humor == "Feliz") pictureBox1.Image = Properties.Resources.tungtungsahurviejopieza;
                    else if (oMascota.humor == "Enfadado") pictureBox1.Image = Properties.Resources.tungtungsahurviejoenojado;
                    else pictureBox1.Image = Properties.Resources.tungtungsahurviejotriste;
                    break;
            }
        }


        private void actualizarBarras()
        {
            pgrComida.Value = Math.Max(0, Math.Min(100, oMascota.hambre));
            pgrEnergia.Value = Math.Max(0, Math.Min(100, oMascota.sueno));
            pgrDiversion.Value = Math.Max(0, Math.Min(100, oMascota.diversion));

            lblDiversion.Text = oMascota.diversion.ToString() + "%";
            lblComida.Text = oMascota.hambre.ToString() + "%";
            lblEnergia.Text = oMascota.sueno.ToString() + "%";
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
            estaDurmiendo = !estaDurmiendo;

            if (estaDurmiendo)
            {
                btnDormir.Text = "Despertar";
                this.BackgroundImage = Properties.Resources.fondociudadnoche;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                btnDormir.Text = "Dormir";
                this.BackgroundImage = Properties.Resources.fondociudad;
            }

            ActualizarTodo();

        }

        private void FinalizarJuegoMuerteNatural()
        {
            this.Invoke((MethodInvoker)delegate {
                timer.Stop();
                reproductorMusica.Stop();

                reproductorMusica = new SoundPlayer(Properties.Resources.QEPDMusic);
                reproductorMusica.Play();

                pictureBox1.Image = Properties.Resources.qepd;

                btnComer.Enabled = false;
                btnDormir.Enabled = false;
                btnJugar.Enabled = false;

                MessageBox.Show("TU BRAINROT HA COMPLETADO SU CICLO DE VIDA.\nHa fallecido pacíficamente de vejez. ¡Fuiste un gran dueño!");
            });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
