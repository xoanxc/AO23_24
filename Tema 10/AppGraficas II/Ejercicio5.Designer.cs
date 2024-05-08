namespace AppGraficas_II
{
    partial class Ejercicio5
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
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblEligeTurno = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.cbEligeTurno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMañana = new System.Windows.Forms.ListBox();
            this.lbNoche = new System.Windows.Forms.ListBox();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnDerechazo = new System.Windows.Forms.Button();
            this.btnIzquierdazo = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalMañana = new System.Windows.Forms.TextBox();
            this.txtTotalNoche = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(23, 27);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(197, 20);
            this.lblNombreEmpleado.TabIndex = 0;
            this.lblNombreEmpleado.Text = "Nombre del empleado:";
            // 
            // lblEligeTurno
            // 
            this.lblEligeTurno.AutoSize = true;
            this.lblEligeTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEligeTurno.Location = new System.Drawing.Point(23, 84);
            this.lblEligeTurno.Name = "lblEligeTurno";
            this.lblEligeTurno.Size = new System.Drawing.Size(132, 20);
            this.lblEligeTurno.TabIndex = 1;
            this.lblEligeTurno.Text = "Elige el Turno:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(251, 28);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(220, 22);
            this.txtNombreEmpleado.TabIndex = 2;
            // 
            // cbEligeTurno
            // 
            this.cbEligeTurno.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbEligeTurno.FormattingEnabled = true;
            this.cbEligeTurno.Items.AddRange(new object[] {
            "Mañana",
            "Noche"});
            this.cbEligeTurno.Location = new System.Drawing.Point(183, 84);
            this.cbEligeTurno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEligeTurno.Name = "cbEligeTurno";
            this.cbEligeTurno.Size = new System.Drawing.Size(288, 24);
            this.cbEligeTurno.TabIndex = 3;
            this.cbEligeTurno.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Turno Mañana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Turno Noche";
            // 
            // lbMañana
            // 
            this.lbMañana.FormattingEnabled = true;
            this.lbMañana.ItemHeight = 16;
            this.lbMañana.Location = new System.Drawing.Point(27, 182);
            this.lbMañana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMañana.Name = "lbMañana";
            this.lbMañana.Size = new System.Drawing.Size(200, 164);
            this.lbMañana.TabIndex = 6;
            // 
            // lbNoche
            // 
            this.lbNoche.FormattingEnabled = true;
            this.lbNoche.ItemHeight = 16;
            this.lbNoche.Location = new System.Drawing.Point(287, 182);
            this.lbNoche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbNoche.Name = "lbNoche";
            this.lbNoche.Size = new System.Drawing.Size(184, 164);
            this.lbNoche.TabIndex = 7;
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(231, 198);
            this.btnDerecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(49, 31);
            this.btnDerecha.TabIndex = 11;
            this.btnDerecha.Text = ">";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnDerechazo
            // 
            this.btnDerechazo.Location = new System.Drawing.Point(231, 234);
            this.btnDerechazo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDerechazo.Name = "btnDerechazo";
            this.btnDerechazo.Size = new System.Drawing.Size(49, 31);
            this.btnDerechazo.TabIndex = 12;
            this.btnDerechazo.Text = ">>";
            this.btnDerechazo.UseVisualStyleBackColor = true;
            this.btnDerechazo.Click += new System.EventHandler(this.btnDerechazo_Click);
            // 
            // btnIzquierdazo
            // 
            this.btnIzquierdazo.Location = new System.Drawing.Point(231, 271);
            this.btnIzquierdazo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzquierdazo.Name = "btnIzquierdazo";
            this.btnIzquierdazo.Size = new System.Drawing.Size(49, 31);
            this.btnIzquierdazo.TabIndex = 13;
            this.btnIzquierdazo.Text = "<<";
            this.btnIzquierdazo.UseVisualStyleBackColor = true;
            this.btnIzquierdazo.Click += new System.EventHandler(this.btnIzquierdazo_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(231, 306);
            this.btnIzquierda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(49, 31);
            this.btnIzquierda.TabIndex = 14;
            this.btnIzquierda.Text = "<";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total Mañana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total Noche";
            // 
            // txtTotalMañana
            // 
            this.txtTotalMañana.Location = new System.Drawing.Point(159, 362);
            this.txtTotalMañana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalMañana.Name = "txtTotalMañana";
            this.txtTotalMañana.Size = new System.Drawing.Size(67, 22);
            this.txtTotalMañana.TabIndex = 18;
            // 
            // txtTotalNoche
            // 
            this.txtTotalNoche.Location = new System.Drawing.Point(404, 362);
            this.txtTotalNoche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalNoche.Name = "txtTotalNoche";
            this.txtTotalNoche.Size = new System.Drawing.Size(67, 22);
            this.txtTotalNoche.TabIndex = 19;
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 410);
            this.Controls.Add(this.txtTotalNoche);
            this.Controls.Add(this.txtTotalMañana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnIzquierdazo);
            this.Controls.Add(this.btnDerechazo);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.lbNoche);
            this.Controls.Add(this.lbMañana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEligeTurno);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.lblEligeTurno);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(523, 457);
            this.MinimumSize = new System.Drawing.Size(523, 457);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblEligeTurno;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.ComboBox cbEligeTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbMañana;
        private System.Windows.Forms.ListBox lbNoche;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnDerechazo;
        private System.Windows.Forms.Button btnIzquierdazo;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalMañana;
        private System.Windows.Forms.TextBox txtTotalNoche;
    }
}