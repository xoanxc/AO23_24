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
    public partial class TresEnRaya : Form
    {
        public TresEnRaya()
        {
            InitializeComponent();
        }

        //Funcion para reiniciar el juego
        public void reiniciarJuego()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        public void comprobarGanador ()
        {
            //Comprobar si hay un ganador

            //Primera fila
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Ganador: X");
                reiniciarJuego();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Ganador: O");
                reiniciarJuego();
            }

            //Segunda fila
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("Ganador: X");
                reiniciarJuego();
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("Ganador: O");
                reiniciarJuego();
            }
            
            //Tercera fila
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Ganador: X");
                reiniciarJuego();
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Ganador: O");
                reiniciarJuego();
            }

            //Primera columna
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Ganador: X");
                reiniciarJuego();
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Ganador: O");
                reiniciarJuego();
            }

            //Segunda columna
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("Ganador: X");
                reiniciarJuego();
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("Ganador: O");
                reiniciarJuego();
            }

            //Tercera columna
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Ganador: X");
                reiniciarJuego();
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Ganador: O");
                reiniciarJuego();
            }

            //Diagonal 1
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Ganador: X");
                reiniciarJuego();
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Ganador: O");
                reiniciarJuego();
            }

            //Diagonal 2
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Ganador: X");
                reiniciarJuego();
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Ganador: O");
                reiniciarJuego();
            }

            //Empate
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Empate");
                reiniciarJuego();
            }
        }

        //Funcion para cambiar el texto de los botones
        byte turno = 1;
        public void cambiarTexto(Button boton)
        {
            //Elegir 1 o 2 jugadores
            if (rd1JUGADOR.Checked)
            {
                //Dos jugadores
                if (boton.Text == "")
                {


                    if (turno == 1)
                    {
                        boton.Text = "X";
                        turno = 2;
                    }
                    else
                    {
                        boton.Text = "O";
                        turno = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Casilla ocupada");
                }
            }
            else if (rd2JUGADORES.Checked)
            {
                if (turno == 1)
                {
                    boton.Text = "X";
                    turno = 2;
                }
                else
                {
                    //Selecciona una casilla aleatoria disponible
                    Random Gen1 = new Random();
                    int casilla;
                    do
                    {
                        casilla = Gen1.Next(1, 10);
                    } while (Controls["button" + casilla].Text != ""); //Controla que la casilla esta vacia y añade button + el numero de la casilla

                    Button casillaBoton = (Button)Controls["button" + casilla]; //Introduce el boton en la variable casillaBoton
                    casillaBoton.Text = "O";

                    turno = 1; //Pasa el turno al jugador
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cambiarTexto(button1);
            comprobarGanador();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cambiarTexto(button2);
            comprobarGanador();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cambiarTexto(button3);
            comprobarGanador();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cambiarTexto(button4);
            comprobarGanador();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cambiarTexto(button5);
            comprobarGanador();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cambiarTexto(button6);
            comprobarGanador();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cambiarTexto(button7);
            comprobarGanador();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cambiarTexto(button8);
            comprobarGanador();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cambiarTexto(button9);
            comprobarGanador();
        }
    }
}
