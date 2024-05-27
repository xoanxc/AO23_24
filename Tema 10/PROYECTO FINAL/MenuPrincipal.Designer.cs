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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opción1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbOrdenadores = new System.Windows.Forms.ListBox();
            this.gbProcesador = new System.Windows.Forms.GroupBox();
            this.rd500 = new System.Windows.Forms.RadioButton();
            this.rd1000 = new System.Windows.Forms.RadioButton();
            this.rd1500 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd5000 = new System.Windows.Forms.RadioButton();
            this.rd3000 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.rdAMD = new System.Windows.Forms.RadioButton();
            this.rdIntel = new System.Windows.Forms.RadioButton();
            this.rd8GB = new System.Windows.Forms.RadioButton();
            this.rd16GB = new System.Windows.Forms.RadioButton();
            this.rd32GB = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.gbProcesador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuradorToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.opción1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(989, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuradorToolStripMenuItem
            // 
            this.configuradorToolStripMenuItem.Name = "configuradorToolStripMenuItem";
            this.configuradorToolStripMenuItem.Size = new System.Drawing.Size(126, 27);
            this.configuradorToolStripMenuItem.Text = "Configurador";
            this.configuradorToolStripMenuItem.Click += new System.EventHandler(this.configuradorToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(102, 27);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // opción1ToolStripMenuItem
            // 
            this.opción1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuariosToolStripMenuItem,
            this.cerarSesiónToolStripMenuItem,
            this.finalizarToolStripMenuItem});
            this.opción1ToolStripMenuItem.Name = "opción1ToolStripMenuItem";
            this.opción1ToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.opción1ToolStripMenuItem.Text = "Opciones";
            // 
            // registrarUsuariosToolStripMenuItem
            // 
            this.registrarUsuariosToolStripMenuItem.Name = "registrarUsuariosToolStripMenuItem";
            this.registrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.registrarUsuariosToolStripMenuItem.Text = "Gestión de usuarios";
            this.registrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuariosToolStripMenuItem_Click);
            // 
            // cerarSesiónToolStripMenuItem
            // 
            this.cerarSesiónToolStripMenuItem.Name = "cerarSesiónToolStripMenuItem";
            this.cerarSesiónToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.cerarSesiónToolStripMenuItem.Text = "Cerar sesión";
            this.cerarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerarSesiónToolStripMenuItem_Click);
            // 
            // finalizarToolStripMenuItem
            // 
            this.finalizarToolStripMenuItem.Name = "finalizarToolStripMenuItem";
            this.finalizarToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.finalizarToolStripMenuItem.Text = "Finalizar";
            this.finalizarToolStripMenuItem.Click += new System.EventHandler(this.finalizarToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbOrdenadores
            // 
            this.lbOrdenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrdenadores.FormattingEnabled = true;
            this.lbOrdenadores.ItemHeight = 24;
            this.lbOrdenadores.Location = new System.Drawing.Point(324, 70);
            this.lbOrdenadores.Margin = new System.Windows.Forms.Padding(4);
            this.lbOrdenadores.Name = "lbOrdenadores";
            this.lbOrdenadores.Size = new System.Drawing.Size(301, 316);
            this.lbOrdenadores.TabIndex = 2;
            this.lbOrdenadores.SelectedIndexChanged += new System.EventHandler(this.lbOrdenadores_SelectedIndexChanged);
            // 
            // gbProcesador
            // 
            this.gbProcesador.BackColor = System.Drawing.SystemColors.Control;
            this.gbProcesador.Controls.Add(this.rdIntel);
            this.gbProcesador.Controls.Add(this.rdAMD);
            this.gbProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProcesador.Location = new System.Drawing.Point(36, 70);
            this.gbProcesador.Margin = new System.Windows.Forms.Padding(4);
            this.gbProcesador.Name = "gbProcesador";
            this.gbProcesador.Padding = new System.Windows.Forms.Padding(4);
            this.gbProcesador.Size = new System.Drawing.Size(267, 160);
            this.gbProcesador.TabIndex = 3;
            this.gbProcesador.TabStop = false;
            this.gbProcesador.Text = "Procesador";
            // 
            // rd500
            // 
            this.rd500.AutoSize = true;
            this.rd500.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd500.Location = new System.Drawing.Point(29, 48);
            this.rd500.Margin = new System.Windows.Forms.Padding(4);
            this.rd500.Name = "rd500";
            this.rd500.Size = new System.Drawing.Size(75, 28);
            this.rd500.TabIndex = 4;
            this.rd500.TabStop = true;
            this.rd500.Text = "500€";
            this.rd500.UseVisualStyleBackColor = true;
            this.rd500.CheckedChanged += new System.EventHandler(this.rd500_CheckedChanged);
            // 
            // rd1000
            // 
            this.rd1000.AutoSize = true;
            this.rd1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1000.Location = new System.Drawing.Point(29, 82);
            this.rd1000.Margin = new System.Windows.Forms.Padding(4);
            this.rd1000.Name = "rd1000";
            this.rd1000.Size = new System.Drawing.Size(86, 28);
            this.rd1000.TabIndex = 5;
            this.rd1000.TabStop = true;
            this.rd1000.Text = "1000€";
            this.rd1000.UseVisualStyleBackColor = true;
            this.rd1000.CheckedChanged += new System.EventHandler(this.rd1000_CheckedChanged);
            // 
            // rd1500
            // 
            this.rd1500.AutoSize = true;
            this.rd1500.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1500.Location = new System.Drawing.Point(29, 117);
            this.rd1500.Margin = new System.Windows.Forms.Padding(4);
            this.rd1500.Name = "rd1500";
            this.rd1500.Size = new System.Drawing.Size(86, 28);
            this.rd1500.TabIndex = 6;
            this.rd1500.TabStop = true;
            this.rd1500.Text = "1500€";
            this.rd1500.UseVisualStyleBackColor = true;
            this.rd1500.CheckedChanged += new System.EventHandler(this.rd1500_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.rd5000);
            this.groupBox1.Controls.Add(this.rd3000);
            this.groupBox1.Controls.Add(this.rd500);
            this.groupBox1.Controls.Add(this.rd1500);
            this.groupBox1.Controls.Add(this.rd1000);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(648, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(291, 234);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precio Maximo";
            // 
            // rd5000
            // 
            this.rd5000.AutoSize = true;
            this.rd5000.Location = new System.Drawing.Point(29, 188);
            this.rd5000.Margin = new System.Windows.Forms.Padding(4);
            this.rd5000.Name = "rd5000";
            this.rd5000.Size = new System.Drawing.Size(93, 29);
            this.rd5000.TabIndex = 8;
            this.rd5000.TabStop = true;
            this.rd5000.Text = "5000€";
            this.rd5000.UseVisualStyleBackColor = true;
            this.rd5000.CheckedChanged += new System.EventHandler(this.rd5000_CheckedChanged);
            // 
            // rd3000
            // 
            this.rd3000.AutoSize = true;
            this.rd3000.Location = new System.Drawing.Point(29, 151);
            this.rd3000.Margin = new System.Windows.Forms.Padding(4);
            this.rd3000.Name = "rd3000";
            this.rd3000.Size = new System.Drawing.Size(93, 29);
            this.rd3000.TabIndex = 7;
            this.rd3000.TabStop = true;
            this.rd3000.Text = "3000€";
            this.rd3000.UseVisualStyleBackColor = true;
            this.rd3000.CheckedChanged += new System.EventHandler(this.rd3000_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.rd32GB);
            this.groupBox2.Controls.Add(this.rd16GB);
            this.groupBox2.Controls.Add(this.rd8GB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 238);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 160);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Memoria RAM";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(648, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Limpiar Filtros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(648, 372);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(291, 54);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar Lista";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // rdAMD
            // 
            this.rdAMD.AutoSize = true;
            this.rdAMD.Location = new System.Drawing.Point(27, 48);
            this.rdAMD.Name = "rdAMD";
            this.rdAMD.Size = new System.Drawing.Size(81, 29);
            this.rdAMD.TabIndex = 11;
            this.rdAMD.TabStop = true;
            this.rdAMD.Text = "AMD";
            this.rdAMD.UseVisualStyleBackColor = true;
            this.rdAMD.CheckedChanged += new System.EventHandler(this.rdAMD_CheckedChanged);
            // 
            // rdIntel
            // 
            this.rdIntel.AutoSize = true;
            this.rdIntel.Location = new System.Drawing.Point(27, 83);
            this.rdIntel.Name = "rdIntel";
            this.rdIntel.Size = new System.Drawing.Size(74, 29);
            this.rdIntel.TabIndex = 12;
            this.rdIntel.TabStop = true;
            this.rdIntel.Text = "Intel";
            this.rdIntel.UseVisualStyleBackColor = true;
            this.rdIntel.CheckedChanged += new System.EventHandler(this.rdIntel_CheckedChanged);
            // 
            // rd8GB
            // 
            this.rd8GB.AutoSize = true;
            this.rd8GB.Location = new System.Drawing.Point(27, 37);
            this.rd8GB.Name = "rd8GB";
            this.rd8GB.Size = new System.Drawing.Size(75, 29);
            this.rd8GB.TabIndex = 13;
            this.rd8GB.TabStop = true;
            this.rd8GB.Text = "8GB";
            this.rd8GB.UseVisualStyleBackColor = true;
            this.rd8GB.CheckedChanged += new System.EventHandler(this.rd8GB_CheckedChanged);
            // 
            // rd16GB
            // 
            this.rd16GB.AutoSize = true;
            this.rd16GB.Location = new System.Drawing.Point(27, 72);
            this.rd16GB.Name = "rd16GB";
            this.rd16GB.Size = new System.Drawing.Size(87, 29);
            this.rd16GB.TabIndex = 14;
            this.rd16GB.TabStop = true;
            this.rd16GB.Text = "16GB";
            this.rd16GB.UseVisualStyleBackColor = true;
            this.rd16GB.CheckedChanged += new System.EventHandler(this.rd16GB_CheckedChanged);
            // 
            // rd32GB
            // 
            this.rd32GB.AutoSize = true;
            this.rd32GB.Location = new System.Drawing.Point(27, 107);
            this.rd32GB.Name = "rd32GB";
            this.rd32GB.Size = new System.Drawing.Size(87, 29);
            this.rd32GB.TabIndex = 15;
            this.rd32GB.TabStop = true;
            this.rd32GB.Text = "32GB";
            this.rd32GB.UseVisualStyleBackColor = true;
            this.rd32GB.CheckedChanged += new System.EventHandler(this.rd32GB_CheckedChanged);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 452);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbProcesador);
            this.Controls.Add(this.lbOrdenadores);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
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
        private System.Windows.Forms.ToolStripMenuItem cerarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuradorToolStripMenuItem;
        private System.Windows.Forms.ListBox lbOrdenadores;
        private System.Windows.Forms.GroupBox gbProcesador;
        private System.Windows.Forms.RadioButton rd500;
        private System.Windows.Forms.RadioButton rd1000;
        private System.Windows.Forms.RadioButton rd1500;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd3000;
        private System.Windows.Forms.ToolStripMenuItem finalizarToolStripMenuItem;
        private System.Windows.Forms.RadioButton rd5000;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.RadioButton rdIntel;
        private System.Windows.Forms.RadioButton rdAMD;
        private System.Windows.Forms.RadioButton rd32GB;
        private System.Windows.Forms.RadioButton rd16GB;
        private System.Windows.Forms.RadioButton rd8GB;
    }
}