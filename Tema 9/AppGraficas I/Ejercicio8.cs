using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGraficas_I
{
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        

        private void Ejercicio8_Load(object sender, EventArgs e)
        {

        }

        private void txtCajaOperadora_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            //Añadir un cero en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //Añadir un punto en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + ",";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            //Añadir un uno en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Añadir un dos en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            //Añadir un tres en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            //Añadir un cuatro en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            //Añadir un cinco en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            //Añadir un seis en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            //Añadir un siete en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            //Añadir un ocho en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            //Añadir un nueve en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "9";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            //Limpiar la caja de texto
            txtCajaOperadora.Clear();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            //Eliminar el último caracter de la caja de texto
            if (txtCajaOperadora.Text.Length == 1) //Si la caja de texto tiene un solo caracter, elimino TODO (como CE)
            {
                txtCajaOperadora.Text = "";
            }
            else if (txtCajaOperadora.Text.Length == 0) //Si la caja de texto está vacía, no hago nada
            {
                MessageBox.Show("La caja de texto está vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //Si la caja de texto tiene más de un caracter, elimino el último con .Lenght - 1
            {
                txtCajaOperadora.Text = txtCajaOperadora.Text.Remove(txtCajaOperadora.Text.Length - 1);
            }
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            if(txtCajaOperadora.Text == "") //Si la caja de texto está vacía, no hago nada
            {
                //Mensaje de error con icono de advertencia
                MessageBox.Show("La caja de texto está vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);    
            }

            //Forma horrible de hacerlo, si tengo tiempo lo cambiare
            else if (txtCajaOperadora.Text.Contains(",") || txtCajaOperadora.Text.Contains("+") || txtCajaOperadora.Text.Contains("-") || txtCajaOperadora.Text.Contains("/") || txtCajaOperadora.Text.Contains("*") || txtCajaOperadora.Text.Contains("%") == true)
            {
                //Mensaje de error como en las CASIO JAJA
                MessageBox.Show("Syntax ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Pasar a binario

                //**Explicación**

                //Convertir el número de la caja de texto a entero
                long numeroTextBox = Convert.ToInt64(txtCajaOperadora.Text);

                //Convertir el número entero a binario, con un String añadiendo el formato de binario con el "2" al final
                txtCajaOperadora.Text = Convert.ToString(numeroTextBox, 2);

            //Referencia:
            //https://www.techiedelight.com/es/convert-integer-to-binary-csharp/

            }             
        }

        private void btnBarra_Click(object sender, EventArgs e)
        {
            //Añadir un / en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "/";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            //Añadir un - en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "-";
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            //Añadir un * en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "*";
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            //Añadir un + en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "+";
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            //Añadir un % en la caja de texto
            txtCajaOperadora.Text = txtCajaOperadora.Text + "%";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //Si la caja de texto está vacía, no hago nada
            if (txtCajaOperadora.Text == "")
            {
                //No me interesa que salga un error, prefiero que simplemente no haga nada
                //MessageBox.Show("La caja de texto esta vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Eliminar los espacios en blanco puestos por error
                if (txtCajaOperadora.Text.Contains(" ") == true)
                {
                    //Quitar los espacios en blanco con Trim
                    txtCajaOperadora.Text = txtCajaOperadora.Text.Trim();
                }


                //Almacenar los numeros en variables separadas con Split
                List<string> numeros = new List<string>(txtCajaOperadora.Text.Split(new char[] { '+', '-', '*', '/', '%' }));   

                

                //Almacenar los operadores en variables separadas con Split
                List<string> operadores = new List<string>(txtCajaOperadora.Text.Split(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }));

                //Listas para almacenar los números y los operadores (double y char)
                List<double> numerosC = new List<double>();
                List<char> operadoresC = new List<char>();

                //Recorrer los números y los operadores para almacenarlos en las listas
                foreach (string numero in numeros)
                {                  
                        numerosC.Add(double.Parse(numero));                    
                }
                foreach (string operador in operadores)
                {
                    if (!string.IsNullOrWhiteSpace(operador))  //Si el operador no está vacío, añadirlo a la lista
                    {
                        operadoresC.Add(char.Parse(operador));
                    }
                }
                //Con el punto de ruptura despues de muchos errores me di cuenta que añade "" a la lista, preguntar a Ramón porque



                // Realizar las operaciones
                double resultadoFinal = numerosC[0]; // Este es el primer número

                // Comenzar desde el segundo número
                for (int i = 1; i < numerosC.Count; i++)
                {
                    switch (operadoresC[i - 1]) // Aquí, se usa i - 1 para acceder a los operadores (ya que empezamos el for en 1 y si no restamos nos saltamos el primero)
                    {
                        case '+':
                            resultadoFinal += numerosC[i];
                            break;
                        case '-':
                            resultadoFinal -= numerosC[i];
                            break;
                        case '*':
                            resultadoFinal *= numerosC[i];
                            break;
                        case '/':
                            resultadoFinal /= numerosC[i];
                            break;
                        case '%':
                            resultadoFinal %= numerosC[i];
                            break;
                    }
                }


                //Mostrar el resultado en la caja de texto
                txtCajaOperadora.Text = Convert.ToString(resultadoFinal);


            }
        }


        //Inicializo la Memoria
        double memoriaM = 0;
        private void btnMS_Click(object sender, EventArgs e)
        {
            if (txtCajaOperadora.Text == "")
            {
                //Mensaje de error con icono de advertencia
                MessageBox.Show("La caja de texto está vacía", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtCajaOperadora.Text.Contains("+") || txtCajaOperadora.Text.Contains("-") || txtCajaOperadora.Text.Contains("/") || txtCajaOperadora.Text.Contains("*") || txtCajaOperadora.Text.Contains("%") == true)
                {
                    //Mensaje de error
                    MessageBox.Show("Syntax ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Convertir el número de la caja de texto a double
                    memoriaM = Double.Parse(txtCajaOperadora.Text);

                }

            }
            
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            //Mostrar el número de la memoria en la caja de texto
            txtCajaOperadora.Text = Convert.ToString(memoriaM);
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            //Resetear la memoria
            memoriaM = 0;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            //Sumar el número de la caja de texto a la memoria
            memoriaM += Double.Parse(txtCajaOperadora.Text);
        }

        private void btnMMin_Click(object sender, EventArgs e)
        {
            //Restar el número de la caja de texto a la memoria
            memoriaM -= Double.Parse(txtCajaOperadora.Text);
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            //Calcular la raíz cuadrada del número en la caja de texto
            if (txtCajaOperadora.Text == "")
            {
                //No pongo nada
            }
            else
            {
                //Convertir el número de la caja de texto a double
                double numeroRaiz = Double.Parse(txtCajaOperadora.Text);

                //Calcular la raíz cuadrada
                double resultadoRaiz = Math.Sqrt(numeroRaiz);

                //Mostrar el resultado en la caja de texto
                txtCajaOperadora.Text = Convert.ToString(resultadoRaiz);
            }

        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta función no está disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta función no está disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
