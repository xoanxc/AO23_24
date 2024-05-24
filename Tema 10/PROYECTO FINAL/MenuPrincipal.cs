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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        public List<string> componentes = new List<string>(); //Ventaja de las listas, tamaño dinamico
        public List<string> equipos = new List<string>();
        public void CargarComponentes()
        {
            //Cargar los componentes
            
            //Si el fichero no esta creado lo creo
            if (!File.Exists("Componentes.txt"))
            {
                File.Create("Componentes.txt").Close();
                return; //Vuelvo atras para que cargue los componentes
            }
            else
            {
                //Si el fichero esta creado lo copio a una lista [LOS ARRAY VAN A ACABAR SIENDO MEJOR IDEA QUE LAS LISTAS] (Al menos para esto)
                componentes = File.ReadAllLines("Componentes.txt").ToList();
            }
            
            
        }

        public void CargarEquipos()
        {
            //Cargar los equipos

            //Si el fichero no esta creado lo creo
            if (!File.Exists("Equipos.txt"))
            {
                File.Create("Equipos.txt").Close();
                return; //Vuelvo atras para que cargue los equipos
            }
            else
            {
                //Si el fichero esta creado lo copio a un array [Mismo codigo que el anterior]
                equipos = File.ReadAllLines("Equipos.txt").ToList();
            }
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

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //Cargar las funciones
            CargarComponentes();
            CargarEquipos();

            //Cargar los componentes equipos en el combobox

        }

        private void finalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cerrar todo el programa
            Application.Exit();
        }
    }
}
