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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void Ejercicio7_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        //Declaración de variables
        byte contadorIzq = 0;
        byte contadorDer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Hacer que la imagen se mueva de un lado a otro
            if (contadorIzq < 10)
            {
                pbTux.Left -= 5;
                contadorIzq++;
            }
            else if (contadorDer < 10)
            {
                pbTux.Left += 5;
                contadorDer++;
            }
            else
            {
                contadorIzq = 0;
                contadorDer = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}