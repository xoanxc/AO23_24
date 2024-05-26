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
    public partial class VistaDetallada : Form
    {
        //Creo una varuiable para pasarle desde la otra variable el nombre del equipo
        public string NombreEquipo;
        public VistaDetallada()
        {
            InitializeComponent();
        }


        public void VistaDetallada_Load(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.CargarEquipos();

            //Buscar el equipo en menu.equipos con un for
            for (int i = 0; i < menu.equipos.Count; i++)
            {
                //Encontrar el equipo
                if (menu.equipos[i].Contains(NombreEquipo)) //Utilizo la variable
                {
                    //Dividir la Lista en componentes
                    string[] componentes = menu.equipos[i].Split(',');
                    
                    //Colocar nombre del equipo en el nombre de la ventana
                    this.Text = componentes[0];

                    //Colocar los componentes en los textbox
                    txtProcesador.Text = componentes[2];
                    txtPlacaBase.Text = componentes[3];
                    txtTarjetaGrafica.Text = componentes[5];
                    txtMemoriaRAM.Text = componentes[6];
                    txtAlmacenamiento.Text = componentes[7];
                    txtSistemaOperativo.Text = componentes[8];

                    //Colocar precio en el lbl Total
                    lblTotal.Text = "Total: " + componentes[9] + "€";

                    //Procesador
                    if (componentes[1] == "intel")
                    {
                        pbProcesador.Image = Properties.Resources.Intel;

                    }
                    else if (componentes[1] == "amd")
                    {
                        pbProcesador.Image = Properties.Resources.AMD;
                    }
                    else
                    {
                        pbProcesador.Image = Properties.Resources.search_0;
                    }

                    //Grafica
                    if (componentes[4] == "nvidia")
                    {
                        pbTarjetaGrafica.Image = Properties.Resources.Nvidia;
                    }
                    else if (componentes[4] == "amd")
                    {
                        pbTarjetaGrafica.Image = Properties.Resources.RADEON;
                    }
                    else
                    {
                        pbTarjetaGrafica.Image = Properties.Resources.search_0;
                    }

                    //Sistema Operativo
                    if (componentes[8] == "Windows 11 Home")
                    {
                        pbSistemaOperativo.Image = Properties.Resources.WindowsHome;
                    }
                    else if (componentes[8] == "Windows 11 Pro")
                    { 
                        pbSistemaOperativo.Image = Properties.Resources.WindowsPro;
                    }
                    else if (componentes[8] == "Ubuntu")
                    {
                        pbSistemaOperativo.Image = Properties.Resources.Ubuntu;
                    }
                    else if (componentes[8] == "Fedora")
                    {
                        pbSistemaOperativo.Image = Properties.Resources.Fedora;
                    }
                    else
                    {
                        pbSistemaOperativo.Image = Properties.Resources.search_0;
                    }
                    
                    
                    //Imagenes del equipo
                    if (Convert.ToInt32(componentes[9]) <= 500)
                    {
                        pbEquipo.Image = Properties.Resources.PC500;
                    }
                    else if (Convert.ToInt32(componentes[9]) <= 1000)
                    {
                        pbEquipo.Image = Properties.Resources.PC1000;
                    }
                    else if (Convert.ToInt32(componentes[9]) <= 3000)
                    {
                        pbEquipo.Image = Properties.Resources.PC3000;
                    }
                    else if (Convert.ToInt32(componentes[9]) <= 5000)
                    {
                        pbEquipo.Image = Properties.Resources.PC5000;
                    }
                    else
                    {
                        pbEquipo.Image = Properties.Resources.PC1000;
                    }
                }
            }         
        }
    }
}
