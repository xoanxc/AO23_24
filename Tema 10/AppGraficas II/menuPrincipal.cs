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
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        //Mostar los ejercicios
        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio1 ej1 = new Ejercicio1();
            ej1.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio2 ej2 = new Ejercicio2();
            ej2.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio3 ej3 = new Ejercicio3();
            ej3.Show();
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio4 ej4 = new Ejercicio4();
            ej4.Show();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio5 ej5 = new Ejercicio5();
            ej5.Show();
        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio6 ej6 = new Ejercicio6();
            ej6.Show();
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio7 ej7 = new Ejercicio7();
            ej7.Show();
        }

        private void ejercicio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio8 ej8 = new Ejercicio8();
            ej8.Show();
        }

        private void ejercicio9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio9 ej9 = new Ejercicio9();
            ej9.Show();
        }

        //Mostrar los juegos
        private void tresEnRayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TresEnRaya ter = new TresEnRaya();
            ter.Show();
        }

        private void pingPongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PingPong pp = new PingPong();
            pp.Show();
        }

        private void snakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Snake snk = new Snake();
            snk.Show();
        }


    }
}
