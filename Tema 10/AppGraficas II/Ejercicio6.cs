using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGraficas_II
{
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void rdTux_CheckedChanged(object sender, EventArgs e)
        {
            string rutaFichero = Directory.GetCurrentDirectory() + @"\images\tux.png";
            if (rdTux.Checked)
            {
                //Mostrar la imagen de Tux
                pictureBox1.Image = Image.FromFile(rutaFichero);
            }
        }

        private void rdMiike_CheckedChanged(object sender, EventArgs e)
        {
            string rutaFichero = Directory.GetCurrentDirectory() + @"\images\miike.png";
            if (rdMiike.Checked)
            {
                //Mostrar la imagen de Miike
                pictureBox1.Image = Image.FromFile(rutaFichero);
            }
        }

        private void rdWikiRafa_CheckedChanged(object sender, EventArgs e)
        {
            string rutaFichero = Directory.GetCurrentDirectory() + @"\images\wikirafa.png";
            if (rdWikiRafa.Checked)
            {
                //Mostrar la imagen de WikiRafa
                pictureBox1.Image = Image.FromFile(rutaFichero);
            }
        }
    }
}
