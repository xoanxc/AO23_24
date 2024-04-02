namespace AppGraficas_I
{
    partial class Ejercicio2
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
            this.lblDia = new System.Windows.Forms.Label();
            this.lblIntroD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.lblLaFechaEs = new System.Windows.Forms.Label();
            this.txtLaFechaEs = new System.Windows.Forms.TextBox();
            this.btnConvent = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDia.Location = new System.Drawing.Point(33, 70);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(25, 13);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Día";
            this.lblDia.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIntroD
            // 
            this.lblIntroD.AutoSize = true;
            this.lblIntroD.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroD.Location = new System.Drawing.Point(34, 39);
            this.lblIntroD.Name = "lblIntroD";
            this.lblIntroD.Size = new System.Drawing.Size(102, 12);
            this.lblIntroD.TabIndex = 1;
            this.lblIntroD.Text = "Introduce los datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(33, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mes";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAño.Location = new System.Drawing.Point(33, 114);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "Año";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(75, 63);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 20);
            this.txtDia.TabIndex = 5;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(75, 88);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 6;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(75, 111);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 7;
            // 
            // lblLaFechaEs
            // 
            this.lblLaFechaEs.AutoSize = true;
            this.lblLaFechaEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaFechaEs.Location = new System.Drawing.Point(73, 175);
            this.lblLaFechaEs.Name = "lblLaFechaEs";
            this.lblLaFechaEs.Size = new System.Drawing.Size(67, 12);
            this.lblLaFechaEs.TabIndex = 8;
            this.lblLaFechaEs.Text = "La fecha es:";
            // 
            // txtLaFechaEs
            // 
            this.txtLaFechaEs.Location = new System.Drawing.Point(75, 190);
            this.txtLaFechaEs.Name = "txtLaFechaEs";
            this.txtLaFechaEs.Size = new System.Drawing.Size(223, 20);
            this.txtLaFechaEs.TabIndex = 9;
            this.txtLaFechaEs.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnConvent
            // 
            this.btnConvent.Location = new System.Drawing.Point(247, 63);
            this.btnConvent.Name = "btnConvent";
            this.btnConvent.Size = new System.Drawing.Size(75, 23);
            this.btnConvent.TabIndex = 10;
            this.btnConvent.Text = "Convertir";
            this.btnConvent.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(247, 88);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(247, 114);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 238);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConvent);
            this.Controls.Add(this.txtLaFechaEs);
            this.Controls.Add(this.lblLaFechaEs);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIntroD);
            this.Controls.Add(this.lblDia);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblIntroD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblLaFechaEs;
        private System.Windows.Forms.TextBox txtLaFechaEs;
        private System.Windows.Forms.Button btnConvent;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}