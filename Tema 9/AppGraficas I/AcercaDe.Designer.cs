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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.label1 = new System.Windows.Forms.Label();
            this.tbDeveloper1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbDeveloper1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desarrollado por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbDeveloper1
            // 
            this.tbDeveloper1.Image = ((System.Drawing.Image)(resources.GetObject("tbDeveloper1.Image")));
            this.tbDeveloper1.Location = new System.Drawing.Point(72, 101);
            this.tbDeveloper1.Name = "tbDeveloper1";
            this.tbDeveloper1.Size = new System.Drawing.Size(226, 333);
            this.tbDeveloper1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tbDeveloper1.TabIndex = 1;
            this.tbDeveloper1.TabStop = false;
            this.tbDeveloper1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 446);
            this.Controls.Add(this.tbDeveloper1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AcercaDe";
            this.Text = "AcercaDe";
            ((System.ComponentModel.ISupportInitialize)(this.tbDeveloper1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox tbDeveloper1;
    }
}