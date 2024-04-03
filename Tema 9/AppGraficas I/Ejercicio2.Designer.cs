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
            this.lblDia.Location = new System.Drawing.Point(44, 86);
            this.lblDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(28, 16);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Día";
            this.lblDia.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIntroD
            // 
            this.lblIntroD.AutoSize = true;
            this.lblIntroD.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroD.Location = new System.Drawing.Point(45, 48);
            this.lblIntroD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntroD.Name = "lblIntroD";
            this.lblIntroD.Size = new System.Drawing.Size(129, 15);
            this.lblIntroD.TabIndex = 1;
            this.lblIntroD.Text = "Introduce los datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(44, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mes";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAño.Location = new System.Drawing.Point(44, 140);
            this.lblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(31, 16);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "Año";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(100, 78);
            this.txtDia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(132, 22);
            this.txtDia.TabIndex = 5;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(100, 108);
            this.txtMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(132, 22);
            this.txtMes.TabIndex = 6;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(100, 137);
            this.txtAño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(132, 22);
            this.txtAño.TabIndex = 7;
            // 
            // lblLaFechaEs
            // 
            this.lblLaFechaEs.AutoSize = true;
            this.lblLaFechaEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaFechaEs.Location = new System.Drawing.Point(97, 215);
            this.lblLaFechaEs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaFechaEs.Name = "lblLaFechaEs";
            this.lblLaFechaEs.Size = new System.Drawing.Size(85, 15);
            this.lblLaFechaEs.TabIndex = 8;
            this.lblLaFechaEs.Text = "La fecha es:";
            // 
            // txtLaFechaEs
            // 
            this.txtLaFechaEs.Location = new System.Drawing.Point(100, 234);
            this.txtLaFechaEs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLaFechaEs.Name = "txtLaFechaEs";
            this.txtLaFechaEs.Size = new System.Drawing.Size(296, 22);
            this.txtLaFechaEs.TabIndex = 9;
            this.txtLaFechaEs.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnConvent
            // 
            this.btnConvent.Location = new System.Drawing.Point(329, 78);
            this.btnConvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvent.Name = "btnConvent";
            this.btnConvent.Size = new System.Drawing.Size(100, 28);
            this.btnConvent.TabIndex = 10;
            this.btnConvent.Text = "Convertir";
            this.btnConvent.UseVisualStyleBackColor = true;
            this.btnConvent.Click += new System.EventHandler(this.btnConvent_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(329, 108);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(329, 140);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 293);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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