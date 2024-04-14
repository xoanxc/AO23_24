using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace AppGraficas_I
{
    public partial class Proyecto : Form
    {
        //Creo una lista para guardar los datos de los usuarios y poder usarla en cualquier método
        private List<string> usuarios = new List<string>();

        //Creo función para guardar la ruta del archivo y poder usarla en cualquier método
        private string rutaFichero = Directory.GetCurrentDirectory() + @"\usuarios.txt";


        public Proyecto()
        {
            InitializeComponent(); //Auto-generado, no se que hace

            //Si el archivo existe
            if (File.Exists(rutaFichero))
            {
                //Leer el archivo y almacenar las lineas en un array
                string[] lineas = File.ReadAllLines(rutaFichero);


                //Recorrer las lineas
                foreach (string linea in lineas)
                {
                    //Añadir las lineas a la lista
                    usuarios.Add(linea);
                }
            }
            else
            {
                //Si no existe el archivo, se crea
                File.Create(rutaFichero);
            }

            //****Coloco aquí el código para cargar el primer registro en los campos del formulario****
            //Invesgado en internet, no se si es la mejor forma de hacerlo, creo que esta bastante bien FUNCIONA
        }

        private void Proyecto_Load(object sender, EventArgs e)
        {

            //Si la lista no esta vacia
            if (usuarios.Count > 0)
            {
                //Separar los datos
                string[] datos = usuarios[0].Split(',');

                //Rellenar los campos con los datos
                txtNombreRegistro.Text = datos[0];
                txtApellidosRegistro.Text = datos[1];
                txtEdadRegistro.Text = datos[2];
                txtEmailRegistro.Text = datos[3];
                txtDNIRegistro.Text = datos[4];
            }

        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            //Array letras DNI validación
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            //Validación de campos vacíos
            if (txtNombre.Text == "" || txtApellidos.Text == "" || txtEdad.Text == "" || txtEmail.Text == "" || txtDNI.Text == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos");
            }
            //Validación de la edad
            else if (int.Parse(txtEdad.Text) < 18)
            {
                MessageBox.Show("Debe ser mayor de edad para registrarse");
            }
            //Validar el DNI
            else if (txtDNI.Text.Length != 9)
            {
                MessageBox.Show("DNI no válido");
            }
            //Validad si las 8 primeras posiciones son números
            else if (!txtDNI.Text.Substring(0, 8).All(char.IsDigit))
            {
                MessageBox.Show("DNI no válido");
            }
            //Validar si la última posición es una letra
            else if (!char.IsLetter(txtDNI.Text[8]))
            {
                MessageBox.Show("DNI no válido");
            }
            //Validar si la letra es correcta
            //Me lié un poco con el código, pero lo entiendo
            //Explicación a la matriz/array de letras le doy el resultado de la división de los 8 primeros números del DNI entre 23 y si no coincide con la letra del DNI, no es válido (la letra del DNI esta en la ultima posición, la 8)
            else if (letras[int.Parse(txtDNI.Text.Substring(0, 8)) % 23] != txtDNI.Text[8])
            {
                MessageBox.Show("DNI no válido");
            }
            else if (txtEmail.Text.Contains("@") == false || txtEmail.Text.Contains(".") == false)
            {
                MessageBox.Show("Email no válido");
            }
            //Guardar los datos
            else
            {
                MessageBox.Show("Datos guardados correctamente");

                //Crear la lista para guardar los datos
                List<string> usuarios = new List<string>();


                //Si el archivo existe ****COPIADO DEL CODIGO A LA CARGA DEL FORMULARIO****
                if (File.Exists(rutaFichero))
                {
                    //Leer el archivo y almacenar las lineas en un array
                    string[] lineas = File.ReadAllLines(rutaFichero);


                    //Recorrer las lineas
                    foreach (string linea in lineas)
                    {
                        //Añadir las lineas a la lista
                        usuarios.Add(linea);
                    }
                }
                else
                {
                    //Si no existe el archivo, se crea
                    File.Create(rutaFichero);
                }



                //Guardar los datos en un string y pasarlos a la lista
                string guardar = txtNombre.Text + "," + txtApellidos.Text + "," + txtEdad.Text + "," + txtEmail.Text + "," + txtDNI.Text;
                usuarios.Add(guardar);

                //Actualizar el archivo txt con los nuevos datos
                File.WriteAllLines(rutaFichero, usuarios);
                //File.WriteAllLines escribe un array de string en un archivo de texto, sobreescribiendo el archivo si ya existe (bastante bruto)




                //Limpiar los campos
                txtNombre.Clear();
                txtApellidos.Clear();
                txtEdad.Clear();
                txtEmail.Clear();
                txtDNI.Clear();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Buscar el DNI del textBox en la lista
            string dni = txtDNIEliminar.Text;
            
            for(int i = 0; i < usuarios.Count; i++)
            {
                //Separar los datos
                string[] datos = usuarios[i].Split(',');

                //Si el DNI coincide
                if (datos[4] == dni)
                {
                    //Eliminar el registro
                    usuarios.RemoveAt(i);
                    MessageBox.Show("Registro eliminado correctamente");
                    txtDNIEliminar.Clear();
                    break;
                }
                else
                {
                    MessageBox.Show("DNI no encontrado");
                    txtDNIEliminar.Clear();
                    break;
                }
            }
            //Actualizar el archivo txt con los nuevos datos
            File.WriteAllLines(rutaFichero, usuarios);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Posiciona sobre el primer registro
            if (usuarios.Count > 0)
            {
                //Separar los datos
                string[] datos = usuarios[0].Split(',');

                //Rellenar los campos con los datos
                txtNombreRegistro.Text = datos[0];
                txtApellidosRegistro.Text = datos[1];
                txtEdadRegistro.Text = datos[2];
                txtEmailRegistro.Text = datos[3];
                txtDNIRegistro.Text = datos[4];
            }
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Posiciona sobre el ultimo registro
            if (usuarios.Count > 0)
            {
                //Separar los datos
                string[] datos = usuarios[usuarios.Count -1].Split(','); //usuarios.Count -1 para ir al último registro

                //Rellenar los campos con los datos
                txtNombreRegistro.Text = datos[0];
                txtApellidosRegistro.Text = datos[1];
                txtEdadRegistro.Text = datos[2];
                txtEmailRegistro.Text = datos[3];
                txtDNIRegistro.Text = datos[4];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Posiciona sobre el registro anterior

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Posiciona sobre el siguiente registro

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Buscar el DNI del textBox en la lista
            string dni = txtDNIBuscar.Text;

            //Recorrer la lista
            for (int i = 0; i < usuarios.Count; i++)
            {
                //Separar los datos
                string[] datos = usuarios[i].Split(',');

                //Si el DNI coincide
                if (datos[4] == dni)
                {
                    //Mostrar los datos
                    MessageBox.Show("Usuario encontrado:\n" + datos[0] + " "+ datos[1] + ", " + datos[2] + " años");
                    txtDNIEliminar.Clear();
                    break;
                }
                else
                {
                    //Si no coincide
                    MessageBox.Show("DNI no encontrado");
                    txtDNIEliminar.Clear();
                    break;
                }
            }
        }
    }
}



