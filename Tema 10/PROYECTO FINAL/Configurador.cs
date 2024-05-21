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

        public void procesadoresIntel()
        {        
            //Hacer un split para separar por comas
            string[] procesadoresIntel = [2].Split(','); //Tengo que ver como hacerlo con el array publico

            //Recorrer el array y añadirlo al combobox
            for (int i = 0; i < procesadoresIntel.Length; i++)
            {
                cbProcesadores.Items.Add(procesadoresIntel[i]);
            }
        }

        private void Configurador_Load(object sender, EventArgs e)
        {
            rdAMD.Checked = true;
        }

        private void cbProcesadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            if (rdIntel.Checked == true)
            {

                //Limpio e introduzco los procesadores de Intel
                cbProcesadores.Items.Clear();

                //Cargar el array de Intel en el combobox

                
                

            }
            else //En caso de ser AMD
            {
                //Limpio e introduzco los procesadores de AMD
                cbProcesadores.Items.Clear();


            }
        }
    }
}
