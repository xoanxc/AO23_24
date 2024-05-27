namespace PROYECTO_FINAL
{
    partial class Configurador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurador));
            this.gbProcesador = new System.Windows.Forms.GroupBox();
            this.lblPrecioProcesador = new System.Windows.Forms.Label();
            this.cbProcesadores = new System.Windows.Forms.ComboBox();
            this.rdIntel = new System.Windows.Forms.RadioButton();
            this.rdAMD = new System.Windows.Forms.RadioButton();
            this.gbPlacaBase = new System.Windows.Forms.GroupBox();
            this.lblPrecioPlacaBase = new System.Windows.Forms.Label();
            this.cbPlacaBase = new System.Windows.Forms.ComboBox();
            this.gbTarjetaGrafica = new System.Windows.Forms.GroupBox();
            this.lblPrecioTarjetaGrafica = new System.Windows.Forms.Label();
            this.cbGraficas = new System.Windows.Forms.ComboBox();
            this.rdAMDG = new System.Windows.Forms.RadioButton();
            this.rdNvidia = new System.Windows.Forms.RadioButton();
            this.gbAlmacenamiento = new System.Windows.Forms.GroupBox();
            this.lblPrecioAlmacenamiento = new System.Windows.Forms.Label();
            this.rd2TB = new System.Windows.Forms.RadioButton();
            this.rd1TB = new System.Windows.Forms.RadioButton();
            this.rd240GB = new System.Windows.Forms.RadioButton();
            this.rd500GB = new System.Windows.Forms.RadioButton();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.lblTOTAL = new System.Windows.Forms.Label();
            this.lblEURO = new System.Windows.Forms.Label();
            this.gbRAM = new System.Windows.Forms.GroupBox();
            this.lblPrecioRAM = new System.Windows.Forms.Label();
            this.rd32GB = new System.Windows.Forms.RadioButton();
            this.rd16GB = new System.Windows.Forms.RadioButton();
            this.rd8GB = new System.Windows.Forms.RadioButton();
            this.gbSistemaOperativo = new System.Windows.Forms.GroupBox();
            this.lblSistemaOperativo = new System.Windows.Forms.Label();
            this.rdWindowsPro = new System.Windows.Forms.RadioButton();
            this.rdUbuntu = new System.Windows.Forms.RadioButton();
            this.rdWindowsHome = new System.Windows.Forms.RadioButton();
            this.rdFedora = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombreOrdenador = new System.Windows.Forms.TextBox();
            this.gbProcesador.SuspendLayout();
            this.gbPlacaBase.SuspendLayout();
            this.gbTarjetaGrafica.SuspendLayout();
            this.gbAlmacenamiento.SuspendLayout();
            this.gbRAM.SuspendLayout();
            this.gbSistemaOperativo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProcesador
            // 
            this.gbProcesador.BackColor = System.Drawing.Color.Transparent;
            this.gbProcesador.Controls.Add(this.lblPrecioProcesador);
            this.gbProcesador.Controls.Add(this.cbProcesadores);
            this.gbProcesador.Controls.Add(this.rdIntel);
            this.gbProcesador.Controls.Add(this.rdAMD);
            this.gbProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProcesador.Location = new System.Drawing.Point(12, 12);
            this.gbProcesador.Name = "gbProcesador";
            this.gbProcesador.Size = new System.Drawing.Size(200, 188);
            this.gbProcesador.TabIndex = 0;
            this.gbProcesador.TabStop = false;
            this.gbProcesador.Text = "Procesador";
            // 
            // lblPrecioProcesador
            // 
            this.lblPrecioProcesador.AutoSize = true;
            this.lblPrecioProcesador.Location = new System.Drawing.Point(6, 161);
            this.lblPrecioProcesador.Name = "lblPrecioProcesador";
            this.lblPrecioProcesador.Size = new System.Drawing.Size(32, 24);
            this.lblPrecioProcesador.TabIndex = 3;
            this.lblPrecioProcesador.Text = "0€";
            // 
            // cbProcesadores
            // 
            this.cbProcesadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProcesadores.FormattingEnabled = true;
            this.cbProcesadores.Location = new System.Drawing.Point(6, 95);
            this.cbProcesadores.Name = "cbProcesadores";
            this.cbProcesadores.Size = new System.Drawing.Size(188, 28);
            this.cbProcesadores.TabIndex = 2;
            this.cbProcesadores.SelectedIndexChanged += new System.EventHandler(this.cbProcesadores_SelectedIndexChanged);
            // 
            // rdIntel
            // 
            this.rdIntel.AutoSize = true;
            this.rdIntel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIntel.Location = new System.Drawing.Point(10, 63);
            this.rdIntel.Name = "rdIntel";
            this.rdIntel.Size = new System.Drawing.Size(63, 24);
            this.rdIntel.TabIndex = 1;
            this.rdIntel.TabStop = true;
            this.rdIntel.Text = "Intel";
            this.rdIntel.UseVisualStyleBackColor = true;
            this.rdIntel.CheckedChanged += new System.EventHandler(this.rdIntel_CheckedChanged);
            // 
            // rdAMD
            // 
            this.rdAMD.AutoSize = true;
            this.rdAMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAMD.Location = new System.Drawing.Point(10, 33);
            this.rdAMD.Name = "rdAMD";
            this.rdAMD.Size = new System.Drawing.Size(66, 24);
            this.rdAMD.TabIndex = 0;
            this.rdAMD.TabStop = true;
            this.rdAMD.Text = "AMD";
            this.rdAMD.UseVisualStyleBackColor = true;
            this.rdAMD.CheckedChanged += new System.EventHandler(this.rdAMD_CheckedChanged);
            // 
            // gbPlacaBase
            // 
            this.gbPlacaBase.BackColor = System.Drawing.Color.Transparent;
            this.gbPlacaBase.Controls.Add(this.lblPrecioPlacaBase);
            this.gbPlacaBase.Controls.Add(this.cbPlacaBase);
            this.gbPlacaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlacaBase.Location = new System.Drawing.Point(218, 12);
            this.gbPlacaBase.Name = "gbPlacaBase";
            this.gbPlacaBase.Size = new System.Drawing.Size(200, 188);
            this.gbPlacaBase.TabIndex = 1;
            this.gbPlacaBase.TabStop = false;
            this.gbPlacaBase.Text = "Placa Base";
            // 
            // lblPrecioPlacaBase
            // 
            this.lblPrecioPlacaBase.AutoSize = true;
            this.lblPrecioPlacaBase.Location = new System.Drawing.Point(6, 160);
            this.lblPrecioPlacaBase.Name = "lblPrecioPlacaBase";
            this.lblPrecioPlacaBase.Size = new System.Drawing.Size(32, 24);
            this.lblPrecioPlacaBase.TabIndex = 4;
            this.lblPrecioPlacaBase.Text = "0€";
            // 
            // cbPlacaBase
            // 
            this.cbPlacaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlacaBase.FormattingEnabled = true;
            this.cbPlacaBase.Location = new System.Drawing.Point(6, 95);
            this.cbPlacaBase.Name = "cbPlacaBase";
            this.cbPlacaBase.Size = new System.Drawing.Size(188, 28);
            this.cbPlacaBase.TabIndex = 3;
            this.cbPlacaBase.SelectedIndexChanged += new System.EventHandler(this.cbPlacaBase_SelectedIndexChanged);
            // 
            // gbTarjetaGrafica
            // 
            this.gbTarjetaGrafica.BackColor = System.Drawing.Color.Transparent;
            this.gbTarjetaGrafica.Controls.Add(this.lblPrecioTarjetaGrafica);
            this.gbTarjetaGrafica.Controls.Add(this.cbGraficas);
            this.gbTarjetaGrafica.Controls.Add(this.rdAMDG);
            this.gbTarjetaGrafica.Controls.Add(this.rdNvidia);
            this.gbTarjetaGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTarjetaGrafica.Location = new System.Drawing.Point(424, 12);
            this.gbTarjetaGrafica.Name = "gbTarjetaGrafica";
            this.gbTarjetaGrafica.Size = new System.Drawing.Size(200, 188);
            this.gbTarjetaGrafica.TabIndex = 2;
            this.gbTarjetaGrafica.TabStop = false;
            this.gbTarjetaGrafica.Text = "Tarjeta Grafica";
            // 
            // lblPrecioTarjetaGrafica
            // 
            this.lblPrecioTarjetaGrafica.AutoSize = true;
            this.lblPrecioTarjetaGrafica.Location = new System.Drawing.Point(6, 160);
            this.lblPrecioTarjetaGrafica.Name = "lblPrecioTarjetaGrafica";
            this.lblPrecioTarjetaGrafica.Size = new System.Drawing.Size(32, 24);
            this.lblPrecioTarjetaGrafica.TabIndex = 5;
            this.lblPrecioTarjetaGrafica.Text = "0€";
            // 
            // cbGraficas
            // 
            this.cbGraficas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGraficas.FormattingEnabled = true;
            this.cbGraficas.Location = new System.Drawing.Point(7, 95);
            this.cbGraficas.Name = "cbGraficas";
            this.cbGraficas.Size = new System.Drawing.Size(188, 28);
            this.cbGraficas.TabIndex = 5;
            this.cbGraficas.SelectedIndexChanged += new System.EventHandler(this.cbGraficas_SelectedIndexChanged);
            // 
            // rdAMDG
            // 
            this.rdAMDG.AutoSize = true;
            this.rdAMDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAMDG.Location = new System.Drawing.Point(10, 33);
            this.rdAMDG.Name = "rdAMDG";
            this.rdAMDG.Size = new System.Drawing.Size(66, 24);
            this.rdAMDG.TabIndex = 4;
            this.rdAMDG.TabStop = true;
            this.rdAMDG.Text = "AMD";
            this.rdAMDG.UseVisualStyleBackColor = true;
            this.rdAMDG.CheckedChanged += new System.EventHandler(this.rdAMDG_CheckedChanged);
            // 
            // rdNvidia
            // 
            this.rdNvidia.AutoSize = true;
            this.rdNvidia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNvidia.Location = new System.Drawing.Point(10, 63);
            this.rdNvidia.Name = "rdNvidia";
            this.rdNvidia.Size = new System.Drawing.Size(75, 24);
            this.rdNvidia.TabIndex = 3;
            this.rdNvidia.TabStop = true;
            this.rdNvidia.Text = "Nvidia";
            this.rdNvidia.UseVisualStyleBackColor = true;
            this.rdNvidia.CheckedChanged += new System.EventHandler(this.rdNvidia_CheckedChanged);
            // 
            // gbAlmacenamiento
            // 
            this.gbAlmacenamiento.BackColor = System.Drawing.Color.Transparent;
            this.gbAlmacenamiento.Controls.Add(this.lblPrecioAlmacenamiento);
            this.gbAlmacenamiento.Controls.Add(this.rd2TB);
            this.gbAlmacenamiento.Controls.Add(this.rd1TB);
            this.gbAlmacenamiento.Controls.Add(this.rd240GB);
            this.gbAlmacenamiento.Controls.Add(this.rd500GB);
            this.gbAlmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlmacenamiento.Location = new System.Drawing.Point(218, 206);
            this.gbAlmacenamiento.Name = "gbAlmacenamiento";
            this.gbAlmacenamiento.Size = new System.Drawing.Size(200, 210);
            this.gbAlmacenamiento.TabIndex = 3;
            this.gbAlmacenamiento.TabStop = false;
            this.gbAlmacenamiento.Text = "Almacenamiento";
            // 
            // lblPrecioAlmacenamiento
            // 
            this.lblPrecioAlmacenamiento.AutoSize = true;
            this.lblPrecioAlmacenamiento.Location = new System.Drawing.Point(6, 183);
            this.lblPrecioAlmacenamiento.Name = "lblPrecioAlmacenamiento";
            this.lblPrecioAlmacenamiento.Size = new System.Drawing.Size(32, 24);
            this.lblPrecioAlmacenamiento.TabIndex = 6;
            this.lblPrecioAlmacenamiento.Text = "0€";
            // 
            // rd2TB
            // 
            this.rd2TB.AutoSize = true;
            this.rd2TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2TB.Location = new System.Drawing.Point(10, 138);
            this.rd2TB.Margin = new System.Windows.Forms.Padding(2);
            this.rd2TB.Name = "rd2TB";
            this.rd2TB.Size = new System.Drawing.Size(59, 24);
            this.rd2TB.TabIndex = 6;
            this.rd2TB.TabStop = true;
            this.rd2TB.Text = "2TB";
            this.rd2TB.UseVisualStyleBackColor = true;
            this.rd2TB.CheckedChanged += new System.EventHandler(this.rd2TB_CheckedChanged);
            // 
            // rd1TB
            // 
            this.rd1TB.AutoSize = true;
            this.rd1TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1TB.Location = new System.Drawing.Point(10, 106);
            this.rd1TB.Margin = new System.Windows.Forms.Padding(2);
            this.rd1TB.Name = "rd1TB";
            this.rd1TB.Size = new System.Drawing.Size(59, 24);
            this.rd1TB.TabIndex = 5;
            this.rd1TB.TabStop = true;
            this.rd1TB.Text = "1TB";
            this.rd1TB.UseVisualStyleBackColor = true;
            this.rd1TB.CheckedChanged += new System.EventHandler(this.rd1TB_CheckedChanged);
            // 
            // rd240GB
            // 
            this.rd240GB.AutoSize = true;
            this.rd240GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd240GB.Location = new System.Drawing.Point(10, 42);
            this.rd240GB.Margin = new System.Windows.Forms.Padding(2);
            this.rd240GB.Name = "rd240GB";
            this.rd240GB.Size = new System.Drawing.Size(83, 24);
            this.rd240GB.TabIndex = 3;
            this.rd240GB.TabStop = true;
            this.rd240GB.Text = "240GB";
            this.rd240GB.UseVisualStyleBackColor = true;
            this.rd240GB.CheckedChanged += new System.EventHandler(this.rd240GB_CheckedChanged);
            // 
            // rd500GB
            // 
            this.rd500GB.AutoSize = true;
            this.rd500GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd500GB.Location = new System.Drawing.Point(10, 74);
            this.rd500GB.Margin = new System.Windows.Forms.Padding(2);
            this.rd500GB.Name = "rd500GB";
            this.rd500GB.Size = new System.Drawing.Size(83, 24);
            this.rd500GB.TabIndex = 4;
            this.rd500GB.TabStop = true;
            this.rd500GB.Text = "500GB";
            this.rd500GB.UseVisualStyleBackColor = true;
            this.rd500GB.CheckedChanged += new System.EventHandler(this.rd500GB_CheckedChanged);
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioTotal.Location = new System.Drawing.Point(121, 444);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(100, 35);
            this.txtPrecioTotal.TabIndex = 4;
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.AutoSize = true;
            this.lblTOTAL.BackColor = System.Drawing.Color.Transparent;
            this.lblTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOTAL.Location = new System.Drawing.Point(18, 447);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(97, 29);
            this.lblTOTAL.TabIndex = 5;
            this.lblTOTAL.Text = "TOTAL";
            // 
            // lblEURO
            // 
            this.lblEURO.AutoSize = true;
            this.lblEURO.BackColor = System.Drawing.Color.Transparent;
            this.lblEURO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEURO.Location = new System.Drawing.Point(227, 447);
            this.lblEURO.Name = "lblEURO";
            this.lblEURO.Size = new System.Drawing.Size(26, 29);
            this.lblEURO.TabIndex = 6;
            this.lblEURO.Text = "€";
            // 
            // gbRAM
            // 
            this.gbRAM.BackColor = System.Drawing.Color.Transparent;
            this.gbRAM.Controls.Add(this.lblPrecioRAM);
            this.gbRAM.Controls.Add(this.rd32GB);
            this.gbRAM.Controls.Add(this.rd16GB);
            this.gbRAM.Controls.Add(this.rd8GB);
            this.gbRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRAM.Location = new System.Drawing.Point(12, 206);
            this.gbRAM.Name = "gbRAM";
            this.gbRAM.Size = new System.Drawing.Size(200, 210);
            this.gbRAM.TabIndex = 4;
            this.gbRAM.TabStop = false;
            this.gbRAM.Text = "RAM";
            // 
            // lblPrecioRAM
            // 
            this.lblPrecioRAM.AutoSize = true;
            this.lblPrecioRAM.Location = new System.Drawing.Point(6, 183);
            this.lblPrecioRAM.Name = "lblPrecioRAM";
            this.lblPrecioRAM.Size = new System.Drawing.Size(32, 24);
            this.lblPrecioRAM.TabIndex = 6;
            this.lblPrecioRAM.Text = "0€";
            // 
            // rd32GB
            // 
            this.rd32GB.AutoSize = true;
            this.rd32GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd32GB.Location = new System.Drawing.Point(10, 106);
            this.rd32GB.Margin = new System.Windows.Forms.Padding(2);
            this.rd32GB.Name = "rd32GB";
            this.rd32GB.Size = new System.Drawing.Size(73, 24);
            this.rd32GB.TabIndex = 2;
            this.rd32GB.TabStop = true;
            this.rd32GB.Text = "32GB";
            this.rd32GB.UseVisualStyleBackColor = true;
            this.rd32GB.CheckedChanged += new System.EventHandler(this.rd32GB_CheckedChanged);
            // 
            // rd16GB
            // 
            this.rd16GB.AutoSize = true;
            this.rd16GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd16GB.Location = new System.Drawing.Point(10, 74);
            this.rd16GB.Margin = new System.Windows.Forms.Padding(2);
            this.rd16GB.Name = "rd16GB";
            this.rd16GB.Size = new System.Drawing.Size(73, 24);
            this.rd16GB.TabIndex = 1;
            this.rd16GB.TabStop = true;
            this.rd16GB.Text = "16GB";
            this.rd16GB.UseVisualStyleBackColor = true;
            this.rd16GB.CheckedChanged += new System.EventHandler(this.rd16GB_CheckedChanged);
            // 
            // rd8GB
            // 
            this.rd8GB.AutoSize = true;
            this.rd8GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd8GB.Location = new System.Drawing.Point(10, 42);
            this.rd8GB.Margin = new System.Windows.Forms.Padding(2);
            this.rd8GB.Name = "rd8GB";
            this.rd8GB.Size = new System.Drawing.Size(63, 24);
            this.rd8GB.TabIndex = 0;
            this.rd8GB.TabStop = true;
            this.rd8GB.Text = "8GB";
            this.rd8GB.UseVisualStyleBackColor = true;
            this.rd8GB.CheckedChanged += new System.EventHandler(this.rd8GB_CheckedChanged);
            // 
            // gbSistemaOperativo
            // 
            this.gbSistemaOperativo.BackColor = System.Drawing.Color.Transparent;
            this.gbSistemaOperativo.Controls.Add(this.lblSistemaOperativo);
            this.gbSistemaOperativo.Controls.Add(this.rdWindowsPro);
            this.gbSistemaOperativo.Controls.Add(this.rdUbuntu);
            this.gbSistemaOperativo.Controls.Add(this.rdWindowsHome);
            this.gbSistemaOperativo.Controls.Add(this.rdFedora);
            this.gbSistemaOperativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSistemaOperativo.Location = new System.Drawing.Point(424, 206);
            this.gbSistemaOperativo.Name = "gbSistemaOperativo";
            this.gbSistemaOperativo.Size = new System.Drawing.Size(200, 210);
            this.gbSistemaOperativo.TabIndex = 4;
            this.gbSistemaOperativo.TabStop = false;
            this.gbSistemaOperativo.Text = "Sistema Operativo";
            // 
            // lblSistemaOperativo
            // 
            this.lblSistemaOperativo.AutoSize = true;
            this.lblSistemaOperativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaOperativo.Location = new System.Drawing.Point(6, 183);
            this.lblSistemaOperativo.Name = "lblSistemaOperativo";
            this.lblSistemaOperativo.Size = new System.Drawing.Size(32, 24);
            this.lblSistemaOperativo.TabIndex = 7;
            this.lblSistemaOperativo.Text = "0€";
            // 
            // rdWindowsPro
            // 
            this.rdWindowsPro.AutoSize = true;
            this.rdWindowsPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdWindowsPro.Location = new System.Drawing.Point(10, 74);
            this.rdWindowsPro.Name = "rdWindowsPro";
            this.rdWindowsPro.Size = new System.Drawing.Size(155, 24);
            this.rdWindowsPro.TabIndex = 9;
            this.rdWindowsPro.TabStop = true;
            this.rdWindowsPro.Text = "Windows 11 Pro";
            this.rdWindowsPro.UseVisualStyleBackColor = true;
            this.rdWindowsPro.CheckedChanged += new System.EventHandler(this.rdWindowsPro_CheckedChanged);
            // 
            // rdUbuntu
            // 
            this.rdUbuntu.AutoSize = true;
            this.rdUbuntu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdUbuntu.Location = new System.Drawing.Point(10, 106);
            this.rdUbuntu.Name = "rdUbuntu";
            this.rdUbuntu.Size = new System.Drawing.Size(86, 24);
            this.rdUbuntu.TabIndex = 8;
            this.rdUbuntu.TabStop = true;
            this.rdUbuntu.Text = "Ubuntu";
            this.rdUbuntu.UseVisualStyleBackColor = true;
            this.rdUbuntu.CheckedChanged += new System.EventHandler(this.rdUbuntu_CheckedChanged);
            // 
            // rdWindowsHome
            // 
            this.rdWindowsHome.AutoSize = true;
            this.rdWindowsHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdWindowsHome.Location = new System.Drawing.Point(10, 42);
            this.rdWindowsHome.Name = "rdWindowsHome";
            this.rdWindowsHome.Size = new System.Drawing.Size(175, 24);
            this.rdWindowsHome.TabIndex = 7;
            this.rdWindowsHome.TabStop = true;
            this.rdWindowsHome.Text = "Windows 11 Home";
            this.rdWindowsHome.UseVisualStyleBackColor = true;
            this.rdWindowsHome.CheckedChanged += new System.EventHandler(this.rdWindowsHome_CheckedChanged);
            // 
            // rdFedora
            // 
            this.rdFedora.AutoSize = true;
            this.rdFedora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFedora.Location = new System.Drawing.Point(10, 138);
            this.rdFedora.Name = "rdFedora";
            this.rdFedora.Size = new System.Drawing.Size(84, 24);
            this.rdFedora.TabIndex = 6;
            this.rdFedora.TabStop = true;
            this.rdFedora.Text = "Fedora";
            this.rdFedora.UseVisualStyleBackColor = true;
            this.rdFedora.CheckedChanged += new System.EventHandler(this.rdFedora_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(454, 442);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 46);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombreOrdenador
            // 
            this.txtNombreOrdenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreOrdenador.Location = new System.Drawing.Point(307, 450);
            this.txtNombreOrdenador.Name = "txtNombreOrdenador";
            this.txtNombreOrdenador.Size = new System.Drawing.Size(142, 26);
            this.txtNombreOrdenador.TabIndex = 8;
            // 
            // Configurador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.Background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 508);
            this.Controls.Add(this.txtNombreOrdenador);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbSistemaOperativo);
            this.Controls.Add(this.gbRAM);
            this.Controls.Add(this.lblEURO);
            this.Controls.Add(this.lblTOTAL);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.gbAlmacenamiento);
            this.Controls.Add(this.gbTarjetaGrafica);
            this.Controls.Add(this.gbPlacaBase);
            this.Controls.Add(this.gbProcesador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Configurador";
            this.Text = "Configurador";
            this.Load += new System.EventHandler(this.Configurador_Load);
            this.gbProcesador.ResumeLayout(false);
            this.gbProcesador.PerformLayout();
            this.gbPlacaBase.ResumeLayout(false);
            this.gbPlacaBase.PerformLayout();
            this.gbTarjetaGrafica.ResumeLayout(false);
            this.gbTarjetaGrafica.PerformLayout();
            this.gbAlmacenamiento.ResumeLayout(false);
            this.gbAlmacenamiento.PerformLayout();
            this.gbRAM.ResumeLayout(false);
            this.gbRAM.PerformLayout();
            this.gbSistemaOperativo.ResumeLayout(false);
            this.gbSistemaOperativo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProcesador;
        private System.Windows.Forms.ComboBox cbProcesadores;
        private System.Windows.Forms.RadioButton rdIntel;
        private System.Windows.Forms.RadioButton rdAMD;
        private System.Windows.Forms.GroupBox gbPlacaBase;
        private System.Windows.Forms.GroupBox gbTarjetaGrafica;
        private System.Windows.Forms.GroupBox gbAlmacenamiento;
        private System.Windows.Forms.ComboBox cbPlacaBase;
        private System.Windows.Forms.ComboBox cbGraficas;
        private System.Windows.Forms.RadioButton rdAMDG;
        private System.Windows.Forms.RadioButton rdNvidia;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.Label lblTOTAL;
        private System.Windows.Forms.Label lblEURO;
        private System.Windows.Forms.GroupBox gbRAM;
        private System.Windows.Forms.GroupBox gbSistemaOperativo;
        private System.Windows.Forms.RadioButton rd32GB;
        private System.Windows.Forms.RadioButton rd16GB;
        private System.Windows.Forms.RadioButton rd8GB;
        private System.Windows.Forms.RadioButton rd2TB;
        private System.Windows.Forms.RadioButton rd1TB;
        private System.Windows.Forms.RadioButton rd240GB;
        private System.Windows.Forms.RadioButton rd500GB;
        private System.Windows.Forms.RadioButton rdWindowsPro;
        private System.Windows.Forms.RadioButton rdUbuntu;
        private System.Windows.Forms.RadioButton rdWindowsHome;
        private System.Windows.Forms.RadioButton rdFedora;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblPrecioProcesador;
        private System.Windows.Forms.Label lblPrecioPlacaBase;
        private System.Windows.Forms.Label lblPrecioTarjetaGrafica;
        private System.Windows.Forms.Label lblPrecioAlmacenamiento;
        private System.Windows.Forms.Label lblPrecioRAM;
        private System.Windows.Forms.Label lblSistemaOperativo;
        private System.Windows.Forms.TextBox txtNombreOrdenador;
    }
}