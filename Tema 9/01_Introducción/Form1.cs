using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Introducción
{
    public partial class Form1 : Form
    {

        //Zona de declaración de variables

        List<string> listaDNI = new List<string>();





        //************************************************************

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has pulsado el botón");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Recoger lo que el usuario introduce en la caja de texto
            string dni = txtDNI.Text;


            if(dni == "")
            {
                MessageBox.Show("No has introducido ningún DNI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus(); //Poner el foco en la caja de texto
                return; //Salir corriendo de la función
            }
            
                //Añadir el DNI a la lista
                dni = dni.Trim(); //Quitar espacios en blanco
                dni = dni.ToUpper(); //Pasar a mayúsculas
                listaDNI.Add(dni);

            
            

        }
    }
}
