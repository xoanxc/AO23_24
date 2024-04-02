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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //Cambiar nombre del boton
            btnPulsar.Text = "Completado";

            //Que muestre un mensaje con los datos introducidos
            MessageBox.Show("Nombre: " + txtNombre.Text + "\n" + "Correo: " + txtCorreo.Text);
        }
    }
}
