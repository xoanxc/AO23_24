using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Para trabajar con streamwriter

namespace AppGraficas_II
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        //Ruta del fichero
        private string rutaFicheroCombo = Directory.GetCurrentDirectory() + @"\comboBox.txt";
        private string rutaFicheroList = Directory.GetCurrentDirectory() + @"\listBox.txt";

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (rdComboBox.Checked == true)
            {
                //Cargar datos al ComboBox
                comboBox1.Items.Add(txtNombreCampo.Text);
                

            }
            else if (rdListBox.Checked == true)
            {
                //Cargo datos al ListBox
                listBox1.Items.Add(txtNombreCampo.Text);
            }         
        }

        //Guardar datos en un fichero
        private void btnVolcarTXT_Click(object sender, EventArgs e)
        {
            if (rdComboBox.Checked == true)
            {
                //Guardar datos del ComboBox en un fichero
                StreamWriter streamwriter = new StreamWriter(rutaFicheroCombo);
                foreach (var item in comboBox1.Items)
                {
                    streamwriter.WriteLine(item.ToString());
                }
                streamwriter.Close();
            }
            else if (rdListBox.Checked == true)
            {
                //Guardar datos del ListBox en un fichero
                StreamWriter streamwriter = new StreamWriter(rutaFicheroList);
                foreach (var item in listBox1.Items)
                {
                    streamwriter.WriteLine(item.ToString());
                }
                streamwriter.Close();
            }
               
        }
    }
}
