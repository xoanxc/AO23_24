namespace AppGraficas_I
{
    partial class Ejercicio7
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
            this.lblConversor = new System.Windows.Forms.Label();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.txtEuros = new System.Windows.Forms.TextBox();
            this.btnConvertirDolares = new System.Windows.Forms.Button();
            this.btnConvertirEuros = new System.Windows.Forms.Button();
            this.lblDolares = new System.Windows.Forms.Label();
            this.lblEuros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConversor
            // 
            this.lblConversor.AutoSize = true;
            this.lblConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversor.Location = new System.Drawing.Point(66, 56);
            this.lblConversor.Name = "lblConversor";
            this.lblConversor.Size = new System.Drawing.Size(173, 37);
            this.lblConversor.TabIndex = 0;
            this.lblConversor.Text = "Conversor";
            // 
            // txtDolares
            // 
            this.txtDolares.Location = new System.Drawing.Point(73, 134);
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(166, 20);
            this.txtDolares.TabIndex = 1;
            this.txtDolares.TextChanged += new System.EventHandler(this.txtDolares_TextChanged);
            // 
            // txtEuros
            // 
            this.txtEuros.Location = new System.Drawing.Point(73, 173);
            this.txtEuros.Name = "txtEuros";
            this.txtEuros.Size = new System.Drawing.Size(166, 20);
            this.txtEuros.TabIndex = 2;
            // 
            // btnConvertirDolares
            // 
            this.btnConvertirDolares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConvertirDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirDolares.Location = new System.Drawing.Point(50, 230);
            this.btnConvertirDolares.Name = "btnConvertirDolares";
            this.btnConvertirDolares.Size = new System.Drawing.Size(88, 56);
            this.btnConvertirDolares.TabIndex = 3;
            this.btnConvertirDolares.Text = "Convertir a Dolares";
            this.btnConvertirDolares.UseVisualStyleBackColor = false;
            this.btnConvertirDolares.Click += new System.EventHandler(this.btnConvertirDolares_Click);
            // 
            // btnConvertirEuros
            // 
            this.btnConvertirEuros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConvertirEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirEuros.Location = new System.Drawing.Point(175, 230);
            this.btnConvertirEuros.Name = "btnConvertirEuros";
            this.btnConvertirEuros.Size = new System.Drawing.Size(88, 56);
            this.btnConvertirEuros.TabIndex = 4;
            this.btnConvertirEuros.Text = "Convertir a Euros";
            this.btnConvertirEuros.UseVisualStyleBackColor = false;
            this.btnConvertirEuros.Click += new System.EventHandler(this.btnConvertirEuros_Click);
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolares.Location = new System.Drawing.Point(249, 134);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(19, 20);
            this.lblDolares.TabIndex = 5;
            this.lblDolares.Text = "$";
            // 
            // lblEuros
            // 
            this.lblEuros.AutoSize = true;
            this.lblEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuros.Location = new System.Drawing.Point(249, 173);
            this.lblEuros.Name = "lblEuros";
            this.lblEuros.Size = new System.Drawing.Size(19, 20);
            this.lblEuros.TabIndex = 6;
            this.lblEuros.Text = "€";
            // 
            // Ejercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 327);
            this.Controls.Add(this.lblEuros);
            this.Controls.Add(this.lblDolares);
            this.Controls.Add(this.btnConvertirEuros);
            this.Controls.Add(this.btnConvertirDolares);
            this.Controls.Add(this.txtEuros);
            this.Controls.Add(this.txtDolares);
            this.Controls.Add(this.lblConversor);
            this.Name = "Ejercicio7";
            this.Text = "Ejercicio7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConversor;
        private System.Windows.Forms.TextBox txtDolares;
        private System.Windows.Forms.TextBox txtEuros;
        private System.Windows.Forms.Button btnConvertirDolares;
        private System.Windows.Forms.Button btnConvertirEuros;
        private System.Windows.Forms.Label lblDolares;
        private System.Windows.Forms.Label lblEuros;
    }
}