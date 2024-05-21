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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbProcesadores = new System.Windows.Forms.ComboBox();
            this.rdIntel = new System.Windows.Forms.RadioButton();
            this.rdAMD = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbProcesadores);
            this.groupBox1.Controls.Add(this.rdIntel);
            this.groupBox1.Controls.Add(this.rdAMD);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procesador";
            // 
            // cbProcesadores
            // 
            this.cbProcesadores.FormattingEnabled = true;
            this.cbProcesadores.Location = new System.Drawing.Point(8, 101);
            this.cbProcesadores.Margin = new System.Windows.Forms.Padding(4);
            this.cbProcesadores.Name = "cbProcesadores";
            this.cbProcesadores.Size = new System.Drawing.Size(249, 33);
            this.cbProcesadores.TabIndex = 2;
            this.cbProcesadores.SelectedIndexChanged += new System.EventHandler(this.cbProcesadores_SelectedIndexChanged);
            // 
            // rdIntel
            // 
            this.rdIntel.AutoSize = true;
            this.rdIntel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIntel.Location = new System.Drawing.Point(8, 69);
            this.rdIntel.Margin = new System.Windows.Forms.Padding(4);
            this.rdIntel.Name = "rdIntel";
            this.rdIntel.Size = new System.Drawing.Size(66, 24);
            this.rdIntel.TabIndex = 1;
            this.rdIntel.TabStop = true;
            this.rdIntel.Text = "Intel";
            this.rdIntel.UseVisualStyleBackColor = true;
            // 
            // rdAMD
            // 
            this.rdAMD.AutoSize = true;
            this.rdAMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAMD.Location = new System.Drawing.Point(8, 41);
            this.rdAMD.Margin = new System.Windows.Forms.Padding(4);
            this.rdAMD.Name = "rdAMD";
            this.rdAMD.Size = new System.Drawing.Size(71, 24);
            this.rdAMD.TabIndex = 0;
            this.rdAMD.TabStop = true;
            this.rdAMD.Text = "AMD";
            this.rdAMD.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(291, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Placa Base";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(565, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(267, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tarjeta Grafica";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(16, 254);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(267, 123);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Almacenamiento";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(291, 254);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(267, 123);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Caja";
            // 
            // Configurador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Configurador";
            this.Text = "Configurador";
            this.Load += new System.EventHandler(this.Configurador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbProcesadores;
        private System.Windows.Forms.RadioButton rdIntel;
        private System.Windows.Forms.RadioButton rdAMD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}