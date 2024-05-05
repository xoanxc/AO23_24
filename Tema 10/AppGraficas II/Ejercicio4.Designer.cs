namespace AppGraficas_II
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
            this.lblNombreDelCampo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreDelCampo
            // 
            this.lblNombreDelCampo.AutoSize = true;
            this.lblNombreDelCampo.Location = new System.Drawing.Point(49, 34);
            this.lblNombreDelCampo.Name = "lblNombreDelCampo";
            this.lblNombreDelCampo.Size = new System.Drawing.Size(97, 13);
            this.lblNombreDelCampo.TabIndex = 0;
            this.lblNombreDelCampo.Text = "Nombre del Campo";
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 455);
            this.Controls.Add(this.lblNombreDelCampo);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreDelCampo;
    }
}