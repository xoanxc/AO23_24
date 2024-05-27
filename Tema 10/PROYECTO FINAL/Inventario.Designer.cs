namespace PROYECTO_FINAL
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.txtProcesador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioProcesador = new System.Windows.Forms.TextBox();
            this.rdAMD = new System.Windows.Forms.RadioButton();
            this.rdIntel = new System.Windows.Forms.RadioButton();
            this.rdNvidia = new System.Windows.Forms.RadioButton();
            this.rdAMDG = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioGrafica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGrafica = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlacaBase = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioPlaca = new System.Windows.Forms.TextBox();
            this.btnAñadirCPU = new System.Windows.Forms.Button();
            this.btnAñadirPlaca = new System.Windows.Forms.Button();
            this.btnAñadirGPU = new System.Windows.Forms.Button();
            this.rdIntelP = new System.Windows.Forms.RadioButton();
            this.rdAMDP = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProcesador
            // 
            this.txtProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcesador.Location = new System.Drawing.Point(49, 123);
            this.txtProcesador.Margin = new System.Windows.Forms.Padding(4);
            this.txtProcesador.Name = "txtProcesador";
            this.txtProcesador.Size = new System.Drawing.Size(219, 34);
            this.txtProcesador.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Procesador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // txtPrecioProcesador
            // 
            this.txtPrecioProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProcesador.Location = new System.Drawing.Point(49, 381);
            this.txtPrecioProcesador.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioProcesador.Name = "txtPrecioProcesador";
            this.txtPrecioProcesador.Size = new System.Drawing.Size(160, 34);
            this.txtPrecioProcesador.TabIndex = 4;
            // 
            // rdAMD
            // 
            this.rdAMD.AutoSize = true;
            this.rdAMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAMD.Location = new System.Drawing.Point(103, 239);
            this.rdAMD.Margin = new System.Windows.Forms.Padding(4);
            this.rdAMD.Name = "rdAMD";
            this.rdAMD.Size = new System.Drawing.Size(78, 29);
            this.rdAMD.TabIndex = 6;
            this.rdAMD.TabStop = true;
            this.rdAMD.Text = "AMD";
            this.rdAMD.UseVisualStyleBackColor = true;
            // 
            // rdIntel
            // 
            this.rdIntel.AutoSize = true;
            this.rdIntel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIntel.Location = new System.Drawing.Point(103, 276);
            this.rdIntel.Margin = new System.Windows.Forms.Padding(4);
            this.rdIntel.Name = "rdIntel";
            this.rdIntel.Size = new System.Drawing.Size(69, 29);
            this.rdIntel.TabIndex = 7;
            this.rdIntel.TabStop = true;
            this.rdIntel.Text = "Intel";
            this.rdIntel.UseVisualStyleBackColor = true;
            // 
            // rdNvidia
            // 
            this.rdNvidia.AutoSize = true;
            this.rdNvidia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNvidia.Location = new System.Drawing.Point(666, 276);
            this.rdNvidia.Margin = new System.Windows.Forms.Padding(4);
            this.rdNvidia.Name = "rdNvidia";
            this.rdNvidia.Size = new System.Drawing.Size(87, 29);
            this.rdNvidia.TabIndex = 14;
            this.rdNvidia.TabStop = true;
            this.rdNvidia.Text = "Nvidia";
            this.rdNvidia.UseVisualStyleBackColor = true;
            // 
            // rdAMDG
            // 
            this.rdAMDG.AutoSize = true;
            this.rdAMDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAMDG.Location = new System.Drawing.Point(666, 239);
            this.rdAMDG.Margin = new System.Windows.Forms.Padding(4);
            this.rdAMDG.Name = "rdAMDG";
            this.rdAMDG.Size = new System.Drawing.Size(78, 29);
            this.rdAMDG.TabIndex = 13;
            this.rdAMDG.TabStop = true;
            this.rdAMDG.Text = "AMD";
            this.rdAMDG.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(660, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio";
            // 
            // txtPrecioGrafica
            // 
            this.txtPrecioGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioGrafica.Location = new System.Drawing.Point(631, 381);
            this.txtPrecioGrafica.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioGrafica.Name = "txtPrecioGrafica";
            this.txtPrecioGrafica.Size = new System.Drawing.Size(160, 34);
            this.txtPrecioGrafica.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(660, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(600, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tarjeta Grafica";
            // 
            // txtGrafica
            // 
            this.txtGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrafica.Location = new System.Drawing.Point(601, 123);
            this.txtGrafica.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrafica.Name = "txtGrafica";
            this.txtGrafica.Size = new System.Drawing.Size(219, 34);
            this.txtGrafica.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Placa Base";
            // 
            // txtPlacaBase
            // 
            this.txtPlacaBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaBase.Location = new System.Drawing.Point(326, 123);
            this.txtPlacaBase.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlacaBase.Name = "txtPlacaBase";
            this.txtPlacaBase.Size = new System.Drawing.Size(219, 34);
            this.txtPlacaBase.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(372, 345);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "Precio";
            // 
            // txtPrecioPlaca
            // 
            this.txtPrecioPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioPlaca.Location = new System.Drawing.Point(343, 381);
            this.txtPrecioPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioPlaca.Name = "txtPrecioPlaca";
            this.txtPrecioPlaca.Size = new System.Drawing.Size(160, 34);
            this.txtPrecioPlaca.TabIndex = 17;
            // 
            // btnAñadirCPU
            // 
            this.btnAñadirCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirCPU.Location = new System.Drawing.Point(69, 423);
            this.btnAñadirCPU.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirCPU.Name = "btnAñadirCPU";
            this.btnAñadirCPU.Size = new System.Drawing.Size(125, 43);
            this.btnAñadirCPU.TabIndex = 19;
            this.btnAñadirCPU.Text = "Añadir";
            this.btnAñadirCPU.UseVisualStyleBackColor = true;
            this.btnAñadirCPU.Click += new System.EventHandler(this.btnAñadirCPU_Click);
            // 
            // btnAñadirPlaca
            // 
            this.btnAñadirPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirPlaca.Location = new System.Drawing.Point(360, 423);
            this.btnAñadirPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirPlaca.Name = "btnAñadirPlaca";
            this.btnAñadirPlaca.Size = new System.Drawing.Size(125, 43);
            this.btnAñadirPlaca.TabIndex = 20;
            this.btnAñadirPlaca.Text = "Añadir";
            this.btnAñadirPlaca.UseVisualStyleBackColor = true;
            this.btnAñadirPlaca.Click += new System.EventHandler(this.btnAñadirPlaca_Click);
            // 
            // btnAñadirGPU
            // 
            this.btnAñadirGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirGPU.Location = new System.Drawing.Point(649, 423);
            this.btnAñadirGPU.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirGPU.Name = "btnAñadirGPU";
            this.btnAñadirGPU.Size = new System.Drawing.Size(125, 43);
            this.btnAñadirGPU.TabIndex = 21;
            this.btnAñadirGPU.Text = "Añadir";
            this.btnAñadirGPU.UseVisualStyleBackColor = true;
            this.btnAñadirGPU.Click += new System.EventHandler(this.btnAñadirGPU_Click);
            // 
            // rdIntelP
            // 
            this.rdIntelP.AutoSize = true;
            this.rdIntelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIntelP.Location = new System.Drawing.Point(382, 276);
            this.rdIntelP.Margin = new System.Windows.Forms.Padding(4);
            this.rdIntelP.Name = "rdIntelP";
            this.rdIntelP.Size = new System.Drawing.Size(69, 29);
            this.rdIntelP.TabIndex = 23;
            this.rdIntelP.TabStop = true;
            this.rdIntelP.Text = "Intel";
            this.rdIntelP.UseVisualStyleBackColor = true;
            // 
            // rdAMDP
            // 
            this.rdAMDP.AutoSize = true;
            this.rdAMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAMDP.Location = new System.Drawing.Point(382, 239);
            this.rdAMDP.Margin = new System.Windows.Forms.Padding(4);
            this.rdAMDP.Name = "rdAMDP";
            this.rdAMDP.Size = new System.Drawing.Size(78, 29);
            this.rdAMDP.TabIndex = 22;
            this.rdAMDP.TabStop = true;
            this.rdAMDP.Text = "AMD";
            this.rdAMDP.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(376, 203);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 32);
            this.label9.TabIndex = 24;
            this.label9.Text = "Marca";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 543);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rdIntelP);
            this.Controls.Add(this.rdAMDP);
            this.Controls.Add(this.btnAñadirGPU);
            this.Controls.Add(this.btnAñadirPlaca);
            this.Controls.Add(this.btnAñadirCPU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrecioPlaca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPlacaBase);
            this.Controls.Add(this.rdNvidia);
            this.Controls.Add(this.rdAMDG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecioGrafica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGrafica);
            this.Controls.Add(this.rdIntel);
            this.Controls.Add(this.rdAMD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioProcesador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProcesador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventario";
            this.Text = " Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProcesador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecioProcesador;
        private System.Windows.Forms.RadioButton rdAMD;
        private System.Windows.Forms.RadioButton rdIntel;
        private System.Windows.Forms.RadioButton rdNvidia;
        private System.Windows.Forms.RadioButton rdAMDG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioGrafica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGrafica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlacaBase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecioPlaca;
        private System.Windows.Forms.Button btnAñadirCPU;
        private System.Windows.Forms.Button btnAñadirPlaca;
        private System.Windows.Forms.Button btnAñadirGPU;
        private System.Windows.Forms.RadioButton rdIntelP;
        private System.Windows.Forms.RadioButton rdAMDP;
        private System.Windows.Forms.Label label9;
    }
}