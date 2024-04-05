using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGraficas_I
{
    public partial class Configuracion : Form
    {
        
        private void Configuracion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMontecastelo.Checked)
            {
                //Declaro la funcion de la imagen publica de menuPrincipal
                menuPrincipal menuPrincipal = new menuPrincipal();

                //Quiero llamar a la imagen publica de menuPrincipal
                menuPrincipal.ptTemaMenu.Image = Properties.Resources.ciclosmontecastelo_cover;
               
                

                
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFrieren.Checked)
            {
                //Declaro la funcion de la imagen publica de menuPrincipal
                menuPrincipal menuPrincipal = new menuPrincipal();

                //Quiero llamar a la imagen publica de menuPrincipal
                menuPrincipal.ptTemaMenu.Image = Properties.Resources.frieren;






            }
        }
    }
}
