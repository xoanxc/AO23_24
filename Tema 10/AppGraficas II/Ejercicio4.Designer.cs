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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtNombreCampo = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.rdComboBox = new System.Windows.Forms.RadioButton();
            this.rdListBox = new System.Windows.Forms.RadioButton();
            this.btnVolcarTXT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreDelCampo
            // 
            this.lblNombreDelCampo.AutoSize = true;
            this.lblNombreDelCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDelCampo.Location = new System.Drawing.Point(20, 40);
            this.lblNombreDelCampo.Name = "lblNombreDelCampo";
            this.lblNombreDelCampo.Size = new System.Drawing.Size(117, 13);
            this.lblNombreDelCampo.TabIndex = 0;
            this.lblNombreDelCampo.Text = "Nombre del Campo:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 184);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 173);
            this.listBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(349, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // txtNombreCampo
            // 
            this.txtNombreCampo.Location = new System.Drawing.Point(143, 37);
            this.txtNombreCampo.Name = "txtNombreCampo";
            this.txtNombreCampo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCampo.TabIndex = 3;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(257, 19);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(104, 34);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // rdComboBox
            // 
            this.rdComboBox.AutoSize = true;
            this.rdComboBox.Checked = true;
            this.rdComboBox.Location = new System.Drawing.Point(23, 65);
            this.rdComboBox.Name = "rdComboBox";
            this.rdComboBox.Size = new System.Drawing.Size(125, 17);
            this.rdComboBox.TabIndex = 5;
            this.rdComboBox.TabStop = true;
            this.rdComboBox.Text = "Cargar en ComboBox";
            this.rdComboBox.UseVisualStyleBackColor = true;
            // 
            // rdListBox
            // 
            this.rdListBox.AutoSize = true;
            this.rdListBox.Location = new System.Drawing.Point(23, 88);
            this.rdListBox.Name = "rdListBox";
            this.rdListBox.Size = new System.Drawing.Size(108, 17);
            this.rdListBox.TabIndex = 6;
            this.rdListBox.Text = "Cargar en ListBox";
            this.rdListBox.UseVisualStyleBackColor = true;
            // 
            // btnVolcarTXT
            // 
            this.btnVolcarTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolcarTXT.Location = new System.Drawing.Point(257, 59);
            this.btnVolcarTXT.Name = "btnVolcarTXT";
            this.btnVolcarTXT.Size = new System.Drawing.Size(104, 28);
            this.btnVolcarTXT.TabIndex = 7;
            this.btnVolcarTXT.Text = "Volcar a TXT";
            this.btnVolcarTXT.UseVisualStyleBackColor = true;
            this.btnVolcarTXT.Click += new System.EventHandler(this.btnVolcarTXT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Registros";
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolcarTXT);
            this.Controls.Add(this.rdListBox);
            this.Controls.Add(this.rdComboBox);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtNombreCampo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblNombreDelCampo);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreDelCampo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtNombreCampo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.RadioButton rdComboBox;
        private System.Windows.Forms.RadioButton rdListBox;
        private System.Windows.Forms.Button btnVolcarTXT;
        private System.Windows.Forms.Label label1;
    }
}