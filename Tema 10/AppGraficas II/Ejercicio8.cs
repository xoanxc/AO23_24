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
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }


        private void btnPull_Click(object sender, EventArgs e)
        {
            //Poner en los picturebox las imagenes de forma aleatoria
            Random dados = new Random();
            int dado1 = dados.Next(1, 7);
            int dado2 = dados.Next(1, 7);
            int dado3 = dados.Next(1, 7);
            int dado4 = dados.Next(1, 7);

            //Poner las imagenes en los picturebox
            switch (dado1)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Dado1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Dado2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Dado3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Dado4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.Dado5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.Dado6;
                    break;
            }

            switch (dado2)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.Dado1;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.Dado2;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.Dado3;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources.Dado4;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources.Dado5;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources.Dado6;
                    break;
            }

            switch (dado3)
            {
                case 1:
                    pictureBox3.Image = Properties.Resources.Dado1;
                    break;
                case 2:
                    pictureBox3.Image = Properties.Resources.Dado2;
                    break;
                case 3:
                    pictureBox3.Image = Properties.Resources.Dado3;
                    break;
                case 4:
                    pictureBox3.Image = Properties.Resources.Dado4;
                    break;
                case 5:
                    pictureBox3.Image = Properties.Resources.Dado5;
                    break;
                case 6:
                    pictureBox3.Image = Properties.Resources.Dado6;
                    break;
            }

            switch (dado4)
            {
                case 1:
                    pictureBox4.Image = Properties.Resources.Dado1;
                    break;
                case 2:
                    pictureBox4.Image = Properties.Resources.Dado2;
                    break;
                case 3:
                    pictureBox4.Image = Properties.Resources.Dado3;
                    break;
                case 4:
                    pictureBox4.Image = Properties.Resources.Dado4;
                    break;
                case 5:
                    pictureBox4.Image = Properties.Resources.Dado5;
                    break;
                case 6:
                    pictureBox4.Image = Properties.Resources.Dado6;
                    break;
            }






        }
    }
}
