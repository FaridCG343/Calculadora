namespace Calculadora
{
    partial class frmcgfCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcgfCalculadora));
            this.btncgfNegar = new System.Windows.Forms.Button();
            this.pnlcgfNavBar = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbcgfIcon = new System.Windows.Forms.PictureBox();
            this.pbcgfMin = new System.Windows.Forms.PictureBox();
            this.pbcgfCerrar = new System.Windows.Forms.PictureBox();
            this.btncgfNum0 = new System.Windows.Forms.Button();
            this.bntcgfPunto = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btncgfSuma = new System.Windows.Forms.Button();
            this.btncgfNum3 = new System.Windows.Forms.Button();
            this.btncgfNum2 = new System.Windows.Forms.Button();
            this.btncgfNum1 = new System.Windows.Forms.Button();
            this.btncgfMultiplicar = new System.Windows.Forms.Button();
            this.btncgfNum9 = new System.Windows.Forms.Button();
            this.btncgfNum8 = new System.Windows.Forms.Button();
            this.btncgfNum7 = new System.Windows.Forms.Button();
            this.btncgfResta = new System.Windows.Forms.Button();
            this.btncgfNum6 = new System.Windows.Forms.Button();
            this.btncgfNum5 = new System.Windows.Forms.Button();
            this.btncgfNum4 = new System.Windows.Forms.Button();
            this.brncgfBorrar = new System.Windows.Forms.Button();
            this.btncgfClear = new System.Windows.Forms.Button();
            this.btncgfClearE = new System.Windows.Forms.Button();
            this.btncgfPercentage = new System.Windows.Forms.Button();
            this.btncgfDividir = new System.Windows.Forms.Button();
            this.btncgfRaiz = new System.Windows.Forms.Button();
            this.btncgfCuadrado = new System.Windows.Forms.Button();
            this.btncgfSobreUno = new System.Windows.Forms.Button();
            this.lblcgfNum = new System.Windows.Forms.Label();
            this.lblcgfOperacion = new System.Windows.Forms.Label();
            this.pnlcgfNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcgfIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcgfMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcgfCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btncgfNegar
            // 
            this.btncgfNegar.BackColor = System.Drawing.Color.DimGray;
            this.btncgfNegar.FlatAppearance.BorderSize = 0;
            this.btncgfNegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfNegar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfNegar.ForeColor = System.Drawing.Color.White;
            this.btncgfNegar.Location = new System.Drawing.Point(3, 398);
            this.btncgfNegar.Name = "btncgfNegar";
            this.btncgfNegar.Size = new System.Drawing.Size(75, 45);
            this.btncgfNegar.TabIndex = 0;
            this.btncgfNegar.Text = "+/-";
            this.btncgfNegar.UseVisualStyleBackColor = false;
            this.btncgfNegar.Click += new System.EventHandler(this.btncgfSigno_Click);
            // 
            // pnlcgfNavBar
            // 
            this.pnlcgfNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlcgfNavBar.Controls.Add(this.lblTitulo);
            this.pnlcgfNavBar.Controls.Add(this.pbcgfIcon);
            this.pnlcgfNavBar.Controls.Add(this.pbcgfMin);
            this.pnlcgfNavBar.Controls.Add(this.pbcgfCerrar);
            this.pnlcgfNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlcgfNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnlcgfNavBar.Name = "pnlcgfNavBar";
            this.pnlcgfNavBar.Size = new System.Drawing.Size(325, 35);
            this.pnlcgfNavBar.TabIndex = 1;
            this.pnlcgfNavBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlcgfNavBar_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(47, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 21);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Calculadora";
            // 
            // pbcgfIcon
            // 
            this.pbcgfIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbcgfIcon.Image = global::Calculadora.Properties.Resources.calculadora;
            this.pbcgfIcon.Location = new System.Drawing.Point(16, 5);
            this.pbcgfIcon.Name = "pbcgfIcon";
            this.pbcgfIcon.Size = new System.Drawing.Size(25, 25);
            this.pbcgfIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcgfIcon.TabIndex = 4;
            this.pbcgfIcon.TabStop = false;
            // 
            // pbcgfMin
            // 
            this.pbcgfMin.BackColor = System.Drawing.Color.Transparent;
            this.pbcgfMin.Image = global::Calculadora.Properties.Resources.min;
            this.pbcgfMin.Location = new System.Drawing.Point(260, 5);
            this.pbcgfMin.Name = "pbcgfMin";
            this.pbcgfMin.Size = new System.Drawing.Size(25, 25);
            this.pbcgfMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcgfMin.TabIndex = 3;
            this.pbcgfMin.TabStop = false;
            this.pbcgfMin.Click += new System.EventHandler(this.pbcgfMin_Click);
            this.pbcgfMin.MouseLeave += new System.EventHandler(this.pbcgfMin_MouseLeave);
            this.pbcgfMin.MouseHover += new System.EventHandler(this.pbcgfMin_MouseHover);
            // 
            // pbcgfCerrar
            // 
            this.pbcgfCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pbcgfCerrar.Image = global::Calculadora.Properties.Resources.close;
            this.pbcgfCerrar.Location = new System.Drawing.Point(291, 5);
            this.pbcgfCerrar.Name = "pbcgfCerrar";
            this.pbcgfCerrar.Size = new System.Drawing.Size(25, 25);
            this.pbcgfCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcgfCerrar.TabIndex = 2;
            this.pbcgfCerrar.TabStop = false;
            this.pbcgfCerrar.Click += new System.EventHandler(this.pbcgfCerrar_Click);
            this.pbcgfCerrar.MouseLeave += new System.EventHandler(this.pbcgfMin_MouseLeave);
            this.pbcgfCerrar.MouseHover += new System.EventHandler(this.pbcgfMin_MouseHover);
            // 
            // btncgfNum0
            // 
            this.btncgfNum0.BackColor = System.Drawing.Color.Gray;
            this.btncgfNum0.FlatAppearance.BorderSize = 0;
            this.btncgfNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfNum0.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfNum0.ForeColor = System.Drawing.Color.White;
            this.btncgfNum0.Location = new System.Drawing.Point(83, 398);
            this.btncgfNum0.Name = "btncgfNum0";
            this.btncgfNum0.Size = new System.Drawing.Size(75, 45);
            this.btncgfNum0.TabIndex = 2;
            this.btncgfNum0.Text = "0";
            this.btncgfNum0.UseVisualStyleBackColor = false;
            this.btncgfNum0.Click += new System.EventHandler(this.btncgfNum_Click);
            // 
            // bntcgfPunto
            // 
            this.bntcgfPunto.BackColor = System.Drawing.Color.DimGray;
            this.bntcgfPunto.FlatAppearance.BorderSize = 0;
            this.bntcgfPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntcgfPunto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntcgfPunto.ForeColor = System.Drawing.Color.White;
            this.bntcgfPunto.Location = new System.Drawing.Point(163, 398);
            this.bntcgfPunto.Name = "bntcgfPunto";
            this.bntcgfPunto.Size = new System.Drawing.Size(75, 45);
            this.bntcgfPunto.TabIndex = 3;
            this.bntcgfPunto.Text = ".";
            this.bntcgfPunto.UseVisualStyleBackColor = false;
            this.bntcgfPunto.Click += new System.EventHandler(this.btncgfPunto_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumPurple;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(243, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "=";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btncgfIgual_Click);
            // 
            // btncgfSuma
            // 
            this.btncgfSuma.BackColor = System.Drawing.Color.DimGray;
            this.btncgfSuma.FlatAppearance.BorderSize = 0;
            this.btncgfSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfSuma.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfSuma.ForeColor = System.Drawing.Color.White;
            this.btncgfSuma.Location = new System.Drawing.Point(243, 347);
            this.btncgfSuma.Name = "btncgfSuma";
            this.btncgfSuma.Size = new System.Drawing.Size(75, 45);
            this.btncgfSuma.TabIndex = 8;
            this.btncgfSuma.Text = "+";
            this.btncgfSuma.UseVisualStyleBackColor = false;
            this.btncgfSuma.Click += new System.EventHandler(this.btncgfOperacion_Click);
            // 
            // btncgfNum3
            // 
            this.btncgfNum3.BackColor = System.Drawing.Color.Gray;
            this.btncgfNum3.FlatAppearance.BorderSize = 0;
            this.btncgfNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfNum3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfNum3.ForeColor = System.Drawing.Color.White;
            this.btncgfNum3.Location = new System.Drawing.Point(163, 347);
            this.btncgfNum3.Name = "btncgfNum3";
            this.btncgfNum3.Size = new System.Drawing.Size(75, 45);
            this.btncgfNum3.TabIndex = 7;
            this.btncgfNum3.Text = "3";
            this.btncgfNum3.UseVisualStyleBackColor = false;
            this.btncgfNum3.Click += new System.EventHandler(this.btncgfNum_Click);
            // 
            // btncgfNum2
            // 
            this.btncgfNum2.BackColor = System.Drawing.Color.Gray;
            this.btncgfNum2.FlatAppearance.BorderSize = 0;
            this.btncgfNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfNum2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfNum2.ForeColor = System.Drawing.Color.White;
            this.btncgfNum2.Location = new System.Drawing.Point(83, 347);
            this.btncgfNum2.Name = "btncgfNum2";
            this.btncgfNum2.Size = new System.Drawing.Size(75, 45);
            this.btncgfNum2.TabIndex = 6;
            this.btncgfNum2.Text = "2";
            this.btncgfNum2.UseVisualStyleBackColor = false;
            this.btncgfNum2.Click += new System.EventHandler(this.btncgfNum_Click);
            // 
            // btncgfNum1
            // 
            this.btncgfNum1.BackColor = System.Drawing.Color.Gray;
            this.btncgfNum1.FlatAppearance.BorderSize = 0;
            this.btncgfNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfNum1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfNum1.ForeColor = System.Drawing.Color.White;
            this.btncgfNum1.Location = new System.Drawing.Point(3, 347);
            this.btncgfNum1.Name = "btncgfNum1";
            this.btncgfNum1.Size = new System.Drawing.Size(75, 45);
            this.btncgfNum1.TabIndex = 5;
            this.btncgfNum1.Text = "1";
            this.btncgfNum1.UseVisualStyleBackColor = false;
            this.btncgfNum1.Click += new System.EventHandler(this.btncgfNum_Click);
            // 
            // btncgfMultiplicar
            // 
            this.btncgfMultiplicar.BackColor = System.Drawing.Color.DimGray;
            this.btncgfMultiplicar.FlatAppearance.BorderSize = 0;
            this.btncgfMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfMultiplicar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfMultiplicar.ForeColor = System.Drawing.Color.White;
            this.btncgfMultiplicar.Location = new System.Drawing.Point(243, 245);
            this.btncgfMultiplicar.Name = "btncgfMultiplicar";
            this.btncgfMultiplicar.Size = new System.Drawing.Size(75, 45);
            this.btncgfMultiplicar.TabIndex = 16;
            this.btncgfMultiplicar.Text = "x";
            this.btncgfMultiplicar.UseVisualStyleBackColor = false;
            this.btncgfMultiplicar.Click += new System.EventHandler(this.btncgfOperacion_Click);
            // 
            // btncgfNum9
            // 
            this.btncgfNum9.BackColor = System.Drawing.Color.Gray;
            this.btncgfNum9.FlatAppearance.BorderSize = 0;
            this.btncgfNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfNum9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfNum9.ForeColor = System.Drawing.Color.White;
            this.btncgfNum9.Location = new System.Drawing.Point(163, 245);
            this.btncgfNum9.Name = "btncgfNum9";
            this.btncgfNum9.Size = new System.Drawing.Size(75, 45);
            this.btncgfNum9.TabIndex = 15;
            this.btncgfNum9.Text = "9";
            this.btncgfNum9.UseVisualStyleBackColor = false;
            this.btncgfNum9.Click += new System.EventHandler(this.btncgfNum_Click);
            // 
            // btncgfNum8
            // 
            this.btncgfNum8.BackColor = System.Drawing.Color.Gray;
            this.btncgfNum8.FlatAppearance.BorderSize = 0;
            this.btncgfNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfNum8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfNum8.ForeColor = System.Drawing.Color.White;
            this.btncgfNum8.Location = new System.Drawing.Point(83, 245);
            this.btncgfNum8.Name = "btncgfNum8";
            this.btncgfNum8.Size = new System.Drawing.Size(75, 45);
            this.btncgfNum8.TabIndex = 14;
            this.btncgfNum8.Text = "8";
            this.btncgfNum8.UseVisualStyleBackColor = false;
            this.btncgfNum8.Click += new System.EventHandler(this.btncgfNum_Click);
            // 
            // btncgfNum7
            // 
            this.btncgfNum7.BackColor = System.Drawing.Color.Gray;
            this.btncgfNum7.FlatAppearance.BorderSize = 0;
            this.btncgfNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfNum7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfNum7.ForeColor = System.Drawing.Color.White;
            this.btncgfNum7.Location = new System.Drawing.Point(3, 245);
            this.btncgfNum7.Name = "btncgfNum7";
            this.btncgfNum7.Size = new System.Drawing.Size(75, 45);
            this.btncgfNum7.TabIndex = 13;
            this.btncgfNum7.Text = "7";
            this.btncgfNum7.UseVisualStyleBackColor = false;
            this.btncgfNum7.Click += new System.EventHandler(this.btncgfNum_Click);
            // 
            // btncgfResta
            // 
            this.btncgfResta.BackColor = System.Drawing.Color.DimGray;
            this.btncgfResta.FlatAppearance.BorderSize = 0;
            this.btncgfResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfResta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfResta.ForeColor = System.Drawing.Color.White;
            this.btncgfResta.Location = new System.Drawing.Point(243, 296);
            this.btncgfResta.Name = "btncgfResta";
            this.btncgfResta.Size = new System.Drawing.Size(75, 45);
            this.btncgfResta.TabIndex = 12;
            this.btncgfResta.Text = "-";
            this.btncgfResta.UseVisualStyleBackColor = false;
            this.btncgfResta.Click += new System.EventHandler(this.btncgfOperacion_Click);
            // 
            // btncgfNum6
            // 
            this.btncgfNum6.BackColor = System.Drawing.Color.Gray;
            this.btncgfNum6.FlatAppearance.BorderSize = 0;
            this.btncgfNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfNum6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfNum6.ForeColor = System.Drawing.Color.White;
            this.btncgfNum6.Location = new System.Drawing.Point(163, 296);
            this.btncgfNum6.Name = "btncgfNum6";
            this.btncgfNum6.Size = new System.Drawing.Size(75, 45);
            this.btncgfNum6.TabIndex = 11;
            this.btncgfNum6.Text = "6";
            this.btncgfNum6.UseVisualStyleBackColor = false;
            this.btncgfNum6.Click += new System.EventHandler(this.btncgfNum_Click);
            // 
            // btncgfNum5
            // 
            this.btncgfNum5.BackColor = System.Drawing.Color.Gray;
            this.btncgfNum5.FlatAppearance.BorderSize = 0;
            this.btncgfNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfNum5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfNum5.ForeColor = System.Drawing.Color.White;
            this.btncgfNum5.Location = new System.Drawing.Point(83, 296);
            this.btncgfNum5.Name = "btncgfNum5";
            this.btncgfNum5.Size = new System.Drawing.Size(75, 45);
            this.btncgfNum5.TabIndex = 10;
            this.btncgfNum5.Text = "5";
            this.btncgfNum5.UseVisualStyleBackColor = false;
            this.btncgfNum5.Click += new System.EventHandler(this.btncgfNum_Click);
            // 
            // btncgfNum4
            // 
            this.btncgfNum4.BackColor = System.Drawing.Color.Gray;
            this.btncgfNum4.FlatAppearance.BorderSize = 0;
            this.btncgfNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfNum4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfNum4.ForeColor = System.Drawing.Color.White;
            this.btncgfNum4.Location = new System.Drawing.Point(3, 296);
            this.btncgfNum4.Name = "btncgfNum4";
            this.btncgfNum4.Size = new System.Drawing.Size(75, 45);
            this.btncgfNum4.TabIndex = 9;
            this.btncgfNum4.Text = "4";
            this.btncgfNum4.UseVisualStyleBackColor = false;
            this.btncgfNum4.Click += new System.EventHandler(this.btncgfNum_Click);
            // 
            // brncgfBorrar
            // 
            this.brncgfBorrar.BackColor = System.Drawing.Color.DimGray;
            this.brncgfBorrar.FlatAppearance.BorderSize = 0;
            this.brncgfBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brncgfBorrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brncgfBorrar.ForeColor = System.Drawing.Color.White;
            this.brncgfBorrar.Location = new System.Drawing.Point(244, 143);
            this.brncgfBorrar.Name = "brncgfBorrar";
            this.brncgfBorrar.Size = new System.Drawing.Size(75, 45);
            this.brncgfBorrar.TabIndex = 24;
            this.brncgfBorrar.Text = "del";
            this.brncgfBorrar.UseVisualStyleBackColor = false;
            this.brncgfBorrar.Click += new System.EventHandler(this.brncgfBorrar_Click);
            // 
            // btncgfClear
            // 
            this.btncgfClear.BackColor = System.Drawing.Color.DimGray;
            this.btncgfClear.FlatAppearance.BorderSize = 0;
            this.btncgfClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfClear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfClear.ForeColor = System.Drawing.Color.White;
            this.btncgfClear.Location = new System.Drawing.Point(164, 143);
            this.btncgfClear.Name = "btncgfClear";
            this.btncgfClear.Size = new System.Drawing.Size(75, 45);
            this.btncgfClear.TabIndex = 23;
            this.btncgfClear.Text = "C";
            this.btncgfClear.UseVisualStyleBackColor = false;
            this.btncgfClear.Click += new System.EventHandler(this.btncgfClear_Click);
            // 
            // btncgfClearE
            // 
            this.btncgfClearE.BackColor = System.Drawing.Color.DimGray;
            this.btncgfClearE.FlatAppearance.BorderSize = 0;
            this.btncgfClearE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfClearE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfClearE.ForeColor = System.Drawing.Color.White;
            this.btncgfClearE.Location = new System.Drawing.Point(84, 143);
            this.btncgfClearE.Name = "btncgfClearE";
            this.btncgfClearE.Size = new System.Drawing.Size(75, 45);
            this.btncgfClearE.TabIndex = 22;
            this.btncgfClearE.Text = "CE";
            this.btncgfClearE.UseVisualStyleBackColor = false;
            this.btncgfClearE.Click += new System.EventHandler(this.btncgfClearE_Click);
            // 
            // btncgfPercentage
            // 
            this.btncgfPercentage.BackColor = System.Drawing.Color.DimGray;
            this.btncgfPercentage.FlatAppearance.BorderSize = 0;
            this.btncgfPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfPercentage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfPercentage.ForeColor = System.Drawing.Color.White;
            this.btncgfPercentage.Location = new System.Drawing.Point(4, 143);
            this.btncgfPercentage.Name = "btncgfPercentage";
            this.btncgfPercentage.Size = new System.Drawing.Size(75, 45);
            this.btncgfPercentage.TabIndex = 21;
            this.btncgfPercentage.Text = "%";
            this.btncgfPercentage.UseVisualStyleBackColor = false;
            this.btncgfPercentage.Click += new System.EventHandler(this.btncgfOperacionEspecial_Click);
            // 
            // btncgfDividir
            // 
            this.btncgfDividir.BackColor = System.Drawing.Color.DimGray;
            this.btncgfDividir.FlatAppearance.BorderSize = 0;
            this.btncgfDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfDividir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfDividir.ForeColor = System.Drawing.Color.White;
            this.btncgfDividir.Location = new System.Drawing.Point(244, 194);
            this.btncgfDividir.Name = "btncgfDividir";
            this.btncgfDividir.Size = new System.Drawing.Size(75, 45);
            this.btncgfDividir.TabIndex = 20;
            this.btncgfDividir.Text = "/";
            this.btncgfDividir.UseVisualStyleBackColor = false;
            this.btncgfDividir.Click += new System.EventHandler(this.btncgfOperacion_Click);
            // 
            // btncgfRaiz
            // 
            this.btncgfRaiz.BackColor = System.Drawing.Color.DimGray;
            this.btncgfRaiz.FlatAppearance.BorderSize = 0;
            this.btncgfRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfRaiz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfRaiz.ForeColor = System.Drawing.Color.White;
            this.btncgfRaiz.Location = new System.Drawing.Point(164, 194);
            this.btncgfRaiz.Name = "btncgfRaiz";
            this.btncgfRaiz.Size = new System.Drawing.Size(75, 45);
            this.btncgfRaiz.TabIndex = 19;
            this.btncgfRaiz.Text = "sqrt";
            this.btncgfRaiz.UseVisualStyleBackColor = false;
            this.btncgfRaiz.Click += new System.EventHandler(this.btncgfOperacionEspecial_Click);
            // 
            // btncgfCuadrado
            // 
            this.btncgfCuadrado.BackColor = System.Drawing.Color.DimGray;
            this.btncgfCuadrado.FlatAppearance.BorderSize = 0;
            this.btncgfCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfCuadrado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfCuadrado.ForeColor = System.Drawing.Color.White;
            this.btncgfCuadrado.Location = new System.Drawing.Point(84, 194);
            this.btncgfCuadrado.Name = "btncgfCuadrado";
            this.btncgfCuadrado.Size = new System.Drawing.Size(75, 45);
            this.btncgfCuadrado.TabIndex = 18;
            this.btncgfCuadrado.Text = "x^2";
            this.btncgfCuadrado.UseVisualStyleBackColor = false;
            this.btncgfCuadrado.Click += new System.EventHandler(this.btncgfOperacionEspecial_Click);
            // 
            // btncgfSobreUno
            // 
            this.btncgfSobreUno.BackColor = System.Drawing.Color.DimGray;
            this.btncgfSobreUno.FlatAppearance.BorderSize = 0;
            this.btncgfSobreUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncgfSobreUno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncgfSobreUno.ForeColor = System.Drawing.Color.White;
            this.btncgfSobreUno.Location = new System.Drawing.Point(4, 194);
            this.btncgfSobreUno.Name = "btncgfSobreUno";
            this.btncgfSobreUno.Size = new System.Drawing.Size(75, 45);
            this.btncgfSobreUno.TabIndex = 17;
            this.btncgfSobreUno.Text = "1/x";
            this.btncgfSobreUno.UseVisualStyleBackColor = false;
            this.btncgfSobreUno.Click += new System.EventHandler(this.btncgfOperacionEspecial_Click);
            // 
            // lblcgfNum
            // 
            this.lblcgfNum.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcgfNum.ForeColor = System.Drawing.Color.White;
            this.lblcgfNum.Location = new System.Drawing.Point(4, 84);
            this.lblcgfNum.Name = "lblcgfNum";
            this.lblcgfNum.Size = new System.Drawing.Size(314, 48);
            this.lblcgfNum.TabIndex = 25;
            this.lblcgfNum.Text = "0";
            this.lblcgfNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblcgfOperacion
            // 
            this.lblcgfOperacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcgfOperacion.ForeColor = System.Drawing.Color.LightGray;
            this.lblcgfOperacion.Location = new System.Drawing.Point(4, 38);
            this.lblcgfOperacion.Name = "lblcgfOperacion";
            this.lblcgfOperacion.Size = new System.Drawing.Size(314, 46);
            this.lblcgfOperacion.TabIndex = 26;
            this.lblcgfOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmcgfCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.lblcgfOperacion);
            this.Controls.Add(this.lblcgfNum);
            this.Controls.Add(this.brncgfBorrar);
            this.Controls.Add(this.btncgfClear);
            this.Controls.Add(this.btncgfClearE);
            this.Controls.Add(this.btncgfPercentage);
            this.Controls.Add(this.btncgfDividir);
            this.Controls.Add(this.btncgfRaiz);
            this.Controls.Add(this.btncgfCuadrado);
            this.Controls.Add(this.btncgfSobreUno);
            this.Controls.Add(this.btncgfMultiplicar);
            this.Controls.Add(this.btncgfNum9);
            this.Controls.Add(this.btncgfNum8);
            this.Controls.Add(this.btncgfNum7);
            this.Controls.Add(this.btncgfResta);
            this.Controls.Add(this.btncgfNum6);
            this.Controls.Add(this.btncgfNum5);
            this.Controls.Add(this.btncgfNum4);
            this.Controls.Add(this.btncgfSuma);
            this.Controls.Add(this.btncgfNum3);
            this.Controls.Add(this.btncgfNum2);
            this.Controls.Add(this.btncgfNum1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bntcgfPunto);
            this.Controls.Add(this.btncgfNum0);
            this.Controls.Add(this.pnlcgfNavBar);
            this.Controls.Add(this.btncgfNegar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcgfCalculadora";
            this.Text = "Calculadora";
            this.pnlcgfNavBar.ResumeLayout(false);
            this.pnlcgfNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcgfIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcgfMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcgfCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btncgfNegar;
        private Panel pnlcgfNavBar;
        private PictureBox pbcgfMin;
        private PictureBox pbcgfCerrar;
        private Button btncgfNum0;
        private Button bntcgfPunto;
        private Button button4;
        private Button btncgfSuma;
        private Button btncgfNum3;
        private Button btncgfNum2;
        private Button btncgfNum1;
        private Button btncgfMultiplicar;
        private Button btncgfNum9;
        private Button btncgfNum8;
        private Button btncgfNum7;
        private Button btncgfResta;
        private Button btncgfNum6;
        private Button btncgfNum5;
        private Button btncgfNum4;
        private Button brncgfBorrar;
        private Button btncgfClear;
        private Button btncgfClearE;
        private Button btncgfPercentage;
        private Button btncgfDividir;
        private Button btncgfRaiz;
        private Button btncgfCuadrado;
        private Button btncgfSobreUno;
        private Label lblcgfNum;
        private Label lblcgfOperacion;
        private PictureBox pbcgfIcon;
        private Label lblTitulo;
    }
}