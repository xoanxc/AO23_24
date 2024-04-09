using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGraficas_I
{
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        

        private void Ejercicio8_Load(object sender, EventArgs e)
        {

        }

        private void txtCajaOperadora_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            //Añadir un cero en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //Añadir un punto en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + ".";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            //Añadir un uno en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Añadir un dos en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            //Añadir un tres en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            //Añadir un cuatro en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            //Añadir un cinco en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            //Añadir un seis en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            //Añadir un siete en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            //Añadir un ocho en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            //Añadir un nueve en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "9";
        }
    }
}
