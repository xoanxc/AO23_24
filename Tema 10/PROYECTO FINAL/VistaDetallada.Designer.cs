namespace PROYECTO_FINAL
{
    partial class VistaDetallada
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblProcesador = new System.Windows.Forms.Label();
            this.txtProcesador = new System.Windows.Forms.TextBox();
            this.txtTarjetaGrafica = new System.Windows.Forms.TextBox();
            this.lblTarjetaGrafica = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 297);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(239, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 73);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(239, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 73);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(239, 157);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 73);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // lblProcesador
            // 
            this.lblProcesador.AutoSize = true;
            this.lblProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesador.Location = new System.Drawing.Point(452, 69);
            this.lblProcesador.Name = "lblProcesador";
            this.lblProcesador.Size = new System.Drawing.Size(96, 18);
            this.lblProcesador.TabIndex = 4;
            this.lblProcesador.Text = "Procesador";
            // 
            // txtProcesador
            // 
            this.txtProcesador.Location = new System.Drawing.Point(455, 90);
            this.txtProcesador.Name = "txtProcesador";
            this.txtProcesador.Size = new System.Drawing.Size(100, 20);
            this.txtProcesador.TabIndex = 5;
            // 
            // txtTarjetaGrafica
            // 
            this.txtTarjetaGrafica.Location = new System.Drawing.Point(455, 154);
            this.txtTarjetaGrafica.Name = "txtTarjetaGrafica";
            this.txtTarjetaGrafica.Size = new System.Drawing.Size(100, 20);
            this.txtTarjetaGrafica.TabIndex = 7;
            // 
            // lblTarjetaGrafica
            // 
            this.lblTarjetaGrafica.AutoSize = true;
            this.lblTarjetaGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjetaGrafica.Location = new System.Drawing.Point(452, 133);
            this.lblTarjetaGrafica.Name = "lblTarjetaGrafica";
            this.lblTarjetaGrafica.Size = new System.Drawing.Size(120, 18);
            this.lblTarjetaGrafica.TabIndex = 6;
            this.lblTarjetaGrafica.Text = "Tarjeta Gráfica";
            // 
            // VistaDetallada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTarjetaGrafica);
            this.Controls.Add(this.lblTarjetaGrafica);
            this.Controls.Add(this.txtProcesador);
            this.Controls.Add(this.lblProcesador);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VistaDetallada";
            this.Text = "VistaDetallada";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblProcesador;
        private System.Windows.Forms.TextBox txtProcesador;
        private System.Windows.Forms.TextBox txtTarjetaGrafica;
        private System.Windows.Forms.Label lblTarjetaGrafica;
    }
}