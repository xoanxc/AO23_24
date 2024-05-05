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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Si esta vacio
            if (txtValor.Text == "" || txtValor.Text.Contains('.'))
            {
                MessageBox.Show("Ingrese un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  
            }
            else
            {
                //Convertir a cada unidad
                if (rdMilimetros.Checked)
                {
                    double metros = Convert.ToDouble(txtValor.Text);
                    double milimetros = metros * 1000;
                    txtResultado.Text = milimetros.ToString();
                }
                else if (rdCentimetros.Checked)
                {
                    double metros = Convert.ToDouble(txtValor.Text);
                    double centimetros = metros * 100;
                    txtResultado.Text = centimetros.ToString();
                }
                else if (rdDecimetros.Checked)
                {
                    double metros = Convert.ToDouble(txtValor.Text);
                    double decimetros = metros * 10;
                    txtResultado.Text = decimetros.ToString();
                }
                else if (rdKilometros.Checked) //Si, lo se, vale con un else
                {
                    double metros = Convert.ToDouble(txtValor.Text);
                    double kilometros = metros / 1000;
                    txtResultado.Text = kilometros.ToString();
                }
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpiar
            txtValor.Clear();
            txtResultado.Clear();
        }
    }
}
