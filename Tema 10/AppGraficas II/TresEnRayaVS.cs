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
    public partial class TresEnRayaVS : Form
    {
        public TresEnRayaVS()
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

        public void comprobarGanador()
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

        //Función para el turno de la máquina aleatoria
        byte turno = 1;
        public void TurnoMaquina()
        {
            Random Gen1 = new Random();

            //Array de botones con Button[]
            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            //Botón aleatorio
            Button randomButton;

            //Buscar casillas vacías y seleccionar una aleatoriamente
            do
            {
                randomButton = buttons[Gen1.Next(0, 9)];
            } while (randomButton.Text != "");

            randomButton.Text = "O"; //Colocar O en la casilla aleatoria
            turno = 1; //Cambiar el turno de vuelta al jugador
        }

        //Función para cambiar el texto de los botones
        public void cambiarTexto(Button boton)
        {
            //Si la casilla está vacía y el turno del jugador es X, colocar X
            if (boton.Text == "" && turno == 1)
            {
                boton.Text = "X";
                turno = 2; //Cambiar turno a la máquina
                comprobarGanador(); //Comprobar si el jugador ganó después de su turno
                TurnoMaquina(); //Turno de la máquina después del jugador
                comprobarGanador(); //Comprobar si la máquina ganó después de su turno
            }
            else if (boton.Text != "")
            {
                MessageBox.Show("Casilla ocupada, MAL");
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

