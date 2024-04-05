namespace AppGraficas_I
{
    partial class Ejercicio4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroHoras = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Horas";
            // 
            // txtNumeroHoras
            // 
            this.txtNumeroHoras.Location = new System.Drawing.Point(272, 88);
            this.txtNumeroHoras.Name = "txtNumeroHoras";
            this.txtNumeroHoras.Size = new System.Drawing.Size(112, 22);
            this.txtNumeroHoras.TabIndex = 1;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(150, 156);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(153, 77);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(91, 276);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(53, 16);
            this.lblMinutos.TabIndex = 3;
            this.lblMinutos.Text = "Minutos";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(75, 334);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(69, 16);
            this.lblSegundos.TabIndex = 4;
            this.lblSegundos.Text = "Segundos";
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(150, 276);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(144, 22);
            this.txtMinutos.TabIndex = 5;
            this.txtMinutos.TextChanged += new System.EventHandler(this.txtMinutos_TextChanged);
            // 
            // txtSegundos
            // 
            this.txtSegundos.Location = new System.Drawing.Point(150, 331);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.Size = new System.Drawing.Size(144, 22);
            this.txtSegundos.TabIndex = 6;
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 414);
            this.Controls.Add(this.txtSegundos);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtNumeroHoras);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroHoras;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtSegundos;
    }
}