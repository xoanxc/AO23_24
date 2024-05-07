using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGraficas_II
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar la imagen de crema
            pbImages.Image = Properties.Resources.crema;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar la imagen de ensalada
            pbImages.Image = Properties.Resources.ensalada;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar la imagen de empanadillas
            pbImages.Image = Properties.Resources.empanadillas;
        }

        private void rdAgua_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar la imagen de agua
            pbBebida.Image = Properties.Resources.agua;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar la imagen de refresco
            pbBebida.Image = Properties.Resources.refresco;

        }

        private void rdVino_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar la imagen de vino
            pbBebida.Image = Properties.Resources.vino;
        }

        private void gbBebida_Enter(object sender, EventArgs e)
        {
            //Si se selecciona la opción de agua, se mostrará la imagen de agua
            if(rdAgua.Checked)
            {
                lblPrecioBebidaNum.Text = "1,50";
            }
        }
    }
}
