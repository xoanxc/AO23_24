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
        }

        public void procesadoresIntel()
        {
            //Recorrer la lista de componentes y añadir los procesadores de Intel al combobox
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("intel"))
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
        }

        public void procesadoresAMD()
        {
            //Recorrer la lista de componentes y añadir los procesadores de AMD al combobox
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("amd"))
                {
                    //Hacer un split para separar por comas
                    string[] procesadoresAMD = menu.componentes[i].Split(',');
                    cbProcesadores.Items.Add(menu.componentes[i]);
                }
                else
                {
                    continue; //No es realmente necesario, pero queda curioso (pasa a la siguiente iteracion)
                }
            }
        }


        private void rdAMD_CheckedChanged(object sender, EventArgs e)
        {
            //Limpio e introduzco los procesadores de AMD
            cbProcesadores.Items.Clear();

            //Cargo la lista de AMD en el combobox
            procesadoresAMD();
        }

        private void rdIntel_CheckedChanged(object sender, EventArgs e)
        {
            //Limpio e introduzco los procesadores de Intel
            cbProcesadores.Items.Clear();

            //Cargar la lista de Intel en el combobox
            procesadoresIntel();
        }

        
    }
}
