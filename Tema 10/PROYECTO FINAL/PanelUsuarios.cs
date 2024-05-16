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

namespace PROYECTO_FINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //*********************************************************
        //*****************Zona de funciones***********************
        //*********************************************************
        public void crearFicheros()
        {
            //Creo el fichero de usuarios
            if (!File.Exists("usuarios.txt"))
            {
                File.Create("usuarios.txt").Close();
            }

            //Creo el fichero de inventario
            if (!File.Exists("inventario.txt"))
            {
                File.Create("inventario.txt").Close();
            }
        }

        public void cargarFicheros()
        {
            //Cargo el fichero de usuarios
            string[] usuarios = File.ReadAllLines("usuarios.txt");

            //Cargo el fichero de inventario
            string[] inventario = File.ReadAllLines("inventario.txt");
        }

        //*********************************************************
        //*********************************************************
        //*********************************************************


        private void Form1_Load(object sender, EventArgs e)
        {
            crearFicheros();
            cargarFicheros();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            //Verifico si el usuario y contraseña son correctos
            
        }

        
    }
}
