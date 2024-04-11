namespace AppGraficas_I
{
    partial class AcercaDe
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
            this.lblDesarrolladoPor = new System.Windows.Forms.Label();
            this.linkGit = new System.Windows.Forms.LinkLabel();
            this.lblCodigoFuente = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblDesarrolladoPor
            // 
            this.lblDesarrolladoPor.AutoSize = true;
            this.lblDesarrolladoPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesarrolladoPor.Location = new System.Drawing.Point(62, 47);
            this.lblDesarrolladoPor.Name = "lblDesarrolladoPor";
            this.lblDesarrolladoPor.Size = new System.Drawing.Size(156, 20);
            this.lblDesarrolladoPor.TabIndex = 0;
            this.lblDesarrolladoPor.Text = "Desarrollado por:";
            this.lblDesarrolladoPor.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkGit
            // 
            this.linkGit.AutoSize = true;
            this.linkGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGit.Location = new System.Drawing.Point(62, 67);
            this.linkGit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkGit.Name = "linkGit";
            this.linkGit.Size = new System.Drawing.Size(199, 20);
            this.linkGit.TabIndex = 1;
            this.linkGit.TabStop = true;
            this.linkGit.Text = "https://github.com/xoanxc";
            // 
            // lblCodigoFuente
            // 
            this.lblCodigoFuente.AutoSize = true;
            this.lblCodigoFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoFuente.Location = new System.Drawing.Point(63, 111);
            this.lblCodigoFuente.Name = "lblCodigoFuente";
            this.lblCodigoFuente.Size = new System.Drawing.Size(131, 20);
            this.lblCodigoFuente.TabIndex = 2;
            this.lblCodigoFuente.Text = "Codigo fuente:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(64, 131);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(572, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/xoanxc/AO23_24/tree/main/Tema%209/AppGraficas%20I";
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 211);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblCodigoFuente);
            this.Controls.Add(this.linkGit);
            this.Controls.Add(this.lblDesarrolladoPor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AcercaDe";
            this.Text = "AcercaDe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesarrolladoPor;
        private System.Windows.Forms.LinkLabel linkGit;
        private System.Windows.Forms.Label lblCodigoFuente;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}