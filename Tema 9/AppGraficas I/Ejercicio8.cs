using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                int numeroTextBox = Convert.ToInt32(txtCajaOperadora.Text);

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
                //Pasar contenido de la textBox a un string
                string resultado = txtCajaOperadora.Text;

                if(resultado.Contains(" ") == true)
                {
                    //Quitar los espacios en blanco con Trim
                    resultado = resultado.Trim();
                }

                //Almacenar los numeros en variables separadas
                string[] numeros = resultado.Split(new char[] { '+', '-', '*', '/', '%' });

                //Almacenar los operadores en variables separadas
                string[] operadores = resultado.Split(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });


                double[] numerosC = new double[numeros.Length];
                char[] operadoresC = new char[operadores.Length];

                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] != "") //Coloco esto, porque al usar Split, me coloca espacios en blanco en el array
                    {
                        numerosC[i] = Convert.ToInt32(numeros[i]);
                    }
                }
                for (int i = 0; i < operadores.Length; i++)
                {
                    if (operadores[i] != "") //Coloco esto, porque al usar Split, me coloca espacios en blanco en el array
                    {
                        operadoresC[i] = Convert.ToChar(operadores[i]);
                    }
                    
                }

                //Realizar las operaciones
                double resultadoFinal = numerosC[0];

                for (int i = 0; i < operadoresC.Length; i++)
                {
                    switch (operadoresC[i])
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
    }
}
