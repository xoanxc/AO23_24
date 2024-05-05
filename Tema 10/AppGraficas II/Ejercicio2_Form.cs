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
    public partial class Ejercicio2_Form : Form
    {
        public Ejercicio2_Form()
        {
            InitializeComponent();
        }

        // Método público para agregar elementos al ListBox desde otro formulario
        public void AgregarElementoAlListBox(string elemento)
        {
            lbMaterias.Items.Add(elemento);
        }
        public void AñadirNombreProfesor(string nombre)
        {
            txtProfesor.Text = nombre;
        }


    }
}
