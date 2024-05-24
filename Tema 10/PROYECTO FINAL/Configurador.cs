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

        //Tengo que llamarlo porque no es estatico (Si fuese estatico no podria utilziar la lista de componentes)
        MenuPrincipal menu = new MenuPrincipal();

        private void Configurador_Load(object sender, EventArgs e)
        {
            menu.CargarComponentes();
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
            procesadoresAMD();
        }

        private void rdIntel_CheckedChanged(object sender, EventArgs e)
        {
            //Limpiar y cargar la lista de Intel en el combobox
            cbProcesadores.Items.Clear();
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
    }
}
