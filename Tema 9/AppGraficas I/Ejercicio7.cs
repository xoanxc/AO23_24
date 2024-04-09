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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void btnConvertirDolares_Click(object sender, EventArgs e)
        {
            if (txtEuros.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad de euros a convertir", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double euros = Convert.ToDouble(txtEuros.Text);
                double dolares = euros * 1.18;
                txtDolares.Text = dolares.ToString();
            }
            
        }

        private void btnConvertirEuros_Click(object sender, EventArgs e)
        {
            if (txtDolares.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad de dolares a convertir", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double dolares = Convert.ToDouble(txtDolares.Text);
                double euros = dolares * 0.85;
                txtEuros.Text = euros.ToString();
            }
        }

        private void txtDolares_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
