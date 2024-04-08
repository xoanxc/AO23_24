namespace AppGraficas_I
{
    partial class Ejercicio6
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
            this.lblGradosCentigrados = new System.Windows.Forms.Label();
            this.lblGradosFahrenheit = new System.Windows.Forms.Label();
            this.txtCentigrados = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnPasarF = new System.Windows.Forms.Button();
            this.btnPasarC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGradosCentigrados
            // 
            this.lblGradosCentigrados.AutoSize = true;
            this.lblGradosCentigrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradosCentigrados.Location = new System.Drawing.Point(50, 50);
            this.lblGradosCentigrados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradosCentigrados.Name = "lblGradosCentigrados";
            this.lblGradosCentigrados.Size = new System.Drawing.Size(153, 17);
            this.lblGradosCentigrados.TabIndex = 0;
            this.lblGradosCentigrados.Text = "Grados Centigrados";
            // 
            // lblGradosFahrenheit
            // 
            this.lblGradosFahrenheit.AutoSize = true;
            this.lblGradosFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradosFahrenheit.Location = new System.Drawing.Point(50, 102);
            this.lblGradosFahrenheit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGradosFahrenheit.Name = "lblGradosFahrenheit";
            this.lblGradosFahrenheit.Size = new System.Drawing.Size(144, 17);
            this.lblGradosFahrenheit.TabIndex = 1;
            this.lblGradosFahrenheit.Text = "Grados Fahrenheit";
            // 
            // txtCentigrados
            // 
            this.txtCentigrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCentigrados.Location = new System.Drawing.Point(216, 50);
            this.txtCentigrados.Margin = new System.Windows.Forms.Padding(2);
            this.txtCentigrados.Name = "txtCentigrados";
            this.txtCentigrados.Size = new System.Drawing.Size(108, 23);
            this.txtCentigrados.TabIndex = 2;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheit.Location = new System.Drawing.Point(216, 101);
            this.txtFahrenheit.Margin = new System.Windows.Forms.Padding(2);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(108, 23);
            this.txtFahrenheit.TabIndex = 3;
            // 
            // btnPasarF
            // 
            this.btnPasarF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarF.Location = new System.Drawing.Point(201, 154);
            this.btnPasarF.Margin = new System.Windows.Forms.Padding(2);
            this.btnPasarF.Name = "btnPasarF";
            this.btnPasarF.Size = new System.Drawing.Size(112, 37);
            this.btnPasarF.TabIndex = 4;
            this.btnPasarF.Text = "Pasar a ºF";
            this.btnPasarF.UseVisualStyleBackColor = true;
            this.btnPasarF.Click += new System.EventHandler(this.btnPasarF_Click);
            // 
            // btnPasarC
            // 
            this.btnPasarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarC.Location = new System.Drawing.Point(61, 154);
            this.btnPasarC.Margin = new System.Windows.Forms.Padding(2);
            this.btnPasarC.Name = "btnPasarC";
            this.btnPasarC.Size = new System.Drawing.Size(112, 37);
            this.btnPasarC.TabIndex = 5;
            this.btnPasarC.Text = "Pasar a ºC";
            this.btnPasarC.UseVisualStyleBackColor = true;
            this.btnPasarC.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 237);
            this.Controls.Add(this.btnPasarC);
            this.Controls.Add(this.btnPasarF);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCentigrados);
            this.Controls.Add(this.lblGradosFahrenheit);
            this.Controls.Add(this.lblGradosCentigrados);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ejercicio6";
            this.Text = "Ejercicio6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGradosCentigrados;
        private System.Windows.Forms.Label lblGradosFahrenheit;
        private System.Windows.Forms.TextBox txtCentigrados;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnPasarF;
        private System.Windows.Forms.Button btnPasarC;
    }
}