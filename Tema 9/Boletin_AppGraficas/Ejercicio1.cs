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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre: " + txtNombre.Text + "\nCorreo: " + txtCorreo.Text);
            
        }
    }
}
