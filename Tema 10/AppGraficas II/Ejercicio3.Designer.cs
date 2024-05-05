namespace AppGraficas_II
{
    partial class Ejercicio3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.rdMilimetros = new System.Windows.Forms.RadioButton();
            this.rdCentimetros = new System.Windows.Forms.RadioButton();
            this.rdDecimetros = new System.Windows.Forms.RadioButton();
            this.rdKilometros = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de metros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Conversión";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(187, 60);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(303, 128);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // rdMilimetros
            // 
            this.rdMilimetros.AutoSize = true;
            this.rdMilimetros.Checked = true;
            this.rdMilimetros.Location = new System.Drawing.Point(57, 128);
            this.rdMilimetros.Name = "rdMilimetros";
            this.rdMilimetros.Size = new System.Drawing.Size(71, 17);
            this.rdMilimetros.TabIndex = 5;
            this.rdMilimetros.TabStop = true;
            this.rdMilimetros.Text = "Milimetros";
            this.rdMilimetros.UseVisualStyleBackColor = true;
            // 
            // rdCentimetros
            // 
            this.rdCentimetros.AutoSize = true;
            this.rdCentimetros.Location = new System.Drawing.Point(57, 151);
            this.rdCentimetros.Name = "rdCentimetros";
            this.rdCentimetros.Size = new System.Drawing.Size(80, 17);
            this.rdCentimetros.TabIndex = 6;
            this.rdCentimetros.TabStop = true;
            this.rdCentimetros.Text = "Centimetros";
            this.rdCentimetros.UseVisualStyleBackColor = true;
            // 
            // rdDecimetros
            // 
            this.rdDecimetros.AutoSize = true;
            this.rdDecimetros.Location = new System.Drawing.Point(57, 174);
            this.rdDecimetros.Name = "rdDecimetros";
            this.rdDecimetros.Size = new System.Drawing.Size(78, 17);
            this.rdDecimetros.TabIndex = 7;
            this.rdDecimetros.TabStop = true;
            this.rdDecimetros.Text = "Decimetros";
            this.rdDecimetros.UseVisualStyleBackColor = true;
            // 
            // rdKilometros
            // 
            this.rdKilometros.AutoSize = true;
            this.rdKilometros.Location = new System.Drawing.Point(57, 197);
            this.rdKilometros.Name = "rdKilometros";
            this.rdKilometros.Size = new System.Drawing.Size(73, 17);
            this.rdKilometros.TabIndex = 8;
            this.rdKilometros.TabStop = true;
            this.rdKilometros.Text = "Kilometros";
            this.rdKilometros.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(135, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Nuevo Calculo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(293, 253);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 33);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 348);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdKilometros);
            this.Controls.Add(this.rdDecimetros);
            this.Controls.Add(this.rdCentimetros);
            this.Controls.Add(this.rdMilimetros);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.RadioButton rdMilimetros;
        private System.Windows.Forms.RadioButton rdCentimetros;
        private System.Windows.Forms.RadioButton rdDecimetros;
        private System.Windows.Forms.RadioButton rdKilometros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSalir;
    }
}