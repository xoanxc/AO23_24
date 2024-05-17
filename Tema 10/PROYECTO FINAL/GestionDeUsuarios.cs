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

        private void GestionDeUsuarios_Load(object sender, EventArgs e)
        {
            //Añadir los usuarios al ListBox (desde el array de usuarios de PanelUsuarios) y luego split para mostrar solo el nombre
            for (int i = 0; i < PanelUsuarios.usuarios.Count; i++)
            {
                string[] usuario = PanelUsuarios.usuarios[i].Split(',');
                lbUsuarios.Items.Add(usuario[0]);
            }

            //Ocultar el campo de contraseña
            txtContraseña.PasswordChar = '*';
            //https://learn.microsoft.com/es-es/dotnet/api/system.windows.forms.textbox.passwordchar?view=windowsdesktop-8.0
        }

        private void lbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Eliminar el usuario seleccionado
            if (lbUsuarios.SelectedIndex != -1)
            {
                PanelUsuarios.usuarios.RemoveAt(lbUsuarios.SelectedIndex);
                lbUsuarios.Items.RemoveAt(lbUsuarios.SelectedIndex);

                //Sobreescribir el fichero de usuarios
                StreamWriter sw = new StreamWriter("usuarios.txt");
                for (int i = 0; i < PanelUsuarios.usuarios.Count; i++)
                {
                    sw.WriteLine(PanelUsuarios.usuarios[i]);
                }
                sw.Close();             
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            //Añadir un usuario
            if (txtUsuario.Text != "" && txtContraseña.Text != "")
            {
                PanelUsuarios.usuarios.Add(txtUsuario.Text + "," + txtContraseña.Text);
                lbUsuarios.Items.Add(txtUsuario.Text);

                //Sobreescribir el fichero de usuarios
                StreamWriter sw = new StreamWriter("usuarios.txt");
                for (int i = 0; i < PanelUsuarios.usuarios.Count; i++)
                {
                    sw.WriteLine(PanelUsuarios.usuarios[i]);
                }
                sw.Close();

                //Limpiar los campos
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
        }
    }
}
