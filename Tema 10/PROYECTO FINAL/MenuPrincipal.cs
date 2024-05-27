using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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

        public void GuardarComponentes()
        {
            //Guardar los componentes
            File.WriteAllLines("Componentes.txt", componentes);
        }

        public void GuardarEquipos()
        {
            //Guardar los equipos
            File.WriteAllLines("Equipos.txt", equipos);
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

        public void ActualizarLista()
        {
            //Limpiar la lista
            lbOrdenadores.Items.Clear();
            //Cargar los equipos en el listbox
            for (int i = 0; i < equipos.Count; i++)
            {
                string[] equipo = equipos[i].Split(',');
                lbOrdenadores.Items.Add(equipo[0]);
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //Cargar las funciones
            CargarComponentes();
            CargarEquipos();
            ActualizarLista();
        }

        private void finalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cerrar todo el programa
            Application.Exit();
        }


        public string nombreEquipo;

        public void lbOrdenadores_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Obtener el nombre del equipo
            nombreEquipo = lbOrdenadores.SelectedItem.ToString();

            //Mostrar el formulario de vista detallada
            VistaDetallada vistaDetallada = new VistaDetallada();
            vistaDetallada.NombreEquipo = nombreEquipo; //Le paso el nombre del equipo a la variable del form VistaDetallada
            vistaDetallada.Show();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Eliminar la seleccion de los radiobuttons
            rdAMD.Checked = false;
            rdIntel.Checked = false;
            rd8GB.Checked = false;
            rd16GB.Checked = false;
            rd32GB.Checked = false;
            rd500.Checked = false;
            rd1000.Checked = false;
            rd1500.Checked = false;
            rd3000.Checked = false;
            rd5000.Checked = false;
            ActualizarLista();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostar el formulario de inventario
            Inventario inventario = new Inventario();
            inventario.Show();
        }

        //Funcion del filtro de los componentes
        private void AplicarFiltro()
        {
            //Esto se aplica cada vez que se selecciona un checkbuton o radio buton
            //Se limpia la lista
            lbOrdenadores.Items.Clear();

        }
        private void rdAMD_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void rdIntel_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void rd8GB_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void rd16GB_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void rd32GB_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void rd500_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void rd1000_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void rd1500_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void rd3000_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void rd5000_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }
    }
}

