using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void registrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abro el formulario de registro de usuarios
            GestionDeUsuarios gestionUsuarios = new GestionDeUsuarios();
            gestionUsuarios.Show();
        }

        private void cerarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cerrar el formulario actual
            this.Close();

            //Abro el formulario de inicio de sesión
            PanelUsuarios panelUsuarios = new PanelUsuarios();
            panelUsuarios.Show();
        }

        private void configuradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abro el configurador
            Configurador configurador = new Configurador();
            configurador.Show();
        }
    }
}
