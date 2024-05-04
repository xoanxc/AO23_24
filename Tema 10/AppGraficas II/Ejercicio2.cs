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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void rd1GMI_CheckedChanged(object sender, EventArgs e)
        {
            //Añadir las asignaturas de 1º GMI
            listBox1.Items.Clear();
            listBox1.Items.Add("Aplicaciones Ofimáticas");
            listBox1.Items.Add("Formación y Orientación Laboral");
            listBox1.Items.Add("Montaje y Mantenimiento de Equipos");
            listBox1.Items.Add("Redes Locales");
            listBox1.Items.Add("Sistemas Operativos Monopuestos");
        }

        private void rd2GMI_CheckedChanged(object sender, EventArgs e)
        {
            //Añadir las asignaturas de 2º GMI
            listBox1.Items.Clear();
            listBox1.Items.Add("Aplicaciones Web");
            listBox1.Items.Add("Empresa e Iniciativa Emprendedora");
            listBox1.Items.Add("Formación en Centros de Trabajo");
            listBox1.Items.Add("Servicios en Red");
            listBox1.Items.Add("Sistemas Operativos Multipuestos");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
