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
            //Limpiar la caja de texto
            txtResultado.Text = ""; //Evita crash de la aplicación

            //Convertir el valor de la caja de texto a double
            double lado = Convert.ToDouble(txtValorLado.Text);

            //Calcular el area del cuadrado
            double area = lado * lado;

            //Mostrar el resultado en la caja de texto
            txtResultado.Text = area.ToString();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            //Limpiar la caja de texto
            txtResultado.Text = ""; //Evita crash de la aplicación

            //Convertir los valores de las cajas de texto a double
            double valorLadoMayor = Convert.ToDouble(txtValorLadoMayor.Text);
            double valorLadoMenor = Convert.ToDouble(txtValorLadoMenor.Text);

            //Calcular el area del rectangulo
            double area = valorLadoMayor * valorLadoMenor;

            //Mostrar el resultado en la caja de texto
            txtResultado.Text = area.ToString();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {

            //Limpiar la caja de texto
            txtResultado.Text = ""; //Evita crash de la aplicación

            //Convertir los valores de las cajas de texto a double
            double valorBase = Convert.ToDouble(txtValorBase.Text);
            double valorAltura = Convert.ToDouble(txtValorAltura.Text);

            //Calcular el area del triangulo
            double area = (valorBase * valorAltura) / 2;

            //Mostrar el resultado en la caja de texto
            txtResultado.Text = area.ToString();
        }
    }
}
