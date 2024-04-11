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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void txtMinutos_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (txtNumeroHoras.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un número de horas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroHoras.Focus();
            }
            else
            {
                //Almacenar el valor de la textbox en una variable double
                double horas = double.Parse(txtNumeroHoras.Text);

                //Convertir de minutos a horas y mostrarlo en la textbox
                txtMinutos.Text = Convert.ToString(horas * 60);

                //Convertir de horas a segundos y mostrarlo en la textbox
                txtSegundos.Text = Convert.ToString(horas * 3600);
            }
            
        }
    }
}
