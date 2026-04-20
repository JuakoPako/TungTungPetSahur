using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using TungTungPetSahur.Models;

namespace TungTungPetSahur
{
    public partial class MenuSeleccion : Form
    {
        SoundPlayer reproductorMusica;

        public MenuSeleccion()
        {
            InitializeComponent();
            reproductorMusica = new SoundPlayer(Properties.Resources.Main_Menu_Theme);
            reproductorMusica.PlayLooping();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBallerina_Click(object sender, EventArgs e)
        {
            Mascota seleccionada = new BallerinaCapuccina();
            Form1 juego = new Form1(seleccionada);

            juego.Show();
            this.Hide();
        }

        private void btnTungTung_Click(object sender, EventArgs e)
        {
            Mascota seleccionada = new TungTungSahur();
            Form1 juego = new Form1(seleccionada);
            juego.Show();
            this.Hide();
        }

        private void btnTralalero_Click(object sender, EventArgs e)
        {
            Mascota seleccionada = new TralaleroTralala();
            Form1 juego = new Form1(seleccionada);
            juego.Show();
            this.Hide();
        }
    }
}
