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
            this.rd8GB = new System.Windows.Forms.RadioButton();
            this.rd16GB = new System.Windows.Forms.RadioButton();
            this.rd32GB = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
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
            this.gbProcesador.BackColor = System.Drawing.SystemColors.Control;
            this.gbProcesador.Controls.Add(this.cbProcesadores);
            this.gbProcesador.Controls.Add(this.rdIntel);
            this.gbProcesador.Controls.Add(this.rdAMD);
            this.gbProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProcesador.Location = new System.Drawing.Point(16, 15);
            this.gbProcesador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbProcesador.Name = "gbProcesador";
            this.gbProcesador.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbProcesador.Size = new System.Drawing.Size(267, 231);
            this.gbProcesador.TabIndex = 0;
            this.gbProcesador.TabStop = false;
            this.gbProcesador.Text = "Procesador";
            // 
            // cbProcesadores
            // 
            this.cbProcesadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProcesadores.FormattingEnabled = true;
            this.cbProcesadores.Location = new System.Drawing.Point(8, 101);
            this.cbProcesadores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProcesadores.Name = "cbProcesadores";
            this.cbProcesadores.Size = new System.Drawing.Size(249, 33);
            this.cbProcesadores.TabIndex = 2;
            // 
            // rdIntel
            // 
            this.rdIntel.AutoSize = true;
            this.rdIntel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIntel.Location = new System.Drawing.Point(8, 69);
            this.rdIntel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdIntel.Name = "rdIntel";
            this.rdIntel.Size = new System.Drawing.Size(66, 24);
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
            this.rdAMD.Location = new System.Drawing.Point(8, 41);
            this.rdAMD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdAMD.Name = "rdAMD";
            this.rdAMD.Size = new System.Drawing.Size(71, 24);
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
            this.gbPlacaBase.Location = new System.Drawing.Point(291, 15);
            this.gbPlacaBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPlacaBase.Name = "gbPlacaBase";
            this.gbPlacaBase.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPlacaBase.Size = new System.Drawing.Size(267, 231);
            this.gbPlacaBase.TabIndex = 1;
            this.gbPlacaBase.TabStop = false;
            this.gbPlacaBase.Text = "Placa Base";
            // 
            // cbPlacaBase
            // 
            this.cbPlacaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlacaBase.FormattingEnabled = true;
            this.cbPlacaBase.Location = new System.Drawing.Point(8, 101);
            this.cbPlacaBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPlacaBase.Name = "cbPlacaBase";
            this.cbPlacaBase.Size = new System.Drawing.Size(249, 33);
            this.cbPlacaBase.TabIndex = 3;
            // 
            // gbTarjetaGrafica
            // 
            this.gbTarjetaGrafica.Controls.Add(this.cbGraficas);
            this.gbTarjetaGrafica.Controls.Add(this.rdAMDG);
            this.gbTarjetaGrafica.Controls.Add(this.rdNvidia);
            this.gbTarjetaGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTarjetaGrafica.Location = new System.Drawing.Point(565, 15);
            this.gbTarjetaGrafica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTarjetaGrafica.Name = "gbTarjetaGrafica";
            this.gbTarjetaGrafica.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTarjetaGrafica.Size = new System.Drawing.Size(267, 231);
            this.gbTarjetaGrafica.TabIndex = 2;
            this.gbTarjetaGrafica.TabStop = false;
            this.gbTarjetaGrafica.Text = "Tarjeta Grafica";
            // 
            // cbGraficas
            // 
            this.cbGraficas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGraficas.FormattingEnabled = true;
            this.cbGraficas.Location = new System.Drawing.Point(8, 101);
            this.cbGraficas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGraficas.Name = "cbGraficas";
            this.cbGraficas.Size = new System.Drawing.Size(249, 33);
            this.cbGraficas.TabIndex = 5;
            // 
            // rdAMDG
            // 
            this.rdAMDG.AutoSize = true;
            this.rdAMDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAMDG.Location = new System.Drawing.Point(8, 41);
            this.rdAMDG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdAMDG.Name = "rdAMDG";
            this.rdAMDG.Size = new System.Drawing.Size(71, 24);
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
            this.rdNvidia.Location = new System.Drawing.Point(8, 69);
            this.rdNvidia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdNvidia.Name = "rdNvidia";
            this.rdNvidia.Size = new System.Drawing.Size(82, 24);
            this.rdNvidia.TabIndex = 3;
            this.rdNvidia.TabStop = true;
            this.rdNvidia.Text = "Nvidia";
            this.rdNvidia.UseVisualStyleBackColor = true;
            this.rdNvidia.CheckedChanged += new System.EventHandler(this.rdNvidia_CheckedChanged);
            // 
            // gbAlmacenamiento
            // 
            this.gbAlmacenamiento.Controls.Add(this.radioButton4);
            this.gbAlmacenamiento.Controls.Add(this.radioButton1);
            this.gbAlmacenamiento.Controls.Add(this.radioButton3);
            this.gbAlmacenamiento.Controls.Add(this.radioButton2);
            this.gbAlmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlmacenamiento.Location = new System.Drawing.Point(291, 254);
            this.gbAlmacenamiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAlmacenamiento.Name = "gbAlmacenamiento";
            this.gbAlmacenamiento.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAlmacenamiento.Size = new System.Drawing.Size(267, 231);
            this.gbAlmacenamiento.TabIndex = 3;
            this.gbAlmacenamiento.TabStop = false;
            this.gbAlmacenamiento.Text = "Almacenamiento";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(166, 531);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 34);
            this.textBox1.TabIndex = 4;
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.AutoSize = true;
            this.lblTOTAL.BackColor = System.Drawing.Color.Transparent;
            this.lblTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOTAL.Location = new System.Drawing.Point(56, 535);
            this.lblTOTAL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(97, 29);
            this.lblTOTAL.TabIndex = 5;
            this.lblTOTAL.Text = "TOTAL";
            // 
            // lblEURO
            // 
            this.lblEURO.AutoSize = true;
            this.lblEURO.BackColor = System.Drawing.Color.Transparent;
            this.lblEURO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEURO.Location = new System.Drawing.Point(308, 535);
            this.lblEURO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEURO.Name = "lblEURO";
            this.lblEURO.Size = new System.Drawing.Size(26, 29);
            this.lblEURO.TabIndex = 6;
            this.lblEURO.Text = "€";
            // 
            // gbRAM
            // 
            this.gbRAM.Controls.Add(this.rd32GB);
            this.gbRAM.Controls.Add(this.rd16GB);
            this.gbRAM.Controls.Add(this.rd8GB);
            this.gbRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRAM.Location = new System.Drawing.Point(16, 254);
            this.gbRAM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRAM.Name = "gbRAM";
            this.gbRAM.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbRAM.Size = new System.Drawing.Size(267, 231);
            this.gbRAM.TabIndex = 4;
            this.gbRAM.TabStop = false;
            this.gbRAM.Text = "RAM";
            // 
            // gbSistemaOperativo
            // 
            this.gbSistemaOperativo.BackColor = System.Drawing.SystemColors.Control;
            this.gbSistemaOperativo.Controls.Add(this.radioButton7);
            this.gbSistemaOperativo.Controls.Add(this.radioButton8);
            this.gbSistemaOperativo.Controls.Add(this.radioButton5);
            this.gbSistemaOperativo.Controls.Add(this.radioButton6);
            this.gbSistemaOperativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSistemaOperativo.Location = new System.Drawing.Point(565, 254);
            this.gbSistemaOperativo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSistemaOperativo.Name = "gbSistemaOperativo";
            this.gbSistemaOperativo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSistemaOperativo.Size = new System.Drawing.Size(267, 231);
            this.gbSistemaOperativo.TabIndex = 4;
            this.gbSistemaOperativo.TabStop = false;
            this.gbSistemaOperativo.Text = "Sistema Operativo";
            // 
            // rd8GB
            // 
            this.rd8GB.AutoSize = true;
            this.rd8GB.Location = new System.Drawing.Point(8, 52);
            this.rd8GB.Name = "rd8GB";
            this.rd8GB.Size = new System.Drawing.Size(75, 29);
            this.rd8GB.TabIndex = 0;
            this.rd8GB.TabStop = true;
            this.rd8GB.Text = "8GB";
            this.rd8GB.UseVisualStyleBackColor = true;
            // 
            // rd16GB
            // 
            this.rd16GB.AutoSize = true;
            this.rd16GB.Location = new System.Drawing.Point(8, 87);
            this.rd16GB.Name = "rd16GB";
            this.rd16GB.Size = new System.Drawing.Size(87, 29);
            this.rd16GB.TabIndex = 1;
            this.rd16GB.TabStop = true;
            this.rd16GB.Text = "16GB";
            this.rd16GB.UseVisualStyleBackColor = true;
            // 
            // rd32GB
            // 
            this.rd32GB.AutoSize = true;
            this.rd32GB.Location = new System.Drawing.Point(8, 122);
            this.rd32GB.Name = "rd32GB";
            this.rd32GB.Size = new System.Drawing.Size(87, 29);
            this.rd32GB.TabIndex = 2;
            this.rd32GB.TabStop = true;
            this.rd32GB.Text = "32GB";
            this.rd32GB.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 122);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 29);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1TB";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(33, 87);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 29);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "500GB";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(33, 52);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(99, 29);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "240GB";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(33, 157);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(73, 29);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "2TB";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(8, 52);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(131, 24);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Windows 10";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(9, 148);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(88, 24);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Fedora";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(8, 84);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(131, 24);
            this.radioButton7.TabIndex = 9;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Windows 11";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(8, 116);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(89, 24);
            this.radioButton8.TabIndex = 8;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Ubuntu";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Configurador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.Background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 697);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Configurador";
            this.Text = "Configurador";
            this.Load += new System.EventHandler(this.Configurador_Load);
            this.gbProcesador.ResumeLayout(false);
            this.gbProcesador.PerformLayout();
            this.gbPlacaBase.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTOTAL;
        private System.Windows.Forms.Label lblEURO;
        private System.Windows.Forms.GroupBox gbRAM;
        private System.Windows.Forms.GroupBox gbSistemaOperativo;
        private System.Windows.Forms.RadioButton rd32GB;
        private System.Windows.Forms.RadioButton rd16GB;
        private System.Windows.Forms.RadioButton rd8GB;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Button button1;
    }
}