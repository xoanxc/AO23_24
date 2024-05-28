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
            CargarEquipos();
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


        public string nombreEquipo;

        public void lbOrdenadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay un elemento seleccionado en el ListBox
                if (lbOrdenadores.SelectedItem != null)
                {
                    // Obtener el nombre del equipo
                    string nombreEquipo = lbOrdenadores.SelectedItem.ToString();

                    // Mostrar el formulario de vista detallada
                    VistaDetallada vistaDetallada = new VistaDetallada();
                    vistaDetallada.NombreEquipo = nombreEquipo; // Pasar el nombre del equipo a la variable del form VistaDetallada
                    vistaDetallada.Show();
                }
                else
                {
                    // Manejar el caso en que no haya ningún elemento seleccionado
                    MessageBox.Show("Por favor, seleccione un equipo de la lista.");
                }
            }
            catch (Exception ex)
            {
                // Opción: mostrar el mensaje de error para depuración
                MessageBox.Show("Se produjo un error: " + ex.Message); //Muestra el error (IRROMPIBLE, ROBUSTO)

                // Recargar los equipos
                CargarEquipos();
                ActualizarLista();
                return;
            }

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
            CargarEquipos(); //Para evitar errores por si se ha eliminado o añadido un equipo
            ActualizarLista();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarComponentes();
            CargarEquipos();
            ActualizarLista();
        }

        //Funcion del filtro de componentes
        private void AplicarFiltro()
        {
            //Limpio la lista para colocar los nuevos elementos
            lbOrdenadores.Items.Clear();

            //Obtengo los filtros seleccionados
            string filtroProcesador = rdAMD.Checked ? "amd" : rdIntel.Checked ? "intel" : null; //Si esta seleccionado el radiobutton de AMD, filtroProcesador = "amd", si esta seleccionado el radiobutton de Intel, filtroProcesador = "intel", si no esta seleccionado ninguno, filtroProcesador = null
            string filtroRAM = rd8GB.Checked ? "8GB" : rd16GB.Checked ? "16GB" : rd32GB.Checked ? "32GB" : null; //Si esta seleccionado el radiobutton de 8GB, filtroRAM = "8GB", si esta seleccionado el radiobutton de 16GB, filtroRAM = "16GB", si esta seleccionado el radiobutton de 32GB, filtroRAM = "32GB", si no esta seleccionado ninguno, filtroRAM = null
            int? filtroPrecio = rd500.Checked ? 500 : rd1000.Checked ? 1000 : rd1500.Checked ? 1500 : rd3000.Checked ? 3000 : rd5000.Checked ? 5000 : (int?)null; //Si esta seleccionado el radiobutton de 500, filtroPrecio = 500, si esta seleccionado el radiobutton de 1000, filtroPrecio = 1000, si esta seleccionado el radiobutton de 1500, filtroPrecio = 1500, si esta seleccionado el radiobutton de 3000, filtroPrecio = 3000, si esta seleccionado el radiobutton de 5000, filtroPrecio = 5000, si no esta seleccionado ninguno, filtroPrecio = null
            //*************Con este fragmento de codigo me ayude de ChatGPT y de la documentación sobre el operador ternario "?"
            //https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/operators/conditional-operator
            //*****************************************************************************************

            //Recorro los equipos y los añado a la lista si cumplen los filtros
            foreach (string equipo in equipos)
            {
                string[] partes = equipo.Split(',');
                string nombre = partes[0];
                string marcaProcesador = partes[1];
                string ram = partes[6];
                int precio = int.Parse(partes[9]);

                //
                if ((filtroProcesador == null || marcaProcesador == filtroProcesador) && (filtroRAM == null || ram == filtroRAM) && (filtroPrecio == null || precio <= filtroPrecio))
                {
                    lbOrdenadores.Items.Add(nombre);
                }
            }
        }

        //Funciones de los radiobuttons
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

        private void componentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostar el formulario de Componentes
            Componentes componentes = new Componentes();
            componentes.Show();

        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cerrar todo el programa
            Application.Exit();
        }

        private void equipoosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipos equipos = new Equipos();
            equipos.Show();
        }
    }
}

