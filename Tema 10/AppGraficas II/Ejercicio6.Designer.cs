namespace AppGraficas_II
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio6));
            this.rdTux = new System.Windows.Forms.RadioButton();
            this.rdMiike = new System.Windows.Forms.RadioButton();
            this.rdWikiRafa = new System.Windows.Forms.RadioButton();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdTux
            // 
            this.rdTux.AutoSize = true;
            this.rdTux.Checked = true;
            this.rdTux.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTux.Location = new System.Drawing.Point(24, 130);
            this.rdTux.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdTux.Name = "rdTux";
            this.rdTux.Size = new System.Drawing.Size(67, 29);
            this.rdTux.TabIndex = 0;
            this.rdTux.TabStop = true;
            this.rdTux.Text = "Tux";
            this.rdTux.UseVisualStyleBackColor = true;
            this.rdTux.CheckedChanged += new System.EventHandler(this.rdTux_CheckedChanged);
            // 
            // rdMiike
            // 
            this.rdMiike.AutoSize = true;
            this.rdMiike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMiike.Location = new System.Drawing.Point(24, 167);
            this.rdMiike.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdMiike.Name = "rdMiike";
            this.rdMiike.Size = new System.Drawing.Size(79, 29);
            this.rdMiike.TabIndex = 1;
            this.rdMiike.Text = "Miike";
            this.rdMiike.UseVisualStyleBackColor = true;
            this.rdMiike.CheckedChanged += new System.EventHandler(this.rdMiike_CheckedChanged);
            // 
            // rdWikiRafa
            // 
            this.rdWikiRafa.AutoSize = true;
            this.rdWikiRafa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdWikiRafa.Location = new System.Drawing.Point(24, 204);
            this.rdWikiRafa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdWikiRafa.Name = "rdWikiRafa";
            this.rdWikiRafa.Size = new System.Drawing.Size(111, 29);
            this.rdWikiRafa.TabIndex = 2;
            this.rdWikiRafa.Text = "WikiRafa";
            this.rdWikiRafa.UseVisualStyleBackColor = true;
            this.rdWikiRafa.CheckedChanged += new System.EventHandler(this.rdWikiRafa_CheckedChanged);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.Location = new System.Drawing.Point(16, 81);
            this.lblSeleccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(190, 42);
            this.lblSeleccion.TabIndex = 4;
            this.lblSeleccion.Text = "Selección";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppGraficas_II.Properties.Resources.Tux;
            this.pictureBox1.Location = new System.Drawing.Point(225, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 327);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.rdWikiRafa);
            this.Controls.Add(this.rdMiike);
            this.Controls.Add(this.rdTux);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(573, 374);
            this.MinimumSize = new System.Drawing.Size(573, 374);
            this.Name = "Ejercicio6";
            this.Text = "Ejercicio 6";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdTux;
        private System.Windows.Forms.RadioButton rdMiike;
        private System.Windows.Forms.RadioButton rdWikiRafa;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}