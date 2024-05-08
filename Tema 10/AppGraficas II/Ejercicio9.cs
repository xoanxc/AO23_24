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

            //Limpiar comboBox
            cbPrimerPlato.Items.Clear();
            //Meter los tipos en el comboBox
            cbPrimerPlato.Items.Add("Champiñones");
            cbPrimerPlato.Items.Add("Puerros");
            cbPrimerPlato.Items.Add("Zanahoria");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar la imagen de ensalada
            pbImages.Image = Properties.Resources.ensalada;

            //Limpiar comboBox
            cbPrimerPlato.Items.Clear();
            //Meter los tipos en el comboBox
            cbPrimerPlato.Items.Add("Primavera");
            cbPrimerPlato.Items.Add("Romana");
            cbPrimerPlato.Items.Add("Cesar");
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

            if (rdAgua.Checked)
            {
                lblPrecioBebidaNum.Text = "1,20";
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar la imagen de refresco
            pbBebida.Image = Properties.Resources.refresco;
       
            if (rdRefresco.Checked)
            {
                lblPrecioBebidaNum.Text = "2,30";
            }

        }

        private void rdVino_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar la imagen de vino
            pbBebida.Image = Properties.Resources.vino;
            
            if (rdVino.Checked)
            {
                lblPrecioBebidaNum.Text = "4,50";
            }
        }

      
    }
}
