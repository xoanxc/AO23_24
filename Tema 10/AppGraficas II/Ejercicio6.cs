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
            if (rdTux.Checked)
            {
                //Mostrar la imagen de Tux
                pictureBox1.Image = Properties.Resources.Tux;
            }
        }

        private void rdMiike_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMiike.Checked)
            {
                //Mostrar la imagen de Miike
                pictureBox1.Image = Properties.Resources.Miike;
            }
        }

        private void rdWikiRafa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdWikiRafa.Checked)
            {
                //Mostrar la imagen de WikiRafa
                pictureBox1.Image = Properties.Resources.WikiRafa;
            }
        }
    }
}
