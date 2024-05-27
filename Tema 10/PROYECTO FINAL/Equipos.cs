using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class Equipos : Form
    {
        public Equipos()
        {
            InitializeComponent();
        }

        private void Equipos_Load(object sender, EventArgs e)
        {
            //Cargo los equipos en el listbox lbEquipos
            MenuPrincipal menu = new MenuPrincipal();
            menu.CargarEquipos();

            //Cargo los nombres de los equipos
            foreach (string equipo in menu.equipos)
            {
                string[] datos = equipo.Split(',');
                lbEquipos.Items.Add(datos[0]);
            }
        }

        private void lbEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Eliminar el componente seleccionado pero primero se le dice al usuario si esta seguro con un YesNo
            if (lbEquipos.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Estas seguro de que quieres eliminar este equipo?", "Eliminar componente", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.CargarEquipos();

                    //Eliminar el componente seleccionado
                    menu.componentes.RemoveAt(lbEquipos.SelectedIndex);
                    lbEquipos.Items.RemoveAt(lbEquipos.SelectedIndex);

                    //Guardar los cambios
                    menu.GuardarEquipos();
                }
            }

        }
    }
}
