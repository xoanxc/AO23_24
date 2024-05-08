using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGraficas_II
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar la imagen de crema
            pbImages.Image = Properties.Resources.crema;

            //Limpiar comboBox
            cbPrimerPlato.Items.Clear();
            //Meter los tipos en el comboBox
            cbPrimerPlato.Items.Add("Champiñones");
            cbPrimerPlato.Items.Add("Puerros");
            cbPrimerPlato.Items.Add("Zanahoria");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar la imagen de ensalada
            pbImages.Image = Properties.Resources.ensalada;

            //Limpiar comboBox
            cbPrimerPlato.Items.Clear();
            //Meter los tipos en el comboBox
            cbPrimerPlato.Items.Add("Primavera");
            cbPrimerPlato.Items.Add("Romana");
            cbPrimerPlato.Items.Add("Cesar");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar la imagen de empanadillas
            pbImages.Image = Properties.Resources.empanadillas;

            //Limpiar comboBox
            cbPrimerPlato.Items.Clear();
            //Meter los tipos en el comboBox
            cbPrimerPlato.Items.Add("Pulpo");
            cbPrimerPlato.Items.Add("Zamburiña");
            cbPrimerPlato.Items.Add("Carne");   
            cbPrimerPlato.Items.Add("Choco");    
        }

        private void rdAgua_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar la imagen de agua
            pbBebida.Image = Properties.Resources.agua;

            if (rdAgua.Checked)
            {
                lblPrecioBebidaNum.Text = "1,20";
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar la imagen de refresco
            pbBebida.Image = Properties.Resources.refresco;
       
            if (rdRefresco.Checked)
            {
                lblPrecioBebidaNum.Text = "2,30";
            }

        }

        private void rdVino_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar la imagen de vino
            pbBebida.Image = Properties.Resources.vino;
            
            if (rdVino.Checked)
            {
                lblPrecioBebidaNum.Text = "4,50";
            }
        }

        private void cbPrimerPlato_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Crema
            if (cbPrimerPlato.Text == "Champiñones")
            {
                lblPrecioPrimeroNum.Text = "4,00";
            }
            else if (cbPrimerPlato.Text == "Puerros")
            {
                lblPrecioPrimeroNum.Text = "5,00";
            }
            else if (cbPrimerPlato.Text == "Zanahoria")
            {
                lblPrecioPrimeroNum.Text = "4,75";
            }

            //Ensalada
            else if (cbPrimerPlato.Text == "Primavera")
            {
                lblPrecioPrimeroNum.Text = "3,00";
            }
            else if (cbPrimerPlato.Text == "Romana")
            {
                lblPrecioPrimeroNum.Text = "4,00";
            }
            else if (cbPrimerPlato.Text == "Cesar")
            {
                lblPrecioPrimeroNum.Text = "4,50";
            }

            //Empanadillas
            else if (cbPrimerPlato.Text == "Pulpo")
            {
                lblPrecioPrimeroNum.Text = "6,00";
            }
            else if (cbPrimerPlato.Text == "Zamburiña")
            {
                lblPrecioPrimeroNum.Text = "7,00";
            }
            else if (cbPrimerPlato.Text == "Carne")
            {
                lblPrecioPrimeroNum.Text = "3,00";
            }
            else if (cbPrimerPlato.Text == "Choco")
            {
                lblPrecioPrimeroNum.Text = "3,50";
            }

        }

        private void rdPescado_CheckedChanged(object sender, EventArgs e)
        {
            //Limpiar comboBox
            cbSegundoPlato.Items.Clear();

            //Meter los tipos en el comboBox
            cbSegundoPlato.Items.Add("Merluza a la plancha");
            cbSegundoPlato.Items.Add("Lenguado");
            cbSegundoPlato.Items.Add("Besugo");
            cbSegundoPlato.Items.Add("Bacalao al horno");
        }

        private void rdCarne_CheckedChanged(object sender, EventArgs e)
        {
            //Limpiar comboBox
            cbSegundoPlato.Items.Clear();

            //Meter los tipos en el comboBox
            cbSegundoPlato.Items.Add("Milanesa");
            cbSegundoPlato.Items.Add("Chuleta");
            cbSegundoPlato.Items.Add("San Jacobos");
            cbSegundoPlato.Items.Add("Solomillo");
        }

        private void rdPasta_CheckedChanged(object sender, EventArgs e)
        {
            //Limpiar comboBox
            cbSegundoPlato.Items.Clear();

            //Meter los tipos en el comboBox
            cbSegundoPlato.Items.Add("Spaguetti Bolognesa");
            cbSegundoPlato.Items.Add("Macarrones carbonara");
            cbSegundoPlato.Items.Add("Trofie al pesto");
        }

        private void cbSegundoPlato_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Pescado
            if (cbSegundoPlato.Text == "Merluza a la plancha")
            {
                lblPrecioSegundoNum.Text = "4,50";
            }
            else if (cbSegundoPlato.Text == "Lenguado")
            {
                lblPrecioSegundoNum.Text = "4,50";
            }
            else if (cbSegundoPlato.Text == "Besugo")
            {
                lblPrecioSegundoNum.Text = "6,00";
            }
            else if (cbSegundoPlato.Text == "Bacalao al horno")
            {
                lblPrecioSegundoNum.Text = "6,00";
            }

            //Carne
            else if (cbSegundoPlato.Text == "Milanesa")
            {
                lblPrecioSegundoNum.Text = "4,50";
            }
            else if (cbSegundoPlato.Text == "Chuleta")
            {
                lblPrecioSegundoNum.Text = "7,50";
            }
            else if (cbSegundoPlato.Text == "San Jacobos")
            {
                lblPrecioSegundoNum.Text = "4,50";
            }
            else if (cbSegundoPlato.Text == "Solomillo")
            {
                lblPrecioSegundoNum.Text = "8,00";
            }

            //Pasta
            else if (cbSegundoPlato.Text == "Spaguetti Bolognesa")
            {
                lblPrecioSegundoNum.Text = "9,00";
            }
            else if (cbSegundoPlato.Text == "Macarrones carbonara")
            {
                lblPrecioSegundoNum.Text = "9,50";
            }
            else if (cbSegundoPlato.Text == "Trofie al pesto")
            {
                lblPrecioSegundoNum.Text = "10,50";
            }

        }

        private void btnCalcularCuenta_Click(object sender, EventArgs e)
        {
            //Sumar los precios
            double precioPrimero = Convert.ToDouble(lblPrecioPrimeroNum.Text);
            double precioSegundo = Convert.ToDouble(lblPrecioSegundoNum.Text);
            double precioBebida = Convert.ToDouble(lblPrecioBebidaNum.Text);
            double precioPostre = Convert.ToDouble(lblPrecioPostreNum.Text);
            double total = precioPrimero + precioSegundo + precioBebida + precioPostre;

            //Mostrar el total sin IVA
            double IVA = total * 0.11;
            txtTotalIVA.Text = IVA.ToString();

            //Mostrar el total redondeado a 2 decimales
            txtTotal.Text = Math.Round(total + IVA, 2).ToString();

            //Limpiar campo de vuelta y efectivo PULIDISIMO 
            txtVuelta.Text = "";
            txtEfectivo.Text = "";
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Si el efectivo es menor que el total
                if (Convert.ToDouble(txtEfectivo.Text) < Convert.ToDouble(txtTotal.Text))
                {
                    MessageBox.Show("Efectivo menor que el total");
                }
                else
                {
                    //Calcular el cambio
                    txtVuelta.Text = (Convert.ToDouble(txtEfectivo.Text) - Convert.ToDouble(txtTotal.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error FATAL");
            }          
        }

        private void rdPostre_CheckedChanged(object sender, EventArgs e)
        {
            //Limpiar comboBox
            cbPostre.Items.Clear();

            //Meter los tipos en el comboBox
            cbPostre.Items.Add("Fruta/Yogurt");
            cbPostre.Items.Add("Brownie Chocolate con helado");
            cbPostre.Items.Add("Tarta de Santiago");
            cbPostre.Items.Add("Tarta semifria de chocolate y queso");
        }

        private void rdCafe_CheckedChanged(object sender, EventArgs e)
        {
            //Limpiar comboBox
            cbCafe.Items.Clear();

            //Meter los tipos en el comboBox
            cbCafe.Items.Add("Con leche");
            cbCafe.Items.Add("Cortado");
            cbCafe.Items.Add("Solo");
            cbCafe.Items.Add("Descafeinado ");
        }

        private void cbPostre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Postre
            if (cbPostre.Text == "Fruta/Yogurt")
            {
                lblPrecioPostreNum.Text = "1,50";
            }
            else if (cbPostre.Text == "Brownie Chocolate con helado" || cbPostre.Text == "Tarta de Santiago" || cbPostre.Text == "Tarta semifria de chocolate y queso")
            {
                lblPrecioPostreNum.Text = "3,50";
            }

            
        }

        private void cbCafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cafe
            if (cbCafe.Text == "Con leche" || cbCafe.Text == "Cortado" || cbCafe.Text == "Solo" || cbCafe.Text == "Descafeinado ")
            {
                lblPrecioPostreNum.Text = "1,00";
            }
        }
    }
}
