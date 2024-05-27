using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_FINAL
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();           
        }
        

        private void Inventario_Load(object sender, EventArgs e)
        {
            rdAMD.Checked = true;
            rdAMDG.Checked = true;
        }

        private void btnAñadirCPU_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.CargarComponentes();
            //Procesador
            if (txtProcesador.Text == "" || txtPrecioProcesador.Text == "")
            {
                MessageBox.Show("Introduce un procesador y un precio");
                return;
            }
            else
            {
                if (txtProcesador.Text.Contains(","))
                {
                    MessageBox.Show("No se pueden introducir comas en el nombre del procesador");
                    return;
                }
                else if (!txtPrecioProcesador.Text.All(char.IsDigit))
                {
                    MessageBox.Show("No se pueden introducir digitos en el precio");
                    return;
                }
                else
                {
                    if (rdAMD.Checked)
                    {
                        menu.componentes.Add("procesador,amd," + txtProcesador.Text + "," + txtPrecioProcesador.Text);
                    }
                    else if (rdIntel.Checked)
                    {
                        menu.componentes.Add("procesador,intel," + txtProcesador.Text + "," + txtPrecioProcesador.Text);
                    }
                }
            }            
        }

        private void btnAñadirPlaca_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.CargarComponentes();
            //Placa Base
            if (txtPlacaBase.Text == "" || txtPrecioPlaca.Text == "")
            {
                MessageBox.Show("Introduce una placa base y un precio");
                return;
            }
            else
            {
                if (txtPlacaBase.Text.Contains(","))
                {
                    MessageBox.Show("No se pueden introducir comas en el nombre de la placa base");
                    return;
                }
                else if (!txtPrecioPlaca.Text.All(char.IsDigit))
                {
                    MessageBox.Show("No se pueden introducir digitos en el precio");
                    return;
                }
                else
                {
                    if (rdAMDP.Checked)
                    {
                        menu.componentes.Add("placa_base,amd," + txtPlacaBase.Text + "," + txtPrecioPlaca.Text);
                    }
                    else if (rdIntelP.Checked)
                    {
                        menu.componentes.Add("placa_base,intel," + txtPlacaBase.Text + "," + txtPrecioPlaca.Text);
                    }
                }
            }         
        }

        private void btnAñadirGPU_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.CargarComponentes();
            //Tarjeta Grafica
            if (txtGrafica.Text == "" || txtPrecioGrafica.Text == "")
            {
                MessageBox.Show("Introduce una tarjeta grafica y un precio");
                return;
            }
            else
            {
                if (txtGrafica.Text.Contains(","))
                {
                    MessageBox.Show("No se pueden introducir comas en el nombre de la tarjeta grafica");
                    return;
                }
                else if (!txtPrecioGrafica.Text.All(char.IsDigit))
                {
                    MessageBox.Show("No se pueden introducir digitos en el precio");
                    return;
                }
                else
                {
                    if (rdAMDG.Checked)
                    {
                        menu.componentes.Add("grafica,amd," + txtGrafica.Text + "," + txtPrecioGrafica.Text);
                    }
                    else if (rdNvidia.Checked)
                    {
                        menu.componentes.Add("grafica,nvidia," + txtGrafica.Text + "," + txtPrecioGrafica.Text);
                    }
                }
            }
        }
    }
}
