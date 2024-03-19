using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin_AppGraficas
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de la segunda ventana
            Ejercicio1 Ventana =  new Menu1();

            // Mostrar la segunda ventana
            Ventana.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            Ejercicio2 Ventana = new Ejercicio2();
            Ventana.Show();

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
