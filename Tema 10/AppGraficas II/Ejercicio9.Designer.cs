namespace AppGraficas_II
{
    partial class Ejercicio9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio9));
            this.gbPrimerPlato = new System.Windows.Forms.GroupBox();
            this.lblPrecioPrimeroNum = new System.Windows.Forms.Label();
            this.lblPrecioPrimero = new System.Windows.Forms.Label();
            this.pbImages = new System.Windows.Forms.PictureBox();
            this.cbPrimerPlato = new System.Windows.Forms.ComboBox();
            this.rdEmpanada = new System.Windows.Forms.RadioButton();
            this.rdEnsalada = new System.Windows.Forms.RadioButton();
            this.rdCrema = new System.Windows.Forms.RadioButton();
            this.gbSegundoPlato = new System.Windows.Forms.GroupBox();
            this.lblPrecioSegundoNum = new System.Windows.Forms.Label();
            this.lblPrecioSegundo = new System.Windows.Forms.Label();
            this.cbSegundoPlato = new System.Windows.Forms.ComboBox();
            this.rdPasta = new System.Windows.Forms.RadioButton();
            this.rdCarne = new System.Windows.Forms.RadioButton();
            this.rdPescado = new System.Windows.Forms.RadioButton();
            this.gbBebida = new System.Windows.Forms.GroupBox();
            this.lblPrecioBebidaNum = new System.Windows.Forms.Label();
            this.pbBebida = new System.Windows.Forms.PictureBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.rdVino = new System.Windows.Forms.RadioButton();
            this.rdRefresco = new System.Windows.Forms.RadioButton();
            this.rdAgua = new System.Windows.Forms.RadioButton();
            this.gbPostreCafe = new System.Windows.Forms.GroupBox();
            this.cbCafé = new System.Windows.Forms.ComboBox();
            this.cbPostre = new System.Windows.Forms.ComboBox();
            this.rdCafe = new System.Windows.Forms.RadioButton();
            this.rdPostre = new System.Windows.Forms.RadioButton();
            this.btnCalcularCuenta = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.lblVuelta = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPrimerPlato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).BeginInit();
            this.gbSegundoPlato.SuspendLayout();
            this.gbBebida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBebida)).BeginInit();
            this.gbPostreCafe.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrimerPlato
            // 
            this.gbPrimerPlato.Controls.Add(this.lblPrecioPrimeroNum);
            this.gbPrimerPlato.Controls.Add(this.lblPrecioPrimero);
            this.gbPrimerPlato.Controls.Add(this.pbImages);
            this.gbPrimerPlato.Controls.Add(this.cbPrimerPlato);
            this.gbPrimerPlato.Controls.Add(this.rdEmpanada);
            this.gbPrimerPlato.Controls.Add(this.rdEnsalada);
            this.gbPrimerPlato.Controls.Add(this.rdCrema);
            this.gbPrimerPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrimerPlato.Location = new System.Drawing.Point(16, 15);
            this.gbPrimerPlato.Margin = new System.Windows.Forms.Padding(4);
            this.gbPrimerPlato.Name = "gbPrimerPlato";
            this.gbPrimerPlato.Padding = new System.Windows.Forms.Padding(4);
            this.gbPrimerPlato.Size = new System.Drawing.Size(396, 378);
            this.gbPrimerPlato.TabIndex = 4;
            this.gbPrimerPlato.TabStop = false;
            this.gbPrimerPlato.Text = "Primer Plato";
            // 
            // lblPrecioPrimeroNum
            // 
            this.lblPrecioPrimeroNum.AutoSize = true;
            this.lblPrecioPrimeroNum.Location = new System.Drawing.Point(116, 335);
            this.lblPrecioPrimeroNum.Name = "lblPrecioPrimeroNum";
            this.lblPrecioPrimeroNum.Size = new System.Drawing.Size(54, 25);
            this.lblPrecioPrimeroNum.TabIndex = 7;
            this.lblPrecioPrimeroNum.Text = "0,00";
            // 
            // lblPrecioPrimero
            // 
            this.lblPrecioPrimero.AutoSize = true;
            this.lblPrecioPrimero.Location = new System.Drawing.Point(29, 335);
            this.lblPrecioPrimero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioPrimero.Name = "lblPrecioPrimero";
            this.lblPrecioPrimero.Size = new System.Drawing.Size(80, 25);
            this.lblPrecioPrimero.TabIndex = 5;
            this.lblPrecioPrimero.Text = "Precio:";
            // 
            // pbImages
            // 
            this.pbImages.Image = global::AppGraficas_II.Properties.Resources.crema;
            this.pbImages.Location = new System.Drawing.Point(21, 71);
            this.pbImages.Margin = new System.Windows.Forms.Padding(4);
            this.pbImages.Name = "pbImages";
            this.pbImages.Size = new System.Drawing.Size(141, 129);
            this.pbImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImages.TabIndex = 4;
            this.pbImages.TabStop = false;
            // 
            // cbPrimerPlato
            // 
            this.cbPrimerPlato.FormattingEnabled = true;
            this.cbPrimerPlato.Items.AddRange(new object[] {
            "Champiñones",
            "Puerros",
            "Zanahoria"});
            this.cbPrimerPlato.Location = new System.Drawing.Point(212, 167);
            this.cbPrimerPlato.Margin = new System.Windows.Forms.Padding(4);
            this.cbPrimerPlato.Name = "cbPrimerPlato";
            this.cbPrimerPlato.Size = new System.Drawing.Size(160, 33);
            this.cbPrimerPlato.TabIndex = 3;
            this.cbPrimerPlato.SelectedIndexChanged += new System.EventHandler(this.cbPrimerPlato_SelectedIndexChanged);
            // 
            // rdEmpanada
            // 
            this.rdEmpanada.AutoSize = true;
            this.rdEmpanada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEmpanada.Location = new System.Drawing.Point(212, 135);
            this.rdEmpanada.Margin = new System.Windows.Forms.Padding(4);
            this.rdEmpanada.Name = "rdEmpanada";
            this.rdEmpanada.Size = new System.Drawing.Size(117, 24);
            this.rdEmpanada.TabIndex = 2;
            this.rdEmpanada.Text = "Empanada";
            this.rdEmpanada.UseVisualStyleBackColor = true;
            this.rdEmpanada.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdEnsalada
            // 
            this.rdEnsalada.AutoSize = true;
            this.rdEnsalada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEnsalada.Location = new System.Drawing.Point(212, 103);
            this.rdEnsalada.Margin = new System.Windows.Forms.Padding(4);
            this.rdEnsalada.Name = "rdEnsalada";
            this.rdEnsalada.Size = new System.Drawing.Size(107, 24);
            this.rdEnsalada.TabIndex = 1;
            this.rdEnsalada.Text = "Ensalada";
            this.rdEnsalada.UseVisualStyleBackColor = true;
            this.rdEnsalada.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdCrema
            // 
            this.rdCrema.AutoSize = true;
            this.rdCrema.Checked = true;
            this.rdCrema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCrema.Location = new System.Drawing.Point(212, 71);
            this.rdCrema.Margin = new System.Windows.Forms.Padding(4);
            this.rdCrema.Name = "rdCrema";
            this.rdCrema.Size = new System.Drawing.Size(85, 24);
            this.rdCrema.TabIndex = 0;
            this.rdCrema.TabStop = true;
            this.rdCrema.Text = "Crema";
            this.rdCrema.UseVisualStyleBackColor = true;
            this.rdCrema.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gbSegundoPlato
            // 
            this.gbSegundoPlato.Controls.Add(this.lblPrecioSegundoNum);
            this.gbSegundoPlato.Controls.Add(this.lblPrecioSegundo);
            this.gbSegundoPlato.Controls.Add(this.cbSegundoPlato);
            this.gbSegundoPlato.Controls.Add(this.rdPasta);
            this.gbSegundoPlato.Controls.Add(this.rdCarne);
            this.gbSegundoPlato.Controls.Add(this.rdPescado);
            this.gbSegundoPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSegundoPlato.Location = new System.Drawing.Point(420, 15);
            this.gbSegundoPlato.Margin = new System.Windows.Forms.Padding(4);
            this.gbSegundoPlato.Name = "gbSegundoPlato";
            this.gbSegundoPlato.Padding = new System.Windows.Forms.Padding(4);
            this.gbSegundoPlato.Size = new System.Drawing.Size(267, 378);
            this.gbSegundoPlato.TabIndex = 5;
            this.gbSegundoPlato.TabStop = false;
            this.gbSegundoPlato.Text = "Segundo Plato";
            // 
            // lblPrecioSegundoNum
            // 
            this.lblPrecioSegundoNum.AutoSize = true;
            this.lblPrecioSegundoNum.Location = new System.Drawing.Point(105, 336);
            this.lblPrecioSegundoNum.Name = "lblPrecioSegundoNum";
            this.lblPrecioSegundoNum.Size = new System.Drawing.Size(49, 24);
            this.lblPrecioSegundoNum.TabIndex = 7;
            this.lblPrecioSegundoNum.Text = "0,00";
            // 
            // lblPrecioSegundo
            // 
            this.lblPrecioSegundo.AutoSize = true;
            this.lblPrecioSegundo.Location = new System.Drawing.Point(23, 336);
            this.lblPrecioSegundo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioSegundo.Name = "lblPrecioSegundo";
            this.lblPrecioSegundo.Size = new System.Drawing.Size(76, 24);
            this.lblPrecioSegundo.TabIndex = 6;
            this.lblPrecioSegundo.Text = "Precio:";
            // 
            // cbSegundoPlato
            // 
            this.cbSegundoPlato.FormattingEnabled = true;
            this.cbSegundoPlato.Location = new System.Drawing.Point(57, 167);
            this.cbSegundoPlato.Margin = new System.Windows.Forms.Padding(4);
            this.cbSegundoPlato.Name = "cbSegundoPlato";
            this.cbSegundoPlato.Size = new System.Drawing.Size(160, 32);
            this.cbSegundoPlato.TabIndex = 3;
            // 
            // rdPasta
            // 
            this.rdPasta.AutoSize = true;
            this.rdPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPasta.Location = new System.Drawing.Point(57, 135);
            this.rdPasta.Margin = new System.Windows.Forms.Padding(4);
            this.rdPasta.Name = "rdPasta";
            this.rdPasta.Size = new System.Drawing.Size(78, 24);
            this.rdPasta.TabIndex = 2;
            this.rdPasta.Text = "Pasta";
            this.rdPasta.UseVisualStyleBackColor = true;
            // 
            // rdCarne
            // 
            this.rdCarne.AutoSize = true;
            this.rdCarne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCarne.Location = new System.Drawing.Point(57, 103);
            this.rdCarne.Margin = new System.Windows.Forms.Padding(4);
            this.rdCarne.Name = "rdCarne";
            this.rdCarne.Size = new System.Drawing.Size(80, 24);
            this.rdCarne.TabIndex = 1;
            this.rdCarne.Text = "Carne";
            this.rdCarne.UseVisualStyleBackColor = true;
            // 
            // rdPescado
            // 
            this.rdPescado.AutoSize = true;
            this.rdPescado.Checked = true;
            this.rdPescado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPescado.Location = new System.Drawing.Point(57, 71);
            this.rdPescado.Margin = new System.Windows.Forms.Padding(4);
            this.rdPescado.Name = "rdPescado";
            this.rdPescado.Size = new System.Drawing.Size(102, 24);
            this.rdPescado.TabIndex = 0;
            this.rdPescado.TabStop = true;
            this.rdPescado.Text = "Pescado";
            this.rdPescado.UseVisualStyleBackColor = true;
            // 
            // gbBebida
            // 
            this.gbBebida.Controls.Add(this.lblPrecioBebidaNum);
            this.gbBebida.Controls.Add(this.pbBebida);
            this.gbBebida.Controls.Add(this.lblPrecio);
            this.gbBebida.Controls.Add(this.rdVino);
            this.gbBebida.Controls.Add(this.rdRefresco);
            this.gbBebida.Controls.Add(this.rdAgua);
            this.gbBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBebida.Location = new System.Drawing.Point(695, 15);
            this.gbBebida.Margin = new System.Windows.Forms.Padding(4);
            this.gbBebida.Name = "gbBebida";
            this.gbBebida.Padding = new System.Windows.Forms.Padding(4);
            this.gbBebida.Size = new System.Drawing.Size(267, 160);
            this.gbBebida.TabIndex = 6;
            this.gbBebida.TabStop = false;
            this.gbBebida.Text = "Bebida";
            // 
            // lblPrecioBebidaNum
            // 
            this.lblPrecioBebidaNum.AutoSize = true;
            this.lblPrecioBebidaNum.Location = new System.Drawing.Point(89, 128);
            this.lblPrecioBebidaNum.Name = "lblPrecioBebidaNum";
            this.lblPrecioBebidaNum.Size = new System.Drawing.Size(44, 20);
            this.lblPrecioBebidaNum.TabIndex = 5;
            this.lblPrecioBebidaNum.Text = "1,50";
            // 
            // pbBebida
            // 
            this.pbBebida.Image = global::AppGraficas_II.Properties.Resources.agua;
            this.pbBebida.Location = new System.Drawing.Point(147, 24);
            this.pbBebida.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pbBebida.Name = "pbBebida";
            this.pbBebida.Size = new System.Drawing.Size(95, 84);
            this.pbBebida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBebida.TabIndex = 4;
            this.pbBebida.TabStop = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(23, 128);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(69, 20);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // rdVino
            // 
            this.rdVino.AutoSize = true;
            this.rdVino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdVino.Location = new System.Drawing.Point(25, 84);
            this.rdVino.Margin = new System.Windows.Forms.Padding(4);
            this.rdVino.Name = "rdVino";
            this.rdVino.Size = new System.Drawing.Size(61, 21);
            this.rdVino.TabIndex = 2;
            this.rdVino.Text = "Vino";
            this.rdVino.UseVisualStyleBackColor = true;
            this.rdVino.CheckedChanged += new System.EventHandler(this.rdVino_CheckedChanged);
            // 
            // rdRefresco
            // 
            this.rdRefresco.AutoSize = true;
            this.rdRefresco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRefresco.Location = new System.Drawing.Point(25, 58);
            this.rdRefresco.Margin = new System.Windows.Forms.Padding(4);
            this.rdRefresco.Name = "rdRefresco";
            this.rdRefresco.Size = new System.Drawing.Size(94, 21);
            this.rdRefresco.TabIndex = 1;
            this.rdRefresco.Text = "Refresco";
            this.rdRefresco.UseVisualStyleBackColor = true;
            this.rdRefresco.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // rdAgua
            // 
            this.rdAgua.AutoSize = true;
            this.rdAgua.Checked = true;
            this.rdAgua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAgua.Location = new System.Drawing.Point(25, 33);
            this.rdAgua.Margin = new System.Windows.Forms.Padding(4);
            this.rdAgua.Name = "rdAgua";
            this.rdAgua.Size = new System.Drawing.Size(66, 21);
            this.rdAgua.TabIndex = 0;
            this.rdAgua.TabStop = true;
            this.rdAgua.Text = "Agua";
            this.rdAgua.UseVisualStyleBackColor = true;
            this.rdAgua.CheckedChanged += new System.EventHandler(this.rdAgua_CheckedChanged);
            // 
            // gbPostreCafe
            // 
            this.gbPostreCafe.Controls.Add(this.cbCafé);
            this.gbPostreCafe.Controls.Add(this.cbPostre);
            this.gbPostreCafe.Controls.Add(this.rdCafe);
            this.gbPostreCafe.Controls.Add(this.rdPostre);
            this.gbPostreCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPostreCafe.Location = new System.Drawing.Point(695, 177);
            this.gbPostreCafe.Margin = new System.Windows.Forms.Padding(4);
            this.gbPostreCafe.Name = "gbPostreCafe";
            this.gbPostreCafe.Padding = new System.Windows.Forms.Padding(4);
            this.gbPostreCafe.Size = new System.Drawing.Size(267, 214);
            this.gbPostreCafe.TabIndex = 7;
            this.gbPostreCafe.TabStop = false;
            this.gbPostreCafe.Text = "Postre/Café";
            // 
            // cbCafé
            // 
            this.cbCafé.FormattingEnabled = true;
            this.cbCafé.Location = new System.Drawing.Point(8, 145);
            this.cbCafé.Margin = new System.Windows.Forms.Padding(4);
            this.cbCafé.Name = "cbCafé";
            this.cbCafé.Size = new System.Drawing.Size(160, 28);
            this.cbCafé.TabIndex = 8;
            // 
            // cbPostre
            // 
            this.cbPostre.FormattingEnabled = true;
            this.cbPostre.Location = new System.Drawing.Point(8, 76);
            this.cbPostre.Margin = new System.Windows.Forms.Padding(4);
            this.cbPostre.Name = "cbPostre";
            this.cbPostre.Size = new System.Drawing.Size(160, 28);
            this.cbPostre.TabIndex = 2;
            // 
            // rdCafe
            // 
            this.rdCafe.AutoSize = true;
            this.rdCafe.Location = new System.Drawing.Point(8, 113);
            this.rdCafe.Margin = new System.Windows.Forms.Padding(4);
            this.rdCafe.Name = "rdCafe";
            this.rdCafe.Size = new System.Drawing.Size(69, 24);
            this.rdCafe.TabIndex = 1;
            this.rdCafe.Text = "Café";
            this.rdCafe.UseVisualStyleBackColor = true;
            // 
            // rdPostre
            // 
            this.rdPostre.AutoSize = true;
            this.rdPostre.Checked = true;
            this.rdPostre.Location = new System.Drawing.Point(8, 44);
            this.rdPostre.Margin = new System.Windows.Forms.Padding(4);
            this.rdPostre.Name = "rdPostre";
            this.rdPostre.Size = new System.Drawing.Size(85, 24);
            this.rdPostre.TabIndex = 0;
            this.rdPostre.TabStop = true;
            this.rdPostre.Text = "Postre";
            this.rdPostre.UseVisualStyleBackColor = true;
            // 
            // btnCalcularCuenta
            // 
            this.btnCalcularCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularCuenta.Location = new System.Drawing.Point(16, 421);
            this.btnCalcularCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcularCuenta.Name = "btnCalcularCuenta";
            this.btnCalcularCuenta.Size = new System.Drawing.Size(184, 53);
            this.btnCalcularCuenta.TabIndex = 5;
            this.btnCalcularCuenta.Text = "Calcular cuenta";
            this.btnCalcularCuenta.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(776, 417);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(777, 454);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(544, 422);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(143, 53);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Location = new System.Drawing.Point(707, 421);
            this.lblEfectivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(55, 16);
            this.lblEfectivo.TabIndex = 11;
            this.lblEfectivo.Text = "Efectivo";
            // 
            // lblVuelta
            // 
            this.lblVuelta.AutoSize = true;
            this.lblVuelta.Location = new System.Drawing.Point(720, 458);
            this.lblVuelta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVuelta.Name = "lblVuelta";
            this.lblVuelta.Size = new System.Drawing.Size(45, 16);
            this.lblVuelta.TabIndex = 12;
            this.lblVuelta.Text = "Vuelta";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(279, 421);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(279, 453);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 425);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "11% IVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 458);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total";
            // 
            // Ejercicio9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 505);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblVuelta);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalcularCuenta);
            this.Controls.Add(this.gbPostreCafe);
            this.Controls.Add(this.gbBebida);
            this.Controls.Add(this.gbSegundoPlato);
            this.Controls.Add(this.gbPrimerPlato);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ejercicio9";
            this.Text = "Ejercicio 9";
            this.gbPrimerPlato.ResumeLayout(false);
            this.gbPrimerPlato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImages)).EndInit();
            this.gbSegundoPlato.ResumeLayout(false);
            this.gbSegundoPlato.PerformLayout();
            this.gbBebida.ResumeLayout(false);
            this.gbBebida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBebida)).EndInit();
            this.gbPostreCafe.ResumeLayout(false);
            this.gbPostreCafe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrimerPlato;
        private System.Windows.Forms.GroupBox gbSegundoPlato;
        private System.Windows.Forms.GroupBox gbBebida;
        private System.Windows.Forms.GroupBox gbPostreCafe;
        private System.Windows.Forms.PictureBox pbImages;
        private System.Windows.Forms.ComboBox cbPrimerPlato;
        private System.Windows.Forms.RadioButton rdEmpanada;
        private System.Windows.Forms.RadioButton rdEnsalada;
        private System.Windows.Forms.RadioButton rdCrema;
        private System.Windows.Forms.Label lblPrecioPrimero;
        private System.Windows.Forms.Label lblPrecioSegundo;
        private System.Windows.Forms.ComboBox cbSegundoPlato;
        private System.Windows.Forms.RadioButton rdPasta;
        private System.Windows.Forms.RadioButton rdCarne;
        private System.Windows.Forms.RadioButton rdPescado;
        private System.Windows.Forms.RadioButton rdVino;
        private System.Windows.Forms.RadioButton rdRefresco;
        private System.Windows.Forms.RadioButton rdAgua;
        private System.Windows.Forms.Button btnCalcularCuenta;
        private System.Windows.Forms.RadioButton rdCafe;
        private System.Windows.Forms.RadioButton rdPostre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cbCafé;
        private System.Windows.Forms.ComboBox cbPostre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Label lblVuelta;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbBebida;
        private System.Windows.Forms.Label lblPrecioPrimeroNum;
        private System.Windows.Forms.Label lblPrecioSegundoNum;
        private System.Windows.Forms.Label lblPrecioBebidaNum;
    }
}