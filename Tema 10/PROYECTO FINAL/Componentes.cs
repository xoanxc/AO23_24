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
    public partial class Componentes : Form
    {
        public Componentes()
        {
            InitializeComponent();
        }
        

        private void Inventario_Load(object sender, EventArgs e)
        {
            rdAMD.Checked = true;
            rdAMDG.Checked = true;

            MenuPrincipal menu = new MenuPrincipal();
            menu.CargarComponentes();

            //Cargo los componentes en el listbox lbComponentes
            foreach (string componente in menu.componentes)
            {
                string[] datos = componente.Split(',');
                lbComponentes.Items.Add(datos[0] + " " + datos[1] + " " + datos[2] + " " + datos[3] + "€");
            }
            
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
                        MessageBox.Show("Componente añadido correctamente");
                        menu.componentes.Add("procesador,amd," + txtProcesador.Text + "," + txtPrecioProcesador.Text);
                        menu.GuardarComponentes();
                    }
                    else if (rdIntel.Checked)
                    {
                        MessageBox.Show("Componente añadido correctamente");
                        menu.componentes.Add("procesador,intel," + txtProcesador.Text + "," + txtPrecioProcesador.Text);
                        menu.GuardarComponentes();
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
                        MessageBox.Show("Componente añadido correctamente");
                        menu.componentes.Add("placa_base,amd," + txtPlacaBase.Text + "," + txtPrecioPlaca.Text);
                        menu.GuardarComponentes();
                    }
                    else if (rdIntelP.Checked)
                    {
                        MessageBox.Show("Componente añadido correctamente");
                        menu.componentes.Add("placa_base,intel," + txtPlacaBase.Text + "," + txtPrecioPlaca.Text);
                        menu.GuardarComponentes();
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
                        MessageBox.Show("Componente añadido correctamente");
                        menu.componentes.Add("grafica,amd," + txtGrafica.Text + "," + txtPrecioGrafica.Text);
                        menu.GuardarComponentes();
                    }
                    else if (rdNvidia.Checked)
                    {
                        MessageBox.Show("Componente añadido correctamente");
                        menu.componentes.Add("grafica,nvidia," + txtGrafica.Text + "," + txtPrecioGrafica.Text);
                        menu.GuardarComponentes();
                    }
                }
            }
        }

        private void lbComponentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Eliminar el componente seleccionado pero primero se le dice al usuario si esta seguro con un YesNo
            if (lbComponentes.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de que quieres eliminar este componente?", "Eliminar componente", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Cargar los componentes
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.CargarComponentes();

                    //Guardar los cambios
                    menu.GuardarComponentes();

                    //Eliminar el componente seleccionado
                    menu.componentes.RemoveAt(lbComponentes.SelectedIndex);
                    lbComponentes.Items.RemoveAt(lbComponentes.SelectedIndex);

                    //Actualizar el listbox de MenuPrincipal
                    menu.ActualizarLista();               
                }
            }
        }
    }
}
