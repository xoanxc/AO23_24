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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtFahrenheit.Text == "")
            {
                MessageBox.Show("Ingrese un valor en Fahrenheit", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Guardar el valor de fahrenheit en un double
                double fahrenheit = Convert.ToDouble(txtFahrenheit.Text);

                //Convertir de fahrenheit a centigrados y redondear a 2 decimales
                double centigrados = Math.Round((fahrenheit - 32) * 5 / 9, 2);  

                //Mostrar el resultado en el textbox de centigrados
                txtCentigrados.Text = centigrados.ToString();
            }
                  
        }

        private void btnPasarF_Click(object sender, EventArgs e)
        {
            if(txtCentigrados.Text == "")
            {
                MessageBox.Show("Ingrese un valor en Centigrados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Guardar el valor de centigrados en un double
                double centigrados = Convert.ToDouble(txtCentigrados.Text);

                //Convertir de centigrados a fahrenheit y redondear a 2 decimales
                double fahrenheit = Math.Round((centigrados * 9 / 5) + 32, 2);

                //Mostrar el resultado en el textbox de fahrenheit
                txtFahrenheit.Text = fahrenheit.ToString();
            }
            
        }
    }
}
