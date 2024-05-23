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
            this.cbProcesadores = new System.Windows.Forms.ComboBox();
            this.rdIntel = new System.Windows.Forms.RadioButton();
            this.rdAMD = new System.Windows.Forms.RadioButton();
            this.gbPlacaBase = new System.Windows.Forms.GroupBox();
            this.cbPlacaBase = new System.Windows.Forms.ComboBox();
            this.gbTarjetaGrafica = new System.Windows.Forms.GroupBox();
            this.cbGraficas = new System.Windows.Forms.ComboBox();
            this.rdAMDG = new System.Windows.Forms.RadioButton();
            this.rdNvidia = new System.Windows.Forms.RadioButton();
            this.gbAlmacenamiento = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTOTAL = new System.Windows.Forms.Label();
            this.lblEURO = new System.Windows.Forms.Label();
            this.gbRAM = new System.Windows.Forms.GroupBox();
            this.gbSistemaOperativo = new System.Windows.Forms.GroupBox();
            this.gbProcesador.SuspendLayout();
            this.gbPlacaBase.SuspendLayout();
            this.gbTarjetaGrafica.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProcesador
            // 
            this.gbProcesador.Controls.Add(this.cbProcesadores);
            this.gbProcesador.Controls.Add(this.rdIntel);
            this.gbProcesador.Controls.Add(this.rdAMD);
            this.gbProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProcesador.Location = new System.Drawing.Point(12, 12);
            this.gbProcesador.Name = "gbProcesador";
            this.gbProcesador.Size = new System.Drawing.Size(200, 188);
            this.gbProcesador.TabIndex = 0;
            this.gbProcesador.TabStop = false;
            this.gbProcesador.Text = "Procesador";
            // 
            // cbProcesadores
            // 
            this.cbProcesadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProcesadores.FormattingEnabled = true;
            this.cbProcesadores.Location = new System.Drawing.Point(6, 82);
            this.cbProcesadores.Name = "cbProcesadores";
            this.cbProcesadores.Size = new System.Drawing.Size(188, 28);
            this.cbProcesadores.TabIndex = 2;
            // 
            // rdIntel
            // 
            this.rdIntel.AutoSize = true;
            this.rdIntel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIntel.Location = new System.Drawing.Point(6, 56);
            this.rdIntel.Name = "rdIntel";
            this.rdIntel.Size = new System.Drawing.Size(54, 20);
            this.rdIntel.TabIndex = 1;
            this.rdIntel.TabStop = true;
            this.rdIntel.Text = "Intel";
            this.rdIntel.UseVisualStyleBackColor = true;
            this.rdIntel.CheckedChanged += new System.EventHandler(this.rdIntel_CheckedChanged);
            // 
            // rdAMD
            // 
            this.rdAMD.AutoSize = true;
            this.rdAMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAMD.Location = new System.Drawing.Point(6, 33);
            this.rdAMD.Name = "rdAMD";
            this.rdAMD.Size = new System.Drawing.Size(58, 20);
            this.rdAMD.TabIndex = 0;
            this.rdAMD.TabStop = true;
            this.rdAMD.Text = "AMD";
            this.rdAMD.UseVisualStyleBackColor = true;
            this.rdAMD.CheckedChanged += new System.EventHandler(this.rdAMD_CheckedChanged);
            // 
            // gbPlacaBase
            // 
            this.gbPlacaBase.Controls.Add(this.cbPlacaBase);
            this.gbPlacaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlacaBase.Location = new System.Drawing.Point(218, 12);
            this.gbPlacaBase.Name = "gbPlacaBase";
            this.gbPlacaBase.Size = new System.Drawing.Size(200, 188);
            this.gbPlacaBase.TabIndex = 1;
            this.gbPlacaBase.TabStop = false;
            this.gbPlacaBase.Text = "Placa Base";
            // 
            // cbPlacaBase
            // 
            this.cbPlacaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlacaBase.FormattingEnabled = true;
            this.cbPlacaBase.Location = new System.Drawing.Point(6, 82);
            this.cbPlacaBase.Name = "cbPlacaBase";
            this.cbPlacaBase.Size = new System.Drawing.Size(188, 28);
            this.cbPlacaBase.TabIndex = 3;
            // 
            // gbTarjetaGrafica
            // 
            this.gbTarjetaGrafica.Controls.Add(this.cbGraficas);
            this.gbTarjetaGrafica.Controls.Add(this.rdAMDG);
            this.gbTarjetaGrafica.Controls.Add(this.rdNvidia);
            this.gbTarjetaGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTarjetaGrafica.Location = new System.Drawing.Point(424, 12);
            this.gbTarjetaGrafica.Name = "gbTarjetaGrafica";
            this.gbTarjetaGrafica.Size = new System.Drawing.Size(200, 188);
            this.gbTarjetaGrafica.TabIndex = 2;
            this.gbTarjetaGrafica.TabStop = false;
            this.gbTarjetaGrafica.Text = "Tarjeta Grafica";
            // 
            // cbGraficas
            // 
            this.cbGraficas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGraficas.FormattingEnabled = true;
            this.cbGraficas.Location = new System.Drawing.Point(6, 82);
            this.cbGraficas.Name = "cbGraficas";
            this.cbGraficas.Size = new System.Drawing.Size(188, 28);
            this.cbGraficas.TabIndex = 5;
            // 
            // rdAMDG
            // 
            this.rdAMDG.AutoSize = true;
            this.rdAMDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAMDG.Location = new System.Drawing.Point(6, 33);
            this.rdAMDG.Name = "rdAMDG";
            this.rdAMDG.Size = new System.Drawing.Size(58, 20);
            this.rdAMDG.TabIndex = 4;
            this.rdAMDG.TabStop = true;
            this.rdAMDG.Text = "AMD";
            this.rdAMDG.UseVisualStyleBackColor = true;
            this.rdAMDG.CheckedChanged += new System.EventHandler(this.rdAMDG_CheckedChanged);
            // 
            // rdNvidia
            // 
            this.rdNvidia.AutoSize = true;
            this.rdNvidia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNvidia.Location = new System.Drawing.Point(6, 56);
            this.rdNvidia.Name = "rdNvidia";
            this.rdNvidia.Size = new System.Drawing.Size(70, 20);
            this.rdNvidia.TabIndex = 3;
            this.rdNvidia.TabStop = true;
            this.rdNvidia.Text = "Nvidia";
            this.rdNvidia.UseVisualStyleBackColor = true;
            // 
            // gbAlmacenamiento
            // 
            this.gbAlmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlmacenamiento.Location = new System.Drawing.Point(218, 206);
            this.gbAlmacenamiento.Name = "gbAlmacenamiento";
            this.gbAlmacenamiento.Size = new System.Drawing.Size(200, 188);
            this.gbAlmacenamiento.TabIndex = 3;
            this.gbAlmacenamiento.TabStop = false;
            this.gbAlmacenamiento.Text = "Almacenamiento";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(133, 490);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 4;
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.AutoSize = true;
            this.lblTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOTAL.Location = new System.Drawing.Point(50, 493);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(77, 24);
            this.lblTOTAL.TabIndex = 5;
            this.lblTOTAL.Text = "TOTAL";
            // 
            // lblEURO
            // 
            this.lblEURO.AutoSize = true;
            this.lblEURO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEURO.Location = new System.Drawing.Point(239, 493);
            this.lblEURO.Name = "lblEURO";
            this.lblEURO.Size = new System.Drawing.Size(20, 24);
            this.lblEURO.TabIndex = 6;
            this.lblEURO.Text = "€";
            // 
            // gbRAM
            // 
            this.gbRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRAM.Location = new System.Drawing.Point(12, 206);
            this.gbRAM.Name = "gbRAM";
            this.gbRAM.Size = new System.Drawing.Size(200, 188);
            this.gbRAM.TabIndex = 4;
            this.gbRAM.TabStop = false;
            this.gbRAM.Text = "RAM";
            // 
            // gbSistemaOperativo
            // 
            this.gbSistemaOperativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSistemaOperativo.Location = new System.Drawing.Point(424, 206);
            this.gbSistemaOperativo.Name = "gbSistemaOperativo";
            this.gbSistemaOperativo.Size = new System.Drawing.Size(200, 188);
            this.gbSistemaOperativo.TabIndex = 4;
            this.gbSistemaOperativo.TabStop = false;
            this.gbSistemaOperativo.Text = "Sistema Operativo";
            // 
            // Configurador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.gbSistemaOperativo);
            this.Controls.Add(this.gbRAM);
            this.Controls.Add(this.lblEURO);
            this.Controls.Add(this.lblTOTAL);
            this.Controls.Add(this.textBox1);
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
            this.gbTarjetaGrafica.ResumeLayout(false);
            this.gbTarjetaGrafica.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTOTAL;
        private System.Windows.Forms.Label lblEURO;
        private System.Windows.Forms.GroupBox gbRAM;
        private System.Windows.Forms.GroupBox gbSistemaOperativo;
    }
}