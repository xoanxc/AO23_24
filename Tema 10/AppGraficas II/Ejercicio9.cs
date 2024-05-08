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

            //Limpiar comboBox
            cbPrimerPlato.Items.Clear();
            //Meter los tipos en el comboBox
            cbPrimerPlato.Items.Add("Pulpo");
            cbPrimerPlato.Items.Add("Zamburiña");
            cbPrimerPlato.Items.Add("Carne");   
            cbPrimerPlato.Items.Add("Choco");    
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

        private void cbPrimerPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPrimerPlato.Text == "Champiñones")
            {
                lblPrecioPrimeroNum.Text = "4,00";
            }
            else if (cbPrimerPlato.Text == "Puerros")
            {
                lblPrecioPrimeroNum.Text = "5,00";
            }
            else if (cbPrimerPlato.Text == "Zanahoria")
            {
                lblPrecioPrimeroNum.Text = "4,75";
            }
            else if (cbPrimerPlato.Text == "Primavera")
            {
                lblPrecioPrimeroNum.Text = "3,00";
            }
            else if (cbPrimerPlato.Text == "Romana")
            {
                lblPrecioPrimeroNum.Text = "4,00";
            }
            else if (cbPrimerPlato.Text == "Cesar")
            {
                lblPrecioPrimeroNum.Text = "4,50";
            }
            else if (cbPrimerPlato.Text == "Pulpo")
            {
                lblPrecioPrimeroNum.Text = "6,00";
            }
            else if (cbPrimerPlato.Text == "Zamburiña")
            {
                lblPrecioPrimeroNum.Text = "7,00";
            }
            else if (cbPrimerPlato.Text == "Carne")
            {
                lblPrecioPrimeroNum.Text = "3,00";
            }
            else if (cbPrimerPlato.Text == "Choco")
            {
                lblPrecioPrimeroNum.Text = "3,50";
            }

        }
    }
}
