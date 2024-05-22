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
    public partial class PanelUsuarios : Form
    {
        public PanelUsuarios()
        {
            InitializeComponent();
        }


        //Variables globales
        string usuario = "";
        string contraseña = "";
        bool registrado = false;

        //Listas de usuarios e inventario para todos los formularios
        public static List<string> usuarios = new List<string>();
        public static List<string> inventario = new List<string>();



        private void Form1_Load(object sender, EventArgs e)
        {
            //Creo el fichero de usuarios
            if (!File.Exists("usuarios.txt"))
            {
                File.Create("usuarios.txt").Close();

                //Añado un usuario por defecto
                StreamWriter sw = new StreamWriter("usuarios.txt");
                sw.WriteLine("admin,admin");
                sw.Close();
            }
            else
            {
                //No hago nada
            }

            //Creo el fichero de inventario
            if (!File.Exists("inventario.txt"))
            {
                File.Create("inventario.txt").Close();
            }
            else 
            { 
                //No hago nada
            }

            //Lectura de ficheros
            StreamReader sr = new StreamReader("usuarios.txt");
            string linea = "";
            while ((linea = sr.ReadLine()) != null)
            {
                usuarios.Add(linea);
            }
            sr.Close();

            sr = new StreamReader("inventario.txt");
            linea = "";
            while ((linea = sr.ReadLine()) != null)
            {
                inventario.Add(linea);
            }
            sr.Close();
            

            //Ocultar el campo de contraseña
            txtContraseña.PasswordChar = '*';
            //https://learn.microsoft.com/es-es/dotnet/api/system.windows.forms.textbox.passwordchar?view=windowsdesktop-8.0
        }

        

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            //Verifico si el usuario y contraseña son correctos
            string usuarioAcceso = txtUsuario.Text + "," + txtContraseña.Text;
            
            //Recorro el fichero de usuarios
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i] == usuarioAcceso)
                {                    
                    //Mostrar el formulario de panel de control
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    menuPrincipal.Show();

                    //Cerrar el formulario actual
                    registrado = true; //Variable de control
                    this.Hide();
                }
            }
            if (registrado == false)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");

                //Limpiar los campos de texto
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
            
        }

        
    }
}
