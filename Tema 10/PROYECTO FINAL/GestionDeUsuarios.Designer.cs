namespace PROYECTO_FINAL
{
    partial class GestionDeUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDeUsuarios));
            this.lbUsuarios = new System.Windows.Forms.ListBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.gbAñadirUsuario = new System.Windows.Forms.GroupBox();
            this.pbContraseña = new System.Windows.Forms.PictureBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbAñadirUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarios.FormattingEnabled = true;
            this.lbUsuarios.ItemHeight = 20;
            this.lbUsuarios.Location = new System.Drawing.Point(6, 25);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(239, 204);
            this.lbUsuarios.TabIndex = 0;
            this.lbUsuarios.SelectedIndexChanged += new System.EventHandler(this.lbUsuarios_SelectedIndexChanged);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(77, 175);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(81, 33);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // gbAñadirUsuario
            // 
            this.gbAñadirUsuario.Controls.Add(this.pbContraseña);
            this.gbAñadirUsuario.Controls.Add(this.pbUsuario);
            this.gbAñadirUsuario.Controls.Add(this.txtContraseña);
            this.gbAñadirUsuario.Controls.Add(this.txtUsuario);
            this.gbAñadirUsuario.Controls.Add(this.btnAñadir);
            this.gbAñadirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAñadirUsuario.Location = new System.Drawing.Point(12, 12);
            this.gbAñadirUsuario.Name = "gbAñadirUsuario";
            this.gbAñadirUsuario.Size = new System.Drawing.Size(251, 243);
            this.gbAñadirUsuario.TabIndex = 4;
            this.gbAñadirUsuario.TabStop = false;
            this.gbAñadirUsuario.Text = "Añadir Usuarios";
            // 
            // pbContraseña
            // 
            this.pbContraseña.BackColor = System.Drawing.Color.Transparent;
            this.pbContraseña.Image = global::PROYECTO_FINAL.Properties.Resources.lock_0;
            this.pbContraseña.Location = new System.Drawing.Point(34, 108);
            this.pbContraseña.Name = "pbContraseña";
            this.pbContraseña.Size = new System.Drawing.Size(38, 34);
            this.pbContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbContraseña.TabIndex = 11;
            this.pbContraseña.TabStop = false;
            // 
            // pbUsuario
            // 
            this.pbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pbUsuario.Image = global::PROYECTO_FINAL.Properties.Resources.user_0;
            this.pbUsuario.Location = new System.Drawing.Point(34, 44);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(38, 34);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuario.TabIndex = 10;
            this.pbUsuario.TabStop = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(77, 118);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(134, 24);
            this.txtContraseña.TabIndex = 9;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(77, 54);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(134, 24);
            this.txtUsuario.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbUsuarios);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(290, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 243);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Usuarios";
            // 
            // GestionDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 266);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAñadirUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionDeUsuarios";
            this.Text = "Gestión de usuarios";
            this.Load += new System.EventHandler(this.GestionDeUsuarios_Load);
            this.gbAñadirUsuario.ResumeLayout(false);
            this.gbAñadirUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbUsuarios;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.GroupBox gbAñadirUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbContraseña;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}