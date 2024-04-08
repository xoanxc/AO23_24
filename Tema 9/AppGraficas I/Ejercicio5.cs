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
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            //Cambiar el signo a + y mostrarlo
            lblSigno.Text = "+";
            lblSigno.Show();

            //Sumar los dos números y mostrar el resultado
            txtResultado.Text = Convert.ToString(Convert.ToDouble(txtNum1.Text) + Convert.ToDouble(txtNum2.Text));

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            //Cambiar el signo a - y mostrarlo
            lblSigno.Text = "-";
            lblSigno.Show();

            //Restar los dos números y mostrar el resultado
            txtResultado.Text = Convert.ToString(Convert.ToDouble(txtNum1.Text) - Convert.ToDouble(txtNum2.Text));
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            //Cambiar el signo a * y mostrarlo
            lblSigno.Text = "*";
            lblSigno.Show();

            //Multiplicar los dos números y mostrar el resultado
            txtResultado.Text = Convert.ToString(Convert.ToDouble(txtNum1.Text) * Convert.ToDouble(txtNum2.Text));
        }

        private void btnEntre_Click(object sender, EventArgs e)
        {
            //Cambiar el signo a / y mostrarlo
            lblSigno.Text = "/";
            lblSigno.Show();

            //Dividir los dos números y mostrar el resultado
            txtResultado.Text = Convert.ToString(Convert.ToDouble(txtNum1.Text) / Convert.ToDouble(txtNum2.Text));
        }
    }
}
