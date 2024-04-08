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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            //Convertir el valor de la caja de texto a double
            double lado = Convert.ToDouble(txtValorLado.Text);

            //Calcular el area del cuadrado
            double area = lado * lado;

            //Mostrar el resultado en la caja de texto
            txtResultado.Text = area.ToString();

        }
    }
}
