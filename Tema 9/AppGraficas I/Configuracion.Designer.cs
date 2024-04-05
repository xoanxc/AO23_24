namespace AppGraficas_I
{
    partial class Configuracion
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
            this.lblTemaMenuSeleccion = new System.Windows.Forms.Label();
            this.rdbMontecastelo = new System.Windows.Forms.RadioButton();
            this.rdbFrieren = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTemaMenuSeleccion
            // 
            this.lblTemaMenuSeleccion.AutoSize = true;
            this.lblTemaMenuSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemaMenuSeleccion.Location = new System.Drawing.Point(72, 76);
            this.lblTemaMenuSeleccion.Name = "lblTemaMenuSeleccion";
            this.lblTemaMenuSeleccion.Size = new System.Drawing.Size(215, 20);
            this.lblTemaMenuSeleccion.TabIndex = 0;
            this.lblTemaMenuSeleccion.Text = "Tema del menu principal";
            this.lblTemaMenuSeleccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // rdbMontecastelo
            // 
            this.rdbMontecastelo.AutoSize = true;
            this.rdbMontecastelo.Location = new System.Drawing.Point(76, 109);
            this.rdbMontecastelo.Name = "rdbMontecastelo";
            this.rdbMontecastelo.Size = new System.Drawing.Size(188, 20);
            this.rdbMontecastelo.TabIndex = 3;
            this.rdbMontecastelo.TabStop = true;
            this.rdbMontecastelo.Text = "Montecastelo (por defecto)";
            this.rdbMontecastelo.UseVisualStyleBackColor = true;
            this.rdbMontecastelo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbFrieren
            // 
            this.rdbFrieren.AutoSize = true;
            this.rdbFrieren.Location = new System.Drawing.Point(75, 135);
            this.rdbFrieren.Name = "rdbFrieren";
            this.rdbFrieren.Size = new System.Drawing.Size(123, 20);
            this.rdbFrieren.TabIndex = 4;
            this.rdbFrieren.TabStop = true;
            this.rdbFrieren.Text = "Frieren (xoanxc)";
            this.rdbFrieren.UseVisualStyleBackColor = true;
            this.rdbFrieren.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(76, 161);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(125, 20);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Logotipo GitHub";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(76, 187);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(100, 20);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Logotipo C#";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(76, 213);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(70, 20);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Simple";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 368);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.rdbFrieren);
            this.Controls.Add(this.rdbMontecastelo);
            this.Controls.Add(this.lblTemaMenuSeleccion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Configuracion";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemaMenuSeleccion;
        private System.Windows.Forms.RadioButton rdbMontecastelo;
        private System.Windows.Forms.RadioButton rdbFrieren;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}