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
            //Si contiene un numero
            if (txtNombre.Text.Contains("0") || txtNombre.Text.Contains("1") || txtNombre.Text.Contains("2") || txtNombre.Text.Contains("3") || txtNombre.Text.Contains("4") || txtNombre.Text.Contains("5") || txtNombre.Text.Contains("6") || txtNombre.Text.Contains("7") || txtNombre.Text.Contains("8") || txtNombre.Text.Contains("9"))
            {
                //Que muestre un mensaje de error
                MessageBox.Show("El nombre no puede contener numeros");
            }
            else
            {
                //Si contiene el correo un @
                if (txtCorreo.Text.Contains("@"))
                {
                    //Que muestre un mensaje con los datos introducidos
                    MessageBox.Show("Nombre: " + txtNombre.Text + "\n" + "Correo: " + txtCorreo.Text);
                }
                else
                {
                    MessageBox.Show("El correo no contiene un @");
                }
            }            
        }
    }
}
