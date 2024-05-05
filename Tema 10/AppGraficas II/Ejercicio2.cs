using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGraficas_II
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void rd1GMI_CheckedChanged(object sender, EventArgs e)
        {
            //Añadir las asignaturas de 1º GMI
            listBox1.Items.Clear();
            listBox1.Items.Add("Aplicaciones Ofimáticas");
            listBox1.Items.Add("Formación y Orientación Laboral");
            listBox1.Items.Add("Montaje y Mantenimiento de Equipos");
            listBox1.Items.Add("Redes Locales");
            listBox1.Items.Add("Sistemas Operativos Monopuestos");
        }

        private void rd2GMI_CheckedChanged(object sender, EventArgs e)
        {
            //Añadir las asignaturas de 2º GMI
            listBox1.Items.Clear();
            listBox1.Items.Add("Aplicaciones Web");
            listBox1.Items.Add("Empresa e Iniciativa Emprendedora");
            listBox1.Items.Add("Formación en Centros de Trabajo");
            listBox1.Items.Add("Servicios en Red");
            listBox1.Items.Add("Sistemas Operativos Multipuestos");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lo preparo para mostrarlo
            Ejercicio2_Form ej2 = new Ejercicio2_Form();

            if (rd1GMI.Checked)
            {
                if(listBox1.SelectedIndex == 0)
                {
                    //Muestro el formulario
                    ej2.Show();

                    //***************************
                    //***GRACIAS CURSO DE JAVA***
                    //***************************

                    //Añadir el nombre del profesor
                    ej2.AñadirNombreProfesor("Ramón Rios");

                    //Añado el temario con el metodo creado en el form Ejercicio2_Form
                    ej2.AgregarElementoAlListBox("Variables");
                    ej2.AgregarElementoAlListBox("Operadores");
                    ej2.AgregarElementoAlListBox("Estructuras de Control");
                    ej2.AgregarElementoAlListBox("Arrays");
                    ej2.AgregarElementoAlListBox("Funciones");


                }
                else if(listBox1.SelectedIndex == 1)
                {
                    //Lo muestro
                    ej2.Show();

                    //Añadir el nombre del profesor
                    ej2.AñadirNombreProfesor("Daniel Rivas");

                    //Añado el temario con el metodo creado en el form Ejercicio2_Form
                    ej2.AgregarElementoAlListBox("Presentación");
                    ej2.AgregarElementoAlListBox("Busqueda de empleo");
                    ej2.AgregarElementoAlListBox("Trabajo en grupo");
                    ej2.AgregarElementoAlListBox("Derecho laboral");
                    ej2.AgregarElementoAlListBox("La Nomina");
                    ej2.AgregarElementoAlListBox("Seguridad Social");
                }
                else if(listBox1.SelectedIndex == 2)
                {
                    //Lo muestro
                    ej2.Show();

                    //Añadir el nombre del profesor
                    ej2.AñadirNombreProfesor("Alberto");

                    //Añado el temario con el metodo creado en el form Ejercicio2_Form
                    ej2.AgregarElementoAlListBox("Componentes de un ordenador");
                    ej2.AgregarElementoAlListBox("Montaje de un ordenador");
                    ej2.AgregarElementoAlListBox("Mantenimiento de un ordenador");
                    ej2.AgregarElementoAlListBox("Instalación de un sistema operativo");
                }
                else if(listBox1.SelectedIndex == 3)
                {
                    //Lo muestro
                    ej2.Show();

                    //Añadir el nombre del profesor
                    ej2.AñadirNombreProfesor("Francisco Rocha");

                    //Añado el temario con el metodo creado en el form Ejercicio2_Form
                    ej2.AgregarElementoAlListBox("Redes");
                    ej2.AgregarElementoAlListBox("Protocolos");
                    ej2.AgregarElementoAlListBox("Configuración de Redes");
                    ej2.AgregarElementoAlListBox("Seguridad en Redes");
                }
                else if(listBox1.SelectedIndex == 4)
                {
                    //Lo muestro
                    ej2.Show();

                    //Añadir el nombre del profesor
                    ej2.AñadirNombreProfesor("Enrique Prieto Magá");

                    //Añado el temario con el metodo creado en el form Ejercicio2_Form
                    ej2.AgregarElementoAlListBox("Sistemas Operativos");
                    ej2.AgregarElementoAlListBox("Instalación de Sistemas Operativos");
                    ej2.AgregarElementoAlListBox("Configuración de Sistemas Operativos");
                    ej2.AgregarElementoAlListBox("Mantenimiento de Sistemas Operativos");
                    ej2.AgregarElementoAlListBox("Comandos de Linux");
                }
            }
            else //Para 2º GMI
            {
                if (listBox1.SelectedIndex == 0)
                {
                    //Muestro el formulario
                    ej2.Show();

                    //Añadir el nombre del profesor
                    ej2.AñadirNombreProfesor("Martín");

                    //Añado el temario con el metodo creado en el form Ejercicio2_Form
                    ej2.AgregarElementoAlListBox("HTML");
                    ej2.AgregarElementoAlListBox("CSS");
                    ej2.AgregarElementoAlListBox("JavaScript");
                    ej2.AgregarElementoAlListBox("PHP");
                    ej2.AgregarElementoAlListBox("MySQL");
                }
                else if (listBox1.SelectedIndex ==1)
                {
                    //Lo muestro
                    ej2.Show();

                    //Añadir el nombre del profesor
                    ej2.AñadirNombreProfesor("Daniel Rivas");

                    //Añado el temario con el metodo creado en el form Ejercicio2_Form
                    ej2.AgregarElementoAlListBox("Presentación");
                    ej2.AgregarElementoAlListBox("Busqueda de empleo");
                    ej2.AgregarElementoAlListBox("Trabajo en grupo");
                    ej2.AgregarElementoAlListBox("Derecho laboral");
                    ej2.AgregarElementoAlListBox("La Nomina");
                    ej2.AgregarElementoAlListBox("Seguridad Social");
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    //Lo muestro
                    ej2.Show();

                    //Añadir el nombre del profesor
                    ej2.AñadirNombreProfesor("Alberto");

                    //Añado el temario con el metodo creado en el form Ejercicio2_Form
                    ej2.AgregarElementoAlListBox("Formación");
                    ej2.AgregarElementoAlListBox("Proyecto de Empresa");
                    ej2.AgregarElementoAlListBox("Prácticas en Empresa");
                }
                else if (listBox1.SelectedIndex == 3)
                {
                    //Lo muestro
                    ej2.Show();

                    //Añadir el nombre del profesor
                    ej2.AñadirNombreProfesor("Francisco Rocha");

                    //Añado el temario con el metodo creado en el form Ejercicio2_Form
                    ej2.AgregarElementoAlListBox("Redes");
                    ej2.AgregarElementoAlListBox("Protocolos");
                    ej2.AgregarElementoAlListBox("Configuración de Redes");
                    ej2.AgregarElementoAlListBox("Seguridad en Redes");
                    ej2.AgregarElementoAlListBox("Servicios en Red");
                }
                else if (listBox1.SelectedIndex == 4)
                {
                    //Lo muestro
                    ej2.Show();

                    //Añadir el nombre del profesor
                    ej2.AñadirNombreProfesor("Enrique Prieto Magán");

                    //Añado el temario con el metodo creado en el form Ejercicio2_Form  
                    ej2.AgregarElementoAlListBox("Sistemas Operativos WINDOWS");
                    ej2.AgregarElementoAlListBox("Sistemas Operativos MAS WINDOWS");
                    ej2.AgregarElementoAlListBox("Sistemas Operativos WINDOWS 10");
                    ej2.AgregarElementoAlListBox("Sistemas Operativos WINDOWS 11");
                    ej2.AgregarElementoAlListBox("Sistemas Operativos WINDOWS 12");
                }

            }
        }
    }
}
