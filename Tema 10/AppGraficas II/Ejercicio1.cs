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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        //Crear un array para almacenar el total de cada producto
        public double[] total = new double[7];


        private void button1_Click(object sender, EventArgs e)
        {
            total[0] = 0;
            //Sumar el total de cada producto
            for (int i = 0; i < total.Length; i++)
            {
                total[0] += total[i];
            } 
            //Mostar el total en la text box
            txtTotal.Text = total[0].ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Limpiar los controles
            chLaserJet.Checked = false;
            chADSL.Checked = false;
            chBigNotebook.Checked = false;
            chHiTech.Checked = false;
            chHPDigicam.Checked = false;
            chSmartDesktop.Checked = false;

            //Limpiar la textBox
            txtTotal.Text = "";

            total[0] = 0;
        }
        

        private void chLaserJet_CheckedChanged(object sender, EventArgs e)
        {
            //Dar valor al upDown
            if (chLaserJet.Checked == true)
            {
                upLaserJet.Enabled = true;
                upLaserJet.Value = 1;
            }
            else
            {
                upLaserJet.Enabled = false;
                upLaserJet.Value = 0;
            }
            //Sumar o restar el precio
            if (chLaserJet.Checked == true)
            {
                total[1] = 100;
            }
            else
            {
                total[1] = 0;
            }
        }

        private void upLaserJet_ValueChanged(object sender, EventArgs e)
        {
            //Multiplicar el precio por la cantidad
            total[1] = 100 * Convert.ToDouble(upLaserJet.Value);
        }

        private void chBigNotebook_CheckedChanged(object sender, EventArgs e)
        {
            //Dar valor al upDown
            if (chBigNotebook.Checked == true)
            {
                upBigNotebook.Enabled = true;
                upBigNotebook.Value = 1;
            }
            else
            {
                upBigNotebook.Enabled = false;
                upBigNotebook.Value = 0;
            }
            //Sumar o restar el precio
            if (chBigNotebook.Checked == true)
            {
                total[2] = 500;
            }
            else
            {
                total[2] = 0;
            }
        }

        private void upBigNotebook_ValueChanged(object sender, EventArgs e)
        {
            //Multiplicar el precio por la cantidad
            total[2] = 500 * Convert.ToDouble(upBigNotebook.Value);
        }

        private void chSmartDesktop_CheckedChanged(object sender, EventArgs e)
        {
            //Dar valor al upDown
            if (chSmartDesktop.Checked == true)
            {
                upSmartDesktop.Enabled = true;
                upSmartDesktop.Value = 1;
            }
            else
            {
                upSmartDesktop.Enabled = false;
                upSmartDesktop.Value = 0;
            }
            //Sumar o restar el precio
            if (chSmartDesktop.Checked == true)
            {
                total[3] = 200;
            }
            else
            {       
                total[3] = 0;
            }
        }
        private void upSmartDesktop_ValueChanged(object sender, EventArgs e)
        {
            //Multiplicar el precio por la cantidad
            total[3] = 200 * Convert.ToDouble(upSmartDesktop.Value);
        }

        private void chHPDigicam_CheckedChanged(object sender, EventArgs e)
        {
            //Dar valor al upDown
            if (chHPDigicam.Checked == true)
            {
                upHPDigicam.Enabled = true;
                upHPDigicam.Value = 1;
            }
            else
            {
                upHPDigicam.Enabled = false;
                upHPDigicam.Value = 0;
            }
            //Sumar o restar el precio
            if (chHPDigicam.Checked == true)
            {
                total[4] = 80;
            }
            else
            {
                total[4] = 0;
            }
        }
        private void upHPDigicam_ValueChanged(object sender, EventArgs e)
        {
            //Multiplicar el precio por la cantidad
            total[4] = 80 * Convert.ToDouble(upHPDigicam.Value);
        }

        private void chHiTech_CheckedChanged(object sender, EventArgs e)
        {
            //Dar valor al upDown
            if (chHiTech.Checked == true)
            {
                upHiTech.Enabled = true;
                upHiTech.Value = 1;
            }
            else
            {
                upHiTech.Enabled = false;
                upHiTech.Value = 0;
            }
            //Sumar o restar el precio
            if (chHiTech.Checked == true)
            {
                total[5] = 300;
            }
            else
            {
                total[5] = 0;
            }
        }
        private void upHiTech_ValueChanged(object sender, EventArgs e)
        {
            //Multiplicar el precio por la cantidad
            total[5] = 300 * Convert.ToDouble(upHiTech.Value);
        }

        private void chADSL_CheckedChanged(object sender, EventArgs e)
        {
            //Dar valor al upDown
            if (chADSL.Checked == true)
            {
                upADSL.Enabled = true;
                upADSL.Value = 1;
            }
            else
            {
                upADSL.Enabled = false;
                upADSL.Value = 0;
            }
            //Sumar o restar el precio
            if (chADSL.Checked == true)
            {
                total[6] = 100;
            }
            else
            {
                total[6] = 0;
            }
        }
        private void upADSL_ValueChanged(object sender, EventArgs e)
        {
            //Multiplicar el precio por la cantidad
            total[6] = 100 * Convert.ToDouble(upADSL.Value);
        }
    }
}
