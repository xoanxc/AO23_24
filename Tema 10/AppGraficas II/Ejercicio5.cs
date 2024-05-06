using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGraficas_II
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbEligeTurno.SelectedIndex == 0) //Mañana
            {
                //Lo añado a lbMañana
                lbMañana.Items.Add(txtNombreEmpleado.Text);
                txtNombreEmpleado.Text = ""; //Limpio el textBox
            }
            else if(cbEligeTurno.SelectedIndex == 1) //Noche
            {
                //Lo añado a lbNoche
                lbNoche.Items.Add(txtNombreEmpleado.Text);
                txtNombreEmpleado.Text = ""; //Limpio el textBox
            }

            txtTotalMañana.Text = lbMañana.Items.Count.ToString(); //Actualizo el total de la mañana
            txtTotalNoche.Text = lbNoche.Items.Count.ToString(); //Actualizo el total de la noche

        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            //Si hay algo seleccionado en lbMañana lo muevo a lbNoche
            if(lbMañana.SelectedItem != null)
            {
                lbNoche.Items.Add(lbMañana.SelectedItem); //Lo pongo
                lbMañana.Items.Remove(lbMañana.SelectedItem); //Lo quito
            }
            //Actualizo el total de la mañana y la noche
            txtTotalMañana.Text = lbMañana.Items.Count.ToString();
            txtTotalNoche.Text = lbNoche.Items.Count.ToString();

        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            //Si hay algo seleccionado en lbNoche lo muevo a lbMañana
            if (lbNoche.SelectedItem != null)
            {
                lbMañana.Items.Add(lbNoche.SelectedItem); //Lo pongo
                lbNoche.Items.Remove(lbNoche.SelectedItem); //Lo quito
            }
            //Actualizo el total de la mañana y la noche
            txtTotalMañana.Text = lbMañana.Items.Count.ToString();
            txtTotalNoche.Text = lbNoche.Items.Count.ToString();
        }

        private void btnDerechazo_Click(object sender, EventArgs e)
        {
            //Muevo todo de lbMañana a lbNoche
            for (int i = 0; i < lbMañana.Items.Count; i++)
            {
                lbNoche.Items.Add(lbMañana.Items[i]);
            }
            lbMañana.Items.Clear(); //Limpio lbMañana
        }

        private void btnIzquierdazo_Click(object sender, EventArgs e)
        {
            //Muevo todo de lbNoche a lbMañana
            for (int i = 0; i < lbNoche.Items.Count; i++)
            {
                lbMañana.Items.Add(lbNoche.Items[i]);
            }
            lbNoche.Items.Clear(); //Limpio lbNoche
        }
    }
}


//*********************************
//***********EY, EY, EPA***********
//*****Ramón lo volvió a hacer*****

