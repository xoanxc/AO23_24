﻿namespace PROYECTO_FINAL
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
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opción1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbOrdenadores = new System.Windows.Forms.ListBox();
            this.gbProcesador = new System.Windows.Forms.GroupBox();
            this.rdIntel = new System.Windows.Forms.RadioButton();
            this.rdAMD = new System.Windows.Forms.RadioButton();
            this.rd500 = new System.Windows.Forms.RadioButton();
            this.rd1000 = new System.Windows.Forms.RadioButton();
            this.rd1500 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd5000 = new System.Windows.Forms.RadioButton();
            this.rd3000 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd32GB = new System.Windows.Forms.RadioButton();
            this.rd16GB = new System.Windows.Forms.RadioButton();
            this.rd8GB = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(742, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuradorToolStripMenuItem
            // 
            this.configuradorToolStripMenuItem.Name = "configuradorToolStripMenuItem";
            this.configuradorToolStripMenuItem.Size = new System.Drawing.Size(104, 23);
            this.configuradorToolStripMenuItem.Text = "Configurador";
            this.configuradorToolStripMenuItem.Click += new System.EventHandler(this.configuradorToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem,
            this.equipoosToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.componentesToolStripMenuItem.Text = "Componentes";
            this.componentesToolStripMenuItem.Click += new System.EventHandler(this.componentesToolStripMenuItem_Click);
            // 
            // equipoosToolStripMenuItem
            // 
            this.equipoosToolStripMenuItem.Name = "equipoosToolStripMenuItem";
            this.equipoosToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.equipoosToolStripMenuItem.Text = "Equipoos";
            this.equipoosToolStripMenuItem.Click += new System.EventHandler(this.equipoosToolStripMenuItem_Click);
            // 
            // opción1ToolStripMenuItem
            // 
            this.opción1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuariosToolStripMenuItem,
            this.cerarSesiónToolStripMenuItem});
            this.opción1ToolStripMenuItem.Name = "opción1ToolStripMenuItem";
            this.opción1ToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.opción1ToolStripMenuItem.Text = "Opciones";
            // 
            // registrarUsuariosToolStripMenuItem
            // 
            this.registrarUsuariosToolStripMenuItem.Name = "registrarUsuariosToolStripMenuItem";
            this.registrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.registrarUsuariosToolStripMenuItem.Text = "Gestión de usuarios";
            this.registrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registrarUsuariosToolStripMenuItem_Click);
            // 
            // cerarSesiónToolStripMenuItem
            // 
            this.cerarSesiónToolStripMenuItem.Name = "cerarSesiónToolStripMenuItem";
            this.cerarSesiónToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.cerarSesiónToolStripMenuItem.Text = "Cerar sesión";
            this.cerarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerarSesiónToolStripMenuItem_Click);
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
            this.lbOrdenadores.ItemHeight = 18;
            this.lbOrdenadores.Location = new System.Drawing.Point(243, 57);
            this.lbOrdenadores.Name = "lbOrdenadores";
            this.lbOrdenadores.Size = new System.Drawing.Size(227, 274);
            this.lbOrdenadores.TabIndex = 2;
            this.lbOrdenadores.SelectedIndexChanged += new System.EventHandler(this.lbOrdenadores_SelectedIndexChanged);
            // 
            // gbProcesador
            // 
            this.gbProcesador.BackColor = System.Drawing.Color.Transparent;
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
            this.rdIntel.Location = new System.Drawing.Point(20, 67);
            this.rdIntel.Margin = new System.Windows.Forms.Padding(2);
            this.rdIntel.Name = "rdIntel";
            this.rdIntel.Size = new System.Drawing.Size(63, 24);
            this.rdIntel.TabIndex = 12;
            this.rdIntel.TabStop = true;
            this.rdIntel.Text = "Intel";
            this.rdIntel.UseVisualStyleBackColor = true;
            this.rdIntel.CheckedChanged += new System.EventHandler(this.rdIntel_CheckedChanged);
            // 
            // rdAMD
            // 
            this.rdAMD.AutoSize = true;
            this.rdAMD.Location = new System.Drawing.Point(20, 39);
            this.rdAMD.Margin = new System.Windows.Forms.Padding(2);
            this.rdAMD.Name = "rdAMD";
            this.rdAMD.Size = new System.Drawing.Size(66, 24);
            this.rdAMD.TabIndex = 11;
            this.rdAMD.TabStop = true;
            this.rdAMD.Text = "AMD";
            this.rdAMD.UseVisualStyleBackColor = true;
            this.rdAMD.CheckedChanged += new System.EventHandler(this.rdAMD_CheckedChanged);
            // 
            // rd500
            // 
            this.rd500.AutoSize = true;
            this.rd500.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd500.Location = new System.Drawing.Point(22, 39);
            this.rd500.Name = "rd500";
            this.rd500.Size = new System.Drawing.Size(62, 22);
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
            this.rd1000.Location = new System.Drawing.Point(22, 67);
            this.rd1000.Name = "rd1000";
            this.rd1000.Size = new System.Drawing.Size(71, 22);
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
            this.rd1500.Location = new System.Drawing.Point(22, 95);
            this.rd1500.Name = "rd1500";
            this.rd1500.Size = new System.Drawing.Size(71, 22);
            this.rd1500.TabIndex = 6;
            this.rd1500.TabStop = true;
            this.rd1500.Text = "1500€";
            this.rd1500.UseVisualStyleBackColor = true;
            this.rd1500.CheckedChanged += new System.EventHandler(this.rd1500_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rd5000);
            this.groupBox1.Controls.Add(this.rd3000);
            this.groupBox1.Controls.Add(this.rd500);
            this.groupBox1.Controls.Add(this.rd1500);
            this.groupBox1.Controls.Add(this.rd1000);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(486, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 190);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precio Maximo";
            // 
            // rd5000
            // 
            this.rd5000.AutoSize = true;
            this.rd5000.Location = new System.Drawing.Point(22, 153);
            this.rd5000.Name = "rd5000";
            this.rd5000.Size = new System.Drawing.Size(77, 24);
            this.rd5000.TabIndex = 8;
            this.rd5000.TabStop = true;
            this.rd5000.Text = "5000€";
            this.rd5000.UseVisualStyleBackColor = true;
            this.rd5000.CheckedChanged += new System.EventHandler(this.rd5000_CheckedChanged);
            // 
            // rd3000
            // 
            this.rd3000.AutoSize = true;
            this.rd3000.Location = new System.Drawing.Point(22, 123);
            this.rd3000.Name = "rd3000";
            this.rd3000.Size = new System.Drawing.Size(77, 24);
            this.rd3000.TabIndex = 7;
            this.rd3000.TabStop = true;
            this.rd3000.Text = "3000€";
            this.rd3000.UseVisualStyleBackColor = true;
            this.rd3000.CheckedChanged += new System.EventHandler(this.rd3000_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rd32GB);
            this.groupBox2.Controls.Add(this.rd16GB);
            this.groupBox2.Controls.Add(this.rd8GB);
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
            this.rd32GB.Location = new System.Drawing.Point(20, 87);
            this.rd32GB.Margin = new System.Windows.Forms.Padding(2);
            this.rd32GB.Name = "rd32GB";
            this.rd32GB.Size = new System.Drawing.Size(73, 24);
            this.rd32GB.TabIndex = 15;
            this.rd32GB.TabStop = true;
            this.rd32GB.Text = "32GB";
            this.rd32GB.UseVisualStyleBackColor = true;
            this.rd32GB.CheckedChanged += new System.EventHandler(this.rd32GB_CheckedChanged);
            // 
            // rd16GB
            // 
            this.rd16GB.AutoSize = true;
            this.rd16GB.Location = new System.Drawing.Point(20, 58);
            this.rd16GB.Margin = new System.Windows.Forms.Padding(2);
            this.rd16GB.Name = "rd16GB";
            this.rd16GB.Size = new System.Drawing.Size(73, 24);
            this.rd16GB.TabIndex = 14;
            this.rd16GB.TabStop = true;
            this.rd16GB.Text = "16GB";
            this.rd16GB.UseVisualStyleBackColor = true;
            this.rd16GB.CheckedChanged += new System.EventHandler(this.rd16GB_CheckedChanged);
            // 
            // rd8GB
            // 
            this.rd8GB.AutoSize = true;
            this.rd8GB.Location = new System.Drawing.Point(20, 30);
            this.rd8GB.Margin = new System.Windows.Forms.Padding(2);
            this.rd8GB.Name = "rd8GB";
            this.rd8GB.Size = new System.Drawing.Size(63, 24);
            this.rd8GB.TabIndex = 13;
            this.rd8GB.TabStop = true;
            this.rd8GB.Text = "8GB";
            this.rd8GB.UseVisualStyleBackColor = true;
            this.rd8GB.CheckedChanged += new System.EventHandler(this.rd8GB_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(486, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Limpiar Filtros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(486, 302);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(218, 44);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar Lista";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO_FINAL.Properties.Resources.Background_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 367);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbProcesador);
            this.Controls.Add(this.lbOrdenadores);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
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
        private System.Windows.Forms.RadioButton rd5000;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.RadioButton rdIntel;
        private System.Windows.Forms.RadioButton rdAMD;
        private System.Windows.Forms.RadioButton rd32GB;
        private System.Windows.Forms.RadioButton rd16GB;
        private System.Windows.Forms.RadioButton rd8GB;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipoosToolStripMenuItem;
    }
}