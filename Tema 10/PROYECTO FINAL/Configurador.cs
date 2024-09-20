using System;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class Configurador : Form
    {
        public Configurador()
        {
            InitializeComponent();
        }

        //Variables globales
        int precioTotal = 0;
        int precioProcesador = 0;
        int precioPlacaBase = 0;
        int precioGrafica = 0;
        int precioMemoriaRAM = 0;
        int precioAlmacenamiento = 0;
        int precioSistemaOperativo = 0;

        //Componentes simples
        string memoriaRAM = "";
        string almacenamiento = "";
        string sistemaOperativo = "";
        string marcaProcesador = "";
        string marcaGrafica = "";

        //Tengo que llamarlo porque no es estatico (Si fuese estatico no podria utilziar la lista de componentes)
        MenuPrincipal menu = new MenuPrincipal();

        private void Configurador_Load(object sender, EventArgs e)
        {
            menu.CargarComponentes(); //IMPORTANTISIMO ESTA PARTE, ES NECESARIO CARGARLOS.
            menu.CargarEquipos();
            rdAMD.Checked = true;
            rdAMDG.Checked = true;
        }

        public void procesadoresIntel() //***INTEL***
        {
            cbProcesadores.Items.Clear();
            cbPlacaBase.Items.Clear();
            cbProcesadores.Text = ""; //Corrección 09/09/2024 a las 5:45 (que se note el trabajo duro)
            cbPlacaBase.Text = ""; //Esto tambien
            //Recorrer la lista de componentes y añadir los procesadores al combobox
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("procesador,intel"))
                {
                    //Hacer un split para separar por comas
                    string[] procesadoresIntel = menu.componentes[i].Split(',');
                    cbProcesadores.Items.Add(procesadoresIntel[2]);
                    marcaProcesador = procesadoresIntel[1];
                }
            }

            //Recorrer la lista de componentes y añadir las placas base al combobox
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("placa_base,intel"))
                {
                    //Hacer un split para separar por comas
                    string[] placasBaseIntel = menu.componentes[i].Split(',');
                    cbPlacaBase.Items.Add(placasBaseIntel[2]);
                }
            }
        }

        public void procesadoresAMD() //***AMD***
        {
            cbProcesadores.Items.Clear();
            cbPlacaBase.Items.Clear();
            cbProcesadores.Text = ""; //Aquí lo mismo
            cbPlacaBase.Text = ""; //Hace falta decirlo?
            //Recorrer la lista de componentes y añadir los procesadores al combobox
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("procesador,amd"))
                {
                    //Hacer un split para separar por comas
                    string[] procesadoresAMD = menu.componentes[i].Split(',');
                    cbProcesadores.Items.Add(procesadoresAMD[2]);
                    marcaProcesador = procesadoresAMD[1];
                }
            }

            //Recorrer la lista de componentes y añadir las placas base al combobox
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("placa_base,amd"))
                {
                    //Hacer un split para separar por comas
                    string[] placasBaseAMD = menu.componentes[i].Split(',');
                    cbPlacaBase.Items.Add(placasBaseAMD[2]);
                }
            }
        }

        public void graficasAMD() //***AMDG***
        {
            cbGraficas.Items.Clear();
            //Recorrer la lista de componentes y añadir las graficas al combobox
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("grafica,amd"))
                {
                    //Hacer un split para separar por comas
                    string[] graficasAMD = menu.componentes[i].Split(',');
                    cbGraficas.Items.Add(graficasAMD[2]);
                    marcaGrafica = graficasAMD[1];
                }
            }
        }

        public void graficasNvidia() //***NVIDIA***
        {
            cbGraficas.Items.Clear();
            //Recorrer la lista de componentes y añadir las graficas al combobox
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("grafica,nvidia"))
                {
                    //Hacer un split para separar por comas
                    string[] graficasNvidia = menu.componentes[i].Split(',');
                    cbGraficas.Items.Add(graficasNvidia[2]);
                    marcaGrafica = graficasNvidia[1];
                }
            }
        }

        public void actualizarPrecioProcesador() //Actualizar el precio del procesador y placa base
        {
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("procesador"))
                {
                    string[] procesador = menu.componentes[i].Split(',');
                    if (cbProcesadores.Text == procesador[2])
                    {
                        precioProcesador = Convert.ToInt32(procesador[3]);
                        lblPrecioProcesador.Text = precioProcesador.ToString() + "€";
                    }
                }
            }
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("placa_base"))
                {
                    string[] placaBase = menu.componentes[i].Split(',');
                    if (cbPlacaBase.Text == placaBase[2])
                    {
                        precioPlacaBase = Convert.ToInt32(placaBase[3]);
                        lblPrecioPlacaBase.Text = precioPlacaBase.ToString() + "€";
                    }
                }
            }
        }
        public void actualizarPrecioGrafica() //Actualizar el precio de la gráfica
        {
            for (int i = 0; i < menu.componentes.Count; i++)
            {
                if (menu.componentes[i].Contains("grafica"))
                {
                    string[] grafica = menu.componentes[i].Split(',');
                    if (cbGraficas.Text == grafica[2])
                    {
                        precioGrafica = Convert.ToInt32(grafica[3]);
                        lblPrecioTarjetaGrafica.Text = precioGrafica.ToString() + "€";
                    }
                }
            }
        }

        public void calcularPrecioTotal() //Calcular el precio total cada vez que se realiza una selección
        {
            precioTotal = precioProcesador + precioPlacaBase + precioGrafica + precioMemoriaRAM + precioAlmacenamiento + precioSistemaOperativo;
            txtPrecioTotal.Text = precioTotal.ToString();
        }

        private void rdAMD_CheckedChanged(object sender, EventArgs e)
        {
            procesadoresAMD();       
        }
        private void rdIntel_CheckedChanged(object sender, EventArgs e)
        {
            procesadoresIntel();
        }
        private void cbProcesadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPrecioProcesador();
            calcularPrecioTotal();
        }
        private void cbPlacaBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPrecioProcesador();
            calcularPrecioTotal();
        }
        private void rdAMDG_CheckedChanged(object sender, EventArgs e)
        {
            graficasAMD();
        }
        private void rdNvidia_CheckedChanged(object sender, EventArgs e)
        {
            graficasNvidia();
        }
        private void cbGraficas_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPrecioGrafica();
            calcularPrecioTotal();
        }


        //Zona de selección de componentes simples (Duele no poder optimizarlo)
        private void rd8GB_CheckedChanged(object sender, EventArgs e)
        {
            memoriaRAM = rd8GB.Text;
            precioMemoriaRAM = 21;
            lblPrecioRAM.Text = precioMemoriaRAM.ToString() + "€";
            calcularPrecioTotal();
        }
        private void rd16GB_CheckedChanged(object sender, EventArgs e)
        {
            memoriaRAM = rd16GB.Text;
            precioMemoriaRAM = 42;
            lblPrecioRAM.Text = precioMemoriaRAM.ToString() + "€";
            calcularPrecioTotal();
        }
        private void rd32GB_CheckedChanged(object sender, EventArgs e)
        {
            memoriaRAM = rd32GB.Text;
            precioMemoriaRAM = 84;
            lblPrecioRAM.Text = precioMemoriaRAM.ToString() + "€";
            calcularPrecioTotal();
        }
        private void rd240GB_CheckedChanged(object sender, EventArgs e)
        {
            almacenamiento = rd240GB.Text;
            precioAlmacenamiento = 30;
            lblPrecioAlmacenamiento.Text = precioAlmacenamiento.ToString() + "€";
            calcularPrecioTotal();
        }
        private void rd500GB_CheckedChanged(object sender, EventArgs e)
        {
            almacenamiento = rd500GB.Text;
            precioAlmacenamiento = 50;
            lblPrecioAlmacenamiento.Text = precioAlmacenamiento.ToString() + "€";
            calcularPrecioTotal();
        }
        private void rd1TB_CheckedChanged(object sender, EventArgs e)
        {
            almacenamiento = rd1TB.Text;
            precioAlmacenamiento = 80;
            lblPrecioAlmacenamiento.Text = precioAlmacenamiento.ToString() + "€";
            calcularPrecioTotal();
        }
        private void rd2TB_CheckedChanged(object sender, EventArgs e)
        {
            almacenamiento = rd2TB.Text;
            precioAlmacenamiento = 140;
            lblPrecioAlmacenamiento.Text = precioAlmacenamiento.ToString() + "€";
            calcularPrecioTotal();
        }
        private void rdWindowsHome_CheckedChanged(object sender, EventArgs e)
        {
            sistemaOperativo = rdWindowsHome.Text;
            precioSistemaOperativo = 145;
            lblSistemaOperativo.Text = precioSistemaOperativo.ToString() + "€";
            calcularPrecioTotal();
        }
        private void rdWindowsPro_CheckedChanged(object sender, EventArgs e)
        {
            sistemaOperativo = rdWindowsPro.Text;
            precioSistemaOperativo = 259;
            lblSistemaOperativo.Text = precioSistemaOperativo.ToString() + "€";
            calcularPrecioTotal();
        }
        private void rdUbuntu_CheckedChanged(object sender, EventArgs e)
        {
            sistemaOperativo = rdUbuntu.Text;
            precioSistemaOperativo = 0;
            lblSistemaOperativo.Text = precioSistemaOperativo.ToString() + "€";
            calcularPrecioTotal();
        }
        private void rdFedora_CheckedChanged(object sender, EventArgs e)
        {
            sistemaOperativo = rdFedora.Text;
            precioSistemaOperativo = 0;
            lblSistemaOperativo.Text = precioSistemaOperativo.ToString() + "€";
            calcularPrecioTotal();
        }
        private void LimpiarCampos()
        {
            txtNombreOrdenador.Text = "";
            txtPrecioTotal.Text = "";
            cbProcesadores.Text = "";
            cbPlacaBase.Text = "";
            cbGraficas.Text = "";
            rd8GB.Checked = false;
            rd16GB.Checked = false;
            rd32GB.Checked = false;
            rd240GB.Checked = false;
            rd500GB.Checked = false;
            rd1TB.Checked = false;
            rd2TB.Checked = false;
            rdWindowsHome.Checked = false;
            rdWindowsPro.Checked = false;
            rdUbuntu.Checked = false;
            rdFedora.Checked = false;
            precioPlacaBase = 0;
            precioProcesador = 0;
            precioGrafica = 0;
            precioMemoriaRAM = 0;
            precioAlmacenamiento = 0;
            precioSistemaOperativo = 0;
            precioTotal = 0;
            memoriaRAM = "";
            almacenamiento = "";
            sistemaOperativo = "";
            marcaProcesador = "";
            marcaGrafica = "";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPrecioTotal.Text == "" || cbProcesadores.Text == "" || cbPlacaBase.Text == "" || cbGraficas.Text == "" || memoriaRAM == "" || almacenamiento == "" || sistemaOperativo == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (txtNombreOrdenador.Text.Contains(","))
                {
                    MessageBox.Show("No se pueden introducir comas en el nombre del ordenador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombreOrdenador.Text = "";
                    return;
                }
                else
                {
                    //Comprobar si el nombre del ordenador ya existe
                    for (int i = 0; i < menu.equipos.Count; i++)
                    {
                        string[] equipoNombre = menu.equipos[i].Split(',');
                        if (txtNombreOrdenador.Text == equipoNombre[0])
                        {
                            MessageBox.Show("El nombre introducido ya esta en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    //Guardar el equipo en la Lista de MenuPrincipal
                    menu.equipos.Add(txtNombreOrdenador.Text + "," + marcaProcesador + "," + cbProcesadores.Text + "," + cbPlacaBase.Text + "," + marcaGrafica + "," + cbGraficas.Text + "," + memoriaRAM + "," + almacenamiento + "," + sistemaOperativo + "," + precioTotal);
                    menu.GuardarEquipos();
                    MessageBox.Show("Equipo guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); //Función EXCLUSIVA solo para esta ocasión
                }
            }
        }
    }
}
