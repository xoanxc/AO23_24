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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cerrar la ventana
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Escribir
            txtLaFechaEs.Text = "txtDia" + "txtMes" + "txtAnio";
            


        }
    }
}
