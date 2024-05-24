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
    public partial class Configurador : Form
    {
        public Configurador()
        {
            InitializeComponent();
        }

        //Variables globales
        int precioTotal = 0;
        int precioProcesador = 0;
        int precioPlacaBase = 0;
        int precioGrafica = 0;

        //Componentes simples
        string memoriaRAM = "";
        string almacenamiento = "";
        string sistemaOperativo = "";
        string marcaProcesador = "";
        string marcaGrafica = "";

        //Tengo que llamarlo porque no es estatico (Si fuese estatico no podria utilziar la lista de componentes)
        MenuPrincipal menu = new MenuPrincipal();

        private void Configurador_Load(object sender, EventArgs e)
        {
            menu.CargarComponentes(); //IMPORTANTISIMO ESTA PARTE, ES NECESARIO CARGARLOS.
            menu.CargarEquipos();
            rdAMD.Checked = true;
            rdAMDG.Checked = true;
        }

        public void procesadoresIntel() //***INTEL***
        {
            //Recorrer la lista de componentes y añadir los procesadores al combobox
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("procesador,intel"))
                {
                    //Hacer un split para separar por comas
                    string[] procesadoresIntel = menu.componentes[i].Split(',');
                    cbProcesadores.Items.Add(procesadoresIntel[2]);
                    precioProcesador = Convert.ToInt32(procesadoresIntel[3]);
                    marcaProcesador = "intel";
                }
                else
                {
                    continue; //No es realmente necesario, pero queda curioso (pasa a la siguiente iteracion)
                }
            }

            //Recorrer la lista de componentes y añadir las placas base al combobox
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("placa_base,intel"))
                {
                    //Hacer un split para separar por comas
                    string[] placasBaseIntel = menu.componentes[i].Split(',');
                    cbPlacaBase.Items.Add(placasBaseIntel[2]);
                    precioPlacaBase = Convert.ToInt32(placasBaseIntel[3]);
                }
                else
                {
                    continue;
                }
            }
        }

        public void procesadoresAMD() //***AMD***
        {
            //Recorrer la lista de componentes y añadir los procesadores al combobox
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("procesador,amd"))
                {
                    //Hacer un split para separar por comas
                    string[] procesadoresAMD = menu.componentes[i].Split(',');
                    cbProcesadores.Items.Add(procesadoresAMD[2]);
                    precioProcesador = Convert.ToInt32(procesadoresAMD[3]);
                    marcaProcesador = "amd";
                }
                else
                {
                    continue; //No es realmente necesario, pero queda curioso (pasa a la siguiente iteracion)
                }
            }

            //Recorrer la lista de componentes y añadir las placas base al combobox
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("placa_base,amd"))
                {
                    //Hacer un split para separar por comas
                    string[] placasBaseAMD = menu.componentes[i].Split(',');
                    cbPlacaBase.Items.Add(placasBaseAMD[2]);
                    precioPlacaBase = Convert.ToInt32(placasBaseAMD[3]);
                }
                else
                {
                    continue;
                }
            }
        }

        public void graficasAMD() //***AMDG***
        {
            //Recorrer la lista de componentes y añadir las graficas al combobox
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("grafica,amd"))
                {
                    //Hacer un split para separar por comas
                    string[] graficasAMD = menu.componentes[i].Split(',');
                    cbGraficas.Items.Add(graficasAMD[2]);
                    precioGrafica = Convert.ToInt32(graficasAMD[3]);
                    marcaGrafica = "amd";
                }
                else
                {
                    continue;
                }
            }
        }

        public void graficasNvidia() //***NVIDIA***
        {
            //Recorrer la lista de componentes y añadir las graficas al combobox
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("grafica,nvidia"))
                {
                    //Hacer un split para separar por comas
                    string[] graficasNvidia = menu.componentes[i].Split(',');
                    cbGraficas.Items.Add(graficasNvidia[2]);
                    precioGrafica = Convert.ToInt32(graficasNvidia[3]);
                    marcaGrafica = "nvidia";
                }
                else
                {
                    continue;
                }
            }
        }

        private void rdAMD_CheckedChanged(object sender, EventArgs e)
        {
            //Limpiar y cargar la lista de AMD en el combobox
            cbProcesadores.Items.Clear();
            cbPlacaBase.Items.Clear();
            procesadoresAMD();
        }

        private void rdIntel_CheckedChanged(object sender, EventArgs e)
        {
            //Limpiar y cargar la lista de Intel en el combobox
            cbProcesadores.Items.Clear();
            cbPlacaBase.Items.Clear();
            procesadoresIntel();
        }

        private void rdAMDG_CheckedChanged(object sender, EventArgs e)
        {
            //Limpiar y cargar la lista de AMD en el combobox
            cbGraficas.Items.Clear();
            graficasAMD();
        }

        private void rdNvidia_CheckedChanged(object sender, EventArgs e)
        {
            //Limpiar y cargar la lista de Nvidia en el combobox
            cbGraficas.Items.Clear();
            graficasNvidia();

        }

        
        //Zona de selección de componentes simples (Duele no poder optimizarlo)
        private void rd8GB_CheckedChanged(object sender, EventArgs e)
        {
            memoriaRAM = "8GB";
        }
        private void rd16GB_CheckedChanged(object sender, EventArgs e)
        {
            memoriaRAM = "16GB";
        }
        private void rd32GB_CheckedChanged(object sender, EventArgs e)
        {
            memoriaRAM = "32GB";
        }
        private void rd240GB_CheckedChanged(object sender, EventArgs e)
        {
            almacenamiento = "240GB";
        }
        private void rd500GB_CheckedChanged(object sender, EventArgs e)
        {
            almacenamiento = "500GB";
        }
        private void rd1TB_CheckedChanged(object sender, EventArgs e)
        {
            almacenamiento = "1TB";
        }
        private void rd2TB_CheckedChanged(object sender, EventArgs e)
        {
            almacenamiento = "2TB";
        }
        private void rdWindowsHome_CheckedChanged(object sender, EventArgs e)
        {
            sistemaOperativo = "Windows 11 Home";
        }
        private void rdWindowsPro_CheckedChanged(object sender, EventArgs e)
        {
            sistemaOperativo = "Windows 11 Pro";
        }
        private void rdUbuntu_CheckedChanged(object sender, EventArgs e)
        {
            sistemaOperativo = "Ubuntu";
        }
        private void rdFedora_CheckedChanged(object sender, EventArgs e)
        {
            sistemaOperativo = "Fedora";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPrecioTotal.Text == "" || cbProcesadores.Text == "" || cbPlacaBase.Text == "" || cbGraficas.Text == "" || memoriaRAM == "" || almacenamiento == "" || sistemaOperativo == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //Guardar el equipo en la Lista de MenuPrincipal
                menu.equipos.Add(txtNombreOrdenador.Text + "," + marcaProcesador + "," + cbProcesadores.Text + "," + cbPlacaBase.Text + "," + marcaGrafica + "," + cbGraficas.Text + "," + memoriaRAM + "," + almacenamiento + "," + sistemaOperativo + "," + precioTotal);
                menu.GuardarEquipos();
                MessageBox.Show("Equipo guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpiar los campos (NO PUEDO OPTIMIZARLO)
                txtNombreOrdenador.Text = "";
                txtPrecioTotal.Text = "";
                cbProcesadores.Text = "";
                cbPlacaBase.Text = "";
                cbGraficas.Text = "";
                rd8GB.Checked = false;
                rd16GB.Checked = false;
                rd32GB.Checked = false;
                rd240GB.Checked = false;
                rd500GB.Checked = false;
                rd1TB.Checked = false;
                rd2TB.Checked = false;
                rdWindowsHome.Checked = false;
                rdWindowsPro.Checked = false;
                rdUbuntu.Checked = false;
                rdFedora.Checked = false;
            }
            
        }
    }
}
