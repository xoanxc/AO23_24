namespace Boletin_AppGraficas
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
            this.txtIntroDatos = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIntroDatos
            // 
            this.txtIntroDatos.AutoSize = true;
            this.txtIntroDatos.Location = new System.Drawing.Point(145, 129);
            this.txtIntroDatos.Name = "txtIntroDatos";
            this.txtIntroDatos.Size = new System.Drawing.Size(145, 20);
            this.txtIntroDatos.TabIndex = 0;
            this.txtIntroDatos.Text = "Introduce los datos";
            this.txtIntroDatos.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDia
            // 
            this.txtDia.AutoSize = true;
            this.txtDia.Location = new System.Drawing.Point(113, 180);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(33, 20);
            this.txtDia.TabIndex = 1;
            this.txtDia.Text = "Día";
            // 
            // txtMes
            // 
            this.txtMes.AutoSize = true;
            this.txtMes.Location = new System.Drawing.Point(113, 220);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(39, 20);
            this.txtMes.TabIndex = 2;
            this.txtMes.Text = "Mes";
            // 
            // txtAño
            // 
            this.txtAño.AutoSize = true;
            this.txtAño.Location = new System.Drawing.Point(113, 260);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(38, 20);
            this.txtAño.TabIndex = 3;
            this.txtAño.Text = "Año";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(190, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 6;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 554);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtIntroDatos);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtIntroDatos;
        private System.Windows.Forms.Label txtDia;
        private System.Windows.Forms.Label txtMes;
        private System.Windows.Forms.Label txtAño;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}