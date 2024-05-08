namespace AppGraficas_II
{
    partial class Ejercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio2));
            this.SeleccionaUnCurso = new System.Windows.Forms.Label();
            this.SusAsignaturasSon = new System.Windows.Forms.Label();
            this.rd1GMI = new System.Windows.Forms.RadioButton();
            this.rd2GMI = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SeleccionaUnCurso
            // 
            this.SeleccionaUnCurso.AutoSize = true;
            this.SeleccionaUnCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionaUnCurso.Location = new System.Drawing.Point(36, 48);
            this.SeleccionaUnCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SeleccionaUnCurso.Name = "SeleccionaUnCurso";
            this.SeleccionaUnCurso.Size = new System.Drawing.Size(202, 24);
            this.SeleccionaUnCurso.TabIndex = 0;
            this.SeleccionaUnCurso.Text = "Selecciona un curso";
            // 
            // SusAsignaturasSon
            // 
            this.SusAsignaturasSon.AutoSize = true;
            this.SusAsignaturasSon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SusAsignaturasSon.Location = new System.Drawing.Point(335, 48);
            this.SusAsignaturasSon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SusAsignaturasSon.Name = "SusAsignaturasSon";
            this.SusAsignaturasSon.Size = new System.Drawing.Size(203, 24);
            this.SusAsignaturasSon.TabIndex = 1;
            this.SusAsignaturasSon.Text = "Sus asignaturas son:";
            // 
            // rd1GMI
            // 
            this.rd1GMI.AutoSize = true;
            this.rd1GMI.Checked = true;
            this.rd1GMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1GMI.Location = new System.Drawing.Point(40, 150);
            this.rd1GMI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd1GMI.Name = "rd1GMI";
            this.rd1GMI.Size = new System.Drawing.Size(81, 24);
            this.rd1GMI.TabIndex = 2;
            this.rd1GMI.TabStop = true;
            this.rd1GMI.Text = "1º GMI";
            this.rd1GMI.UseVisualStyleBackColor = true;
            this.rd1GMI.CheckedChanged += new System.EventHandler(this.rd1GMI_CheckedChanged);
            // 
            // rd2GMI
            // 
            this.rd2GMI.AutoSize = true;
            this.rd2GMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2GMI.Location = new System.Drawing.Point(40, 193);
            this.rd2GMI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rd2GMI.Name = "rd2GMI";
            this.rd2GMI.Size = new System.Drawing.Size(81, 24);
            this.rd2GMI.TabIndex = 3;
            this.rd2GMI.Text = "2º GMI";
            this.rd2GMI.UseVisualStyleBackColor = true;
            this.rd2GMI.CheckedChanged += new System.EventHandler(this.rd2GMI_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "Aplicaciones Ofimáticas",
            "Formación y Orientación Laboral",
            "Montaje y Mantenimiento de Equipos",
            "Redes Locales",
            "Sistemas Operativos Monopuestos"});
            this.listBox1.Location = new System.Drawing.Point(339, 124);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(311, 166);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 341);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rd2GMI);
            this.Controls.Add(this.rd1GMI);
            this.Controls.Add(this.SusAsignaturasSon);
            this.Controls.Add(this.SeleccionaUnCurso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(719, 388);
            this.MinimumSize = new System.Drawing.Size(719, 388);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SeleccionaUnCurso;
        private System.Windows.Forms.Label SusAsignaturasSon;
        private System.Windows.Forms.RadioButton rd1GMI;
        private System.Windows.Forms.RadioButton rd2GMI;
        private System.Windows.Forms.ListBox listBox1;
    }
}