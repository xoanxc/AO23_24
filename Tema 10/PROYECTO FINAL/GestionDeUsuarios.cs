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

namespace PROYECTO_FINAL
{
    public partial class GestionDeUsuarios : Form
    {
        public GestionDeUsuarios()
        {
            InitializeComponent();
        }


        //Metodo para cargar los usuarios en el ListBox
        public void CargarUsuarios()
        {
            for (int i = 0; i < PanelUsuarios.usuarios.Count; i++)
            {
                string[] usuario = PanelUsuarios.usuarios[i].Split(',');
                lbUsuarios.Items.Add(usuario[0]);
            }
        }

        //Metodo para sobreescrbir el fichero de usuarios
        public void SobreescribirFicheroUsuarios()
        {
            File.WriteAllLines("Usuarios.txt", PanelUsuarios.usuarios);
        }
        


            

        private void GestionDeUsuarios_Load(object sender, EventArgs e)
        {
            //Cargar los usuarios en el ListBox
            CargarUsuarios();
        }

        private void lbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Eliminar el usuario seleccionado pero primero se le dice al usuario si esta seguro con un YesNo
            if (lbUsuarios.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de que quieres eliminar este usuario?", "Eliminar usuario", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    PanelUsuarios.usuarios.RemoveAt(lbUsuarios.SelectedIndex);
                    lbUsuarios.Items.RemoveAt(lbUsuarios.SelectedIndex);

                    SobreescribirFicheroUsuarios();
                }
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //Añadir un usuario
            if (txtUsuario.Text != "" && txtContraseña.Text != "")
            {
                PanelUsuarios.usuarios.Add(txtUsuario.Text + "," + txtContraseña.Text);
                lbUsuarios.Items.Add(txtUsuario.Text);

                SobreescribirFicheroUsuarios();

                //Limpiar los campos
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
        }
    }
}
