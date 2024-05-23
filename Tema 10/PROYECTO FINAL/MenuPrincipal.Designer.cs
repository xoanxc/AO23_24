namespace PROYECTO_FINAL
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opción1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbProcesador = new System.Windows.Forms.GroupBox();
            this.rdIntel = new System.Windows.Forms.RadioButton();
            this.rdAMD = new System.Windows.Forms.RadioButton();
            this.rd8GB = new System.Windows.Forms.RadioButton();
            this.rd16GB = new System.Windows.Forms.RadioButton();
            this.rd500 = new System.Windows.Forms.RadioButton();
            this.rd1000 = new System.Windows.Forms.RadioButton();
            this.rd1500 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd32GB = new System.Windows.Forms.RadioButton();
            this.rd3000 = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.gbProcesador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opción1ToolStripMenuItem,
            this.configuradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opción1ToolStripMenuItem
            // 
            this.opción1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuariosToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.cerarSesiónToolStripMenuItem});
            this.opción1ToolStripMenuItem.Name = "opción1ToolStripMenuItem";
            this.opción1ToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opción1ToolStripMenuItem.Text = "Opciones";
            // 
            // registrarUsuariosToolStripMenuItem
            // 
            this.registrarUsuariosToolStripMenuItem.Name = "registrarUsuariosToolStripMenuItem";
            this.registrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.registrarUsuariosToolStripMenuItem.Text = "Gestión de usuarios";
            this.registrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuariosToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // cerarSesiónToolStripMenuItem
            // 
            this.cerarSesiónToolStripMenuItem.Name = "cerarSesiónToolStripMenuItem";
            this.cerarSesiónToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cerarSesiónToolStripMenuItem.Text = "Cerar sesión";
            this.cerarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerarSesiónToolStripMenuItem_Click);
            // 
            // configuradorToolStripMenuItem
            // 
            this.configuradorToolStripMenuItem.Name = "configuradorToolStripMenuItem";
            this.configuradorToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.configuradorToolStripMenuItem.Text = "Configurador";
            this.configuradorToolStripMenuItem.Click += new System.EventHandler(this.configuradorToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(243, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 274);
            this.listBox1.TabIndex = 2;
            // 
            // gbProcesador
            // 
            this.gbProcesador.BackColor = System.Drawing.Color.LightGray;
            this.gbProcesador.Controls.Add(this.rdIntel);
            this.gbProcesador.Controls.Add(this.rdAMD);
            this.gbProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProcesador.Location = new System.Drawing.Point(27, 57);
            this.gbProcesador.Name = "gbProcesador";
            this.gbProcesador.Size = new System.Drawing.Size(200, 130);
            this.gbProcesador.TabIndex = 3;
            this.gbProcesador.TabStop = false;
            this.gbProcesador.Text = "Procesador";
            // 
            // rdIntel
            // 
            this.rdIntel.AutoSize = true;
            this.rdIntel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdIntel.Location = new System.Drawing.Point(12, 67);
            this.rdIntel.Name = "rdIntel";
            this.rdIntel.Size = new System.Drawing.Size(57, 22);
            this.rdIntel.TabIndex = 1;
            this.rdIntel.TabStop = true;
            this.rdIntel.Text = "Intel";
            this.rdIntel.UseVisualStyleBackColor = true;
            // 
            // rdAMD
            // 
            this.rdAMD.AutoSize = true;
            this.rdAMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAMD.Location = new System.Drawing.Point(12, 39);
            this.rdAMD.Name = "rdAMD";
            this.rdAMD.Size = new System.Drawing.Size(62, 22);
            this.rdAMD.TabIndex = 0;
            this.rdAMD.TabStop = true;
            this.rdAMD.Text = "AMD";
            this.rdAMD.UseVisualStyleBackColor = true;
            // 
            // rd8GB
            // 
            this.rd8GB.AutoSize = true;
            this.rd8GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd8GB.Location = new System.Drawing.Point(6, 42);
            this.rd8GB.Name = "rd8GB";
            this.rd8GB.Size = new System.Drawing.Size(59, 22);
            this.rd8GB.TabIndex = 2;
            this.rd8GB.TabStop = true;
            this.rd8GB.Text = "8GB";
            this.rd8GB.UseVisualStyleBackColor = true;
            // 
            // rd16GB
            // 
            this.rd16GB.AutoSize = true;
            this.rd16GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd16GB.Location = new System.Drawing.Point(6, 61);
            this.rd16GB.Name = "rd16GB";
            this.rd16GB.Size = new System.Drawing.Size(68, 22);
            this.rd16GB.TabIndex = 3;
            this.rd16GB.TabStop = true;
            this.rd16GB.Text = "16GB";
            this.rd16GB.UseVisualStyleBackColor = true;
            // 
            // rd500
            // 
            this.rd500.AutoSize = true;
            this.rd500.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd500.Location = new System.Drawing.Point(31, 92);
            this.rd500.Name = "rd500";
            this.rd500.Size = new System.Drawing.Size(62, 22);
            this.rd500.TabIndex = 4;
            this.rd500.TabStop = true;
            this.rd500.Text = "500€";
            this.rd500.UseVisualStyleBackColor = true;
            // 
            // rd1000
            // 
            this.rd1000.AutoSize = true;
            this.rd1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1000.Location = new System.Drawing.Point(31, 120);
            this.rd1000.Name = "rd1000";
            this.rd1000.Size = new System.Drawing.Size(71, 22);
            this.rd1000.TabIndex = 5;
            this.rd1000.TabStop = true;
            this.rd1000.Text = "1000€";
            this.rd1000.UseVisualStyleBackColor = true;
            // 
            // rd1500
            // 
            this.rd1500.AutoSize = true;
            this.rd1500.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1500.Location = new System.Drawing.Point(31, 148);
            this.rd1500.Name = "rd1500";
            this.rd1500.Size = new System.Drawing.Size(71, 22);
            this.rd1500.TabIndex = 6;
            this.rd1500.TabStop = true;
            this.rd1500.Text = "1500€";
            this.rd1500.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.rd3000);
            this.groupBox1.Controls.Add(this.rd500);
            this.groupBox1.Controls.Add(this.rd1500);
            this.groupBox1.Controls.Add(this.rd1000);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(486, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 278);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precio Maximo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.rd32GB);
            this.groupBox2.Controls.Add(this.rd8GB);
            this.groupBox2.Controls.Add(this.rd16GB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 130);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Memoria RAM";
            // 
            // rd32GB
            // 
            this.rd32GB.AutoSize = true;
            this.rd32GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd32GB.Location = new System.Drawing.Point(6, 81);
            this.rd32GB.Name = "rd32GB";
            this.rd32GB.Size = new System.Drawing.Size(68, 22);
            this.rd32GB.TabIndex = 4;
            this.rd32GB.TabStop = true;
            this.rd32GB.Text = "32GB";
            this.rd32GB.UseVisualStyleBackColor = true;
            // 
            // rd3000
            // 
            this.rd3000.AutoSize = true;
            this.rd3000.Location = new System.Drawing.Point(31, 176);
            this.rd3000.Name = "rd3000";
            this.rd3000.Size = new System.Drawing.Size(77, 24);
            this.rd3000.TabIndex = 7;
            this.rd3000.TabStop = true;
            this.rd3000.Text = "3000€";
            this.rd3000.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.Background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbProcesador);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbProcesador.ResumeLayout(false);
            this.gbProcesador.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opción1ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuradorToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox gbProcesador;
        private System.Windows.Forms.RadioButton rd16GB;
        private System.Windows.Forms.RadioButton rd8GB;
        private System.Windows.Forms.RadioButton rdIntel;
        private System.Windows.Forms.RadioButton rdAMD;
        private System.Windows.Forms.RadioButton rd500;
        private System.Windows.Forms.RadioButton rd1000;
        private System.Windows.Forms.RadioButton rd1500;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd32GB;
        private System.Windows.Forms.RadioButton rd3000;
    }
}