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
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }
        

        public void menuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar la ventana
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.Show();


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cerrar la aplicacion
            this.Close();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar la ventana
            Ejercicio1 ejercicio1 = new Ejercicio1();
            ejercicio1.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar la ventana
            Ejercicio2 ejercicio2 = new Ejercicio2();
            ejercicio2.Show();

        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio3 ejercicio3 = new Ejercicio3();
            ejercicio3.Show();
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar la ventana
            Ejercicio4 ejercicio4 = new Ejercicio4();
            ejercicio4.Show();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar la ventana
            Ejercicio5 ejercicio5 = new Ejercicio5();
            ejercicio5.Show();
        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar la ventana
            Ejercicio6 ejercicio6 = new Ejercicio6();
            ejercicio6.Show();
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar la ventana
            Ejercicio7 ejercicio7 = new Ejercicio7();
            ejercicio7.Show();
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ya te gustaría");
        }

        private void ejercicio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar la ventana
            Ejercicio8 ejercicio8 = new Ejercicio8();
            ejercicio8.Show();
        }

        private void pROYECTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar la ventana
            Proyecto proyecto = new Proyecto();
            proyecto.Show();
        }
    }
}
