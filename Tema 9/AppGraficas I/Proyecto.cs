using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppGraficas_I
{
    public partial class Proyecto : Form
    {
        public Proyecto()
        {
            InitializeComponent();
        }

        private void Proyecto_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellidos.Text == "" || txtEdad.Text == "" || txtEmail.Text == "" || txtDNI.Text == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos");
            }
            else
            {
                if(txtNombre.Text.Length > 32 || txtApellidos.Text.Length > 64 || txtEdad.Text.Length > 3)
                {
                    MessageBox.Show("Por favor, rellene los campos con la longitud correcta");
                }
                else
                {
                    MessageBox.Show("Datos guardados correctamente");
                    //Guardar en una lista los datos del usuario
                    List<string> usuarios = new List<string>();

                    string guardar = txtNombre.Text + "," + txtApellidos.Text + "," + txtEdad.Text + "," + txtEmail.Text + "," + txtDNI.Text;
                    usuarios.Add(guardar);



                    //Limpiar los campos
                    txtNombre.Clear();
                    txtApellidos.Clear();
                    txtEdad.Clear();
                    txtEmail.Clear();
                    txtDNI.Clear();
                   
                }
                
                
            }
            



        }
    }
}
