namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.jogadorTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.a1 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.inimigoTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BtnBot_d4 = new System.Windows.Forms.Button();
            this.BtnBot_d3 = new System.Windows.Forms.Button();
            this.BtnBot_a2 = new System.Windows.Forms.Button();
            this.BtnBot_d2 = new System.Windows.Forms.Button();
            this.BtnBot_a3 = new System.Windows.Forms.Button();
            this.BtnBot_d1 = new System.Windows.Forms.Button();
            this.BtnBot_a4 = new System.Windows.Forms.Button();
            this.BtnBot_c4 = new System.Windows.Forms.Button();
            this.BtnBot_b1 = new System.Windows.Forms.Button();
            this.BtnBot_c3 = new System.Windows.Forms.Button();
            this.BtnBot_b2 = new System.Windows.Forms.Button();
            this.BtnBot_c2 = new System.Windows.Forms.Button();
            this.BtnBot_b3 = new System.Windows.Forms.Button();
            this.BtnBot_b4 = new System.Windows.Forms.Button();
            this.BtnBot_c1 = new System.Windows.Forms.Button();
            this.BtnBot_a1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tempoEsperaInimigo = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tempoJogadaInimigo = new System.Windows.Forms.Timer(this.components);
            this.inimigoCasas = new System.Windows.Forms.ComboBox();
            this.textoAuxiliar = new System.Windows.Forms.Label();
            this.indicadorNavioslb = new System.Windows.Forms.Label();
            this.alo = new System.Windows.Forms.Label();
            this.PONTUACAOP = new System.Windows.Forms.Label();
            this.PONTUACAOE = new System.Windows.Forms.Label();
            this.jogadorTableLayout.SuspendLayout();
            this.inimigoTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 122);
            this.label1.TabIndex = 0;
            this.label1.Text = "BATALHA\r\n   NAVAL";
            // 
            // jogadorTableLayout
            // 
            this.jogadorTableLayout.ColumnCount = 4;
            this.jogadorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.jogadorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.jogadorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.jogadorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.jogadorTableLayout.Controls.Add(this.a1, 0, 0);
            this.jogadorTableLayout.Controls.Add(this.d4, 3, 3);
            this.jogadorTableLayout.Controls.Add(this.d3, 2, 3);
            this.jogadorTableLayout.Controls.Add(this.a3, 2, 0);
            this.jogadorTableLayout.Controls.Add(this.a2, 1, 0);
            this.jogadorTableLayout.Controls.Add(this.a4, 3, 0);
            this.jogadorTableLayout.Controls.Add(this.b1, 0, 1);
            this.jogadorTableLayout.Controls.Add(this.b2, 1, 1);
            this.jogadorTableLayout.Controls.Add(this.b3, 2, 1);
            this.jogadorTableLayout.Controls.Add(this.b4, 3, 1);
            this.jogadorTableLayout.Controls.Add(this.c1, 0, 2);
            this.jogadorTableLayout.Controls.Add(this.c4, 3, 2);
            this.jogadorTableLayout.Controls.Add(this.d1, 0, 3);
            this.jogadorTableLayout.Controls.Add(this.d2, 1, 3);
            this.jogadorTableLayout.Controls.Add(this.c2, 1, 2);
            this.jogadorTableLayout.Controls.Add(this.c3, 2, 2);
            this.jogadorTableLayout.Location = new System.Drawing.Point(475, 174);
            this.jogadorTableLayout.Name = "jogadorTableLayout";
            this.jogadorTableLayout.RowCount = 4;
            this.jogadorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.jogadorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.jogadorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.jogadorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.jogadorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.jogadorTableLayout.Size = new System.Drawing.Size(339, 335);
            this.jogadorTableLayout.TabIndex = 1;
            this.jogadorTableLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.jogadorTableLayout_Paint);
            // 
            // a1
            // 
            this.a1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a1.Location = new System.Drawing.Point(3, 3);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(78, 77);
            this.a1.TabIndex = 23;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = true;
            // 
            // d4
            // 
            this.d4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d4.Location = new System.Drawing.Point(255, 252);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(81, 80);
            this.d4.TabIndex = 18;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = true;
            this.d4.Click += new System.EventHandler(this.posiçãodeataqueinimigo);
            // 
            // d3
            // 
            this.d3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d3.Location = new System.Drawing.Point(171, 252);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(78, 80);
            this.d3.TabIndex = 17;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = true;
            this.d3.Click += new System.EventHandler(this.posiçãodeataqueinimigo);
            // 
            // a3
            // 
            this.a3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a3.Location = new System.Drawing.Point(171, 3);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(78, 77);
            this.a3.TabIndex = 5;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.posiçãodeataqueinimigo);
            // 
            // a2
            // 
            this.a2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a2.Location = new System.Drawing.Point(87, 3);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(78, 77);
            this.a2.TabIndex = 4;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.posiçãodeataqueinimigo);
            // 
            // a4
            // 
            this.a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a4.Location = new System.Drawing.Point(255, 3);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(81, 77);
            this.a4.TabIndex = 7;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = true;
            this.a4.Click += new System.EventHandler(this.posiçãodeataqueinimigo);
            // 
            // b1
            // 
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Location = new System.Drawing.Point(3, 86);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(78, 77);
            this.b1.TabIndex = 6;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.posiçãodeataqueinimigo);
            // 
            // b2
            // 
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Location = new System.Drawing.Point(87, 86);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(78, 77);
            this.b2.TabIndex = 8;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.posiçãodeataqueinimigo);
            // 
            // b3
            // 
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.Location = new System.Drawing.Point(171, 86);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(78, 77);
            this.b3.TabIndex = 9;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.posiçãodeataqueinimigo);
            // 
            // b4
            // 
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b4.Location = new System.Drawing.Point(255, 86);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(81, 77);
            this.b4.TabIndex = 10;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.posiçãodeataqueinimigo);
            // 
            // c1
            // 
            this.c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1.Location = new System.Drawing.Point(3, 169);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(78, 77);
            this.c1.TabIndex = 11;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.posiçãodeataqueinimigo);
            // 
            // c4
            // 
            this.c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c4.Location = new System.Drawing.Point(255, 169);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(81, 77);
            this.c4.TabIndex = 15;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = true;
            this.c4.Click += new System.EventHandler(this.posiçãodeataqueinimigo);
            // 
            // d1
            // 
            this.d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d1.Location = new System.Drawing.Point(3, 252);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(78, 80);
            this.d1.TabIndex = 14;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = true;
            this.d1.Click += new System.EventHandler(this.posiçãodeataqueinimigo);
            // 
            // d2
            // 
            this.d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d2.Location = new System.Drawing.Point(87, 252);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(78, 80);
            this.d2.TabIndex = 16;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = true;
            this.d2.Click += new System.EventHandler(this.posiçãodeataqueinimigo);
            // 
            // c2
            // 
            this.c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c2.Location = new System.Drawing.Point(87, 169);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(78, 77);
            this.c2.TabIndex = 13;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.posiçãodeataqueinimigo);
            // 
            // c3
            // 
            this.c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c3.Location = new System.Drawing.Point(171, 169);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(78, 77);
            this.c3.TabIndex = 12;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.posiçãodeataqueinimigo);
            // 
            // inimigoTableLayout
            // 
            this.inimigoTableLayout.ColumnCount = 4;
            this.inimigoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inimigoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inimigoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inimigoTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inimigoTableLayout.Controls.Add(this.BtnBot_d4, 3, 3);
            this.inimigoTableLayout.Controls.Add(this.BtnBot_d3, 2, 3);
            this.inimigoTableLayout.Controls.Add(this.BtnBot_a2, 1, 0);
            this.inimigoTableLayout.Controls.Add(this.BtnBot_d2, 1, 3);
            this.inimigoTableLayout.Controls.Add(this.BtnBot_a3, 2, 0);
            this.inimigoTableLayout.Controls.Add(this.BtnBot_d1, 0, 3);
            this.inimigoTableLayout.Controls.Add(this.BtnBot_a4, 3, 0);
            this.inimigoTableLayout.Controls.Add(this.BtnBot_c4, 3, 2);
            this.inimigoTableLayout.Controls.Add(this.BtnBot_b1, 0, 1);
            this.inimigoTableLayout.Controls.Add(this.BtnBot_c3, 2, 2);
            this.inimigoTableLayout.Controls.Add(this.BtnBot_b2, 1, 1);
            this.inimigoTableLayout.Controls.Add(this.BtnBot_c2, 1, 2);
            this.inimigoTableLayout.Controls.Add(this.BtnBot_b3, 2, 1);
            this.inimigoTableLayout.Controls.Add(this.BtnBot_b4, 3, 1);
            this.inimigoTableLayout.Controls.Add(this.BtnBot_c1, 0, 2);
            this.inimigoTableLayout.Controls.Add(this.BtnBot_a1, 0, 0);
            this.inimigoTableLayout.Location = new System.Drawing.Point(42, 171);
            this.inimigoTableLayout.Name = "inimigoTableLayout";
            this.inimigoTableLayout.RowCount = 4;
            this.inimigoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inimigoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inimigoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inimigoTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.inimigoTableLayout.Size = new System.Drawing.Size(339, 335);
            this.inimigoTableLayout.TabIndex = 2;
            // 
            // BtnBot_d4
            // 
            this.BtnBot_d4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_d4.Location = new System.Drawing.Point(255, 252);
            this.BtnBot_d4.Name = "BtnBot_d4";
            this.BtnBot_d4.Size = new System.Drawing.Size(81, 80);
            this.BtnBot_d4.TabIndex = 34;
            this.BtnBot_d4.Text = "D4";
            this.BtnBot_d4.UseVisualStyleBackColor = true;
            this.BtnBot_d4.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // BtnBot_d3
            // 
            this.BtnBot_d3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_d3.Location = new System.Drawing.Point(171, 252);
            this.BtnBot_d3.Name = "BtnBot_d3";
            this.BtnBot_d3.Size = new System.Drawing.Size(78, 80);
            this.BtnBot_d3.TabIndex = 33;
            this.BtnBot_d3.Text = "D3";
            this.BtnBot_d3.UseVisualStyleBackColor = true;
            this.BtnBot_d3.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // BtnBot_a2
            // 
            this.BtnBot_a2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_a2.Location = new System.Drawing.Point(87, 3);
            this.BtnBot_a2.Name = "BtnBot_a2";
            this.BtnBot_a2.Size = new System.Drawing.Size(78, 77);
            this.BtnBot_a2.TabIndex = 20;
            this.BtnBot_a2.Text = "A2";
            this.BtnBot_a2.UseVisualStyleBackColor = true;
            this.BtnBot_a2.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // BtnBot_d2
            // 
            this.BtnBot_d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_d2.Location = new System.Drawing.Point(87, 252);
            this.BtnBot_d2.Name = "BtnBot_d2";
            this.BtnBot_d2.Size = new System.Drawing.Size(78, 80);
            this.BtnBot_d2.TabIndex = 32;
            this.BtnBot_d2.Text = "D2";
            this.BtnBot_d2.UseVisualStyleBackColor = true;
            this.BtnBot_d2.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // BtnBot_a3
            // 
            this.BtnBot_a3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_a3.Location = new System.Drawing.Point(171, 3);
            this.BtnBot_a3.Name = "BtnBot_a3";
            this.BtnBot_a3.Size = new System.Drawing.Size(78, 77);
            this.BtnBot_a3.TabIndex = 22;
            this.BtnBot_a3.Text = "A3";
            this.BtnBot_a3.UseVisualStyleBackColor = true;
            this.BtnBot_a3.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // BtnBot_d1
            // 
            this.BtnBot_d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_d1.Location = new System.Drawing.Point(3, 252);
            this.BtnBot_d1.Name = "BtnBot_d1";
            this.BtnBot_d1.Size = new System.Drawing.Size(78, 80);
            this.BtnBot_d1.TabIndex = 31;
            this.BtnBot_d1.Text = "D1";
            this.BtnBot_d1.UseVisualStyleBackColor = true;
            this.BtnBot_d1.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // BtnBot_a4
            // 
            this.BtnBot_a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_a4.Location = new System.Drawing.Point(255, 3);
            this.BtnBot_a4.Name = "BtnBot_a4";
            this.BtnBot_a4.Size = new System.Drawing.Size(81, 77);
            this.BtnBot_a4.TabIndex = 21;
            this.BtnBot_a4.Text = "A4";
            this.BtnBot_a4.UseVisualStyleBackColor = true;
            this.BtnBot_a4.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // BtnBot_c4
            // 
            this.BtnBot_c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_c4.Location = new System.Drawing.Point(255, 169);
            this.BtnBot_c4.Name = "BtnBot_c4";
            this.BtnBot_c4.Size = new System.Drawing.Size(81, 77);
            this.BtnBot_c4.TabIndex = 30;
            this.BtnBot_c4.Text = "C4";
            this.BtnBot_c4.UseVisualStyleBackColor = true;
            this.BtnBot_c4.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // BtnBot_b1
            // 
            this.BtnBot_b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_b1.Location = new System.Drawing.Point(3, 86);
            this.BtnBot_b1.Name = "BtnBot_b1";
            this.BtnBot_b1.Size = new System.Drawing.Size(78, 77);
            this.BtnBot_b1.TabIndex = 23;
            this.BtnBot_b1.Tag = "";
            this.BtnBot_b1.Text = "B1";
            this.BtnBot_b1.UseVisualStyleBackColor = true;
            this.BtnBot_b1.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // BtnBot_c3
            // 
            this.BtnBot_c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_c3.Location = new System.Drawing.Point(171, 169);
            this.BtnBot_c3.Name = "BtnBot_c3";
            this.BtnBot_c3.Size = new System.Drawing.Size(78, 77);
            this.BtnBot_c3.TabIndex = 29;
            this.BtnBot_c3.Text = "C3";
            this.BtnBot_c3.UseVisualStyleBackColor = true;
            this.BtnBot_c3.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // BtnBot_b2
            // 
            this.BtnBot_b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_b2.Location = new System.Drawing.Point(87, 86);
            this.BtnBot_b2.Name = "BtnBot_b2";
            this.BtnBot_b2.Size = new System.Drawing.Size(78, 77);
            this.BtnBot_b2.TabIndex = 24;
            this.BtnBot_b2.Text = "B2";
            this.BtnBot_b2.UseVisualStyleBackColor = true;
            this.BtnBot_b2.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // BtnBot_c2
            // 
            this.BtnBot_c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_c2.Location = new System.Drawing.Point(87, 169);
            this.BtnBot_c2.Name = "BtnBot_c2";
            this.BtnBot_c2.Size = new System.Drawing.Size(78, 77);
            this.BtnBot_c2.TabIndex = 28;
            this.BtnBot_c2.Text = "C2";
            this.BtnBot_c2.UseVisualStyleBackColor = true;
            this.BtnBot_c2.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // BtnBot_b3
            // 
            this.BtnBot_b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_b3.Location = new System.Drawing.Point(171, 86);
            this.BtnBot_b3.Name = "BtnBot_b3";
            this.BtnBot_b3.Size = new System.Drawing.Size(78, 77);
            this.BtnBot_b3.TabIndex = 25;
            this.BtnBot_b3.Text = "B3";
            this.BtnBot_b3.UseVisualStyleBackColor = true;
            this.BtnBot_b3.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // BtnBot_b4
            // 
            this.BtnBot_b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_b4.Location = new System.Drawing.Point(255, 86);
            this.BtnBot_b4.Name = "BtnBot_b4";
            this.BtnBot_b4.Size = new System.Drawing.Size(81, 77);
            this.BtnBot_b4.TabIndex = 26;
            this.BtnBot_b4.Text = "B4";
            this.BtnBot_b4.UseVisualStyleBackColor = true;
            this.BtnBot_b4.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // BtnBot_c1
            // 
            this.BtnBot_c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_c1.Location = new System.Drawing.Point(3, 169);
            this.BtnBot_c1.Name = "BtnBot_c1";
            this.BtnBot_c1.Size = new System.Drawing.Size(78, 77);
            this.BtnBot_c1.TabIndex = 27;
            this.BtnBot_c1.Text = "C1";
            this.BtnBot_c1.UseVisualStyleBackColor = true;
            this.BtnBot_c1.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // BtnBot_a1
            // 
            this.BtnBot_a1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBot_a1.Location = new System.Drawing.Point(3, 3);
            this.BtnBot_a1.Name = "BtnBot_a1";
            this.BtnBot_a1.Size = new System.Drawing.Size(78, 77);
            this.BtnBot_a1.TabIndex = 19;
            this.BtnBot_a1.Tag = "";
            this.BtnBot_a1.Text = "A1";
            this.BtnBot_a1.UseVisualStyleBackColor = true;
            this.BtnBot_a1.AutoSizeChanged += new System.EventHandler(this.tempoJogadaInimigo_Tick);
            this.BtnBot_a1.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(454, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "D";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(344, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(523, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(454, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(454, 372);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "C";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(603, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(685, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(776, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "4";
            // 
            // tempoEsperaInimigo
            // 
            this.tempoEsperaInimigo.Interval = 1000;
            // 
            // tempoJogadaInimigo
            // 
            this.tempoJogadaInimigo.Enabled = true;
            this.tempoJogadaInimigo.Interval = 500;
            this.tempoJogadaInimigo.Tick += new System.EventHandler(this.tempoJogadaInimigo_Tick);
            // 
            // inimigoCasas
            // 
            this.inimigoCasas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inimigoCasas.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inimigoCasas.FormattingEnabled = true;
            this.inimigoCasas.Location = new System.Drawing.Point(370, 529);
            this.inimigoCasas.Name = "inimigoCasas";
            this.inimigoCasas.Size = new System.Drawing.Size(114, 19);
            this.inimigoCasas.TabIndex = 20;
            this.inimigoCasas.SelectedIndexChanged += new System.EventHandler(this.inimigoCasas_SelectedIndexChanged);
            // 
            // textoAuxiliar
            // 
            this.textoAuxiliar.AutoSize = true;
            this.textoAuxiliar.Location = new System.Drawing.Point(21, 118);
            this.textoAuxiliar.Name = "textoAuxiliar";
            this.textoAuxiliar.Size = new System.Drawing.Size(10, 13);
            this.textoAuxiliar.TabIndex = 21;
            this.textoAuxiliar.Text = ".";
            // 
            // indicadorNavioslb
            // 
            this.indicadorNavioslb.AutoSize = true;
            this.indicadorNavioslb.Location = new System.Drawing.Point(42, 530);
            this.indicadorNavioslb.Name = "indicadorNavioslb";
            this.indicadorNavioslb.Size = new System.Drawing.Size(103, 13);
            this.indicadorNavioslb.TabIndex = 22;
            this.indicadorNavioslb.Text = "Navios Restantes: 4";
            // 
            // alo
            // 
            this.alo.AutoSize = true;
            this.alo.Location = new System.Drawing.Point(42, 554);
            this.alo.Name = "alo";
            this.alo.Size = new System.Drawing.Size(10, 13);
            this.alo.TabIndex = 23;
            this.alo.Text = ".";
            this.alo.Click += new System.EventHandler(this.label18_Click);
            // 
            // PONTUACAOP
            // 
            this.PONTUACAOP.AutoSize = true;
            this.PONTUACAOP.Location = new System.Drawing.Point(511, 554);
            this.PONTUACAOP.Name = "PONTUACAOP";
            this.PONTUACAOP.Size = new System.Drawing.Size(10, 13);
            this.PONTUACAOP.TabIndex = 24;
            this.PONTUACAOP.Text = ".";
            // 
            // PONTUACAOE
            // 
            this.PONTUACAOE.AutoSize = true;
            this.PONTUACAOE.Location = new System.Drawing.Point(511, 529);
            this.PONTUACAOE.Name = "PONTUACAOE";
            this.PONTUACAOE.Size = new System.Drawing.Size(10, 13);
            this.PONTUACAOE.TabIndex = 25;
            this.PONTUACAOE.Text = ".";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.aaaaaa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 585);
            this.Controls.Add(this.PONTUACAOE);
            this.Controls.Add(this.PONTUACAOP);
            this.Controls.Add(this.alo);
            this.Controls.Add(this.indicadorNavioslb);
            this.Controls.Add(this.textoAuxiliar);
            this.Controls.Add(this.inimigoCasas);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inimigoTableLayout);
            this.Controls.Add(this.jogadorTableLayout);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(881, 624);
            this.MinimumSize = new System.Drawing.Size(881, 624);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Batalha Naval";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.posiçãoDeButoesInimigo);
            this.jogadorTableLayout.ResumeLayout(false);
            this.inimigoTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel jogadorTableLayout;
        private System.Windows.Forms.TableLayoutPanel inimigoTableLayout;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button BtnBot_a1;
        private System.Windows.Forms.Button BtnBot_a2;
        private System.Windows.Forms.Button BtnBot_a4;
        private System.Windows.Forms.Button BtnBot_a3;
        private System.Windows.Forms.Button BtnBot_b1;
        private System.Windows.Forms.Button BtnBot_b2;
        private System.Windows.Forms.Button BtnBot_b3;
        private System.Windows.Forms.Button BtnBot_b4;
        private System.Windows.Forms.Button BtnBot_c1;
        private System.Windows.Forms.Button BtnBot_c2;
        private System.Windows.Forms.Button BtnBot_c3;
        private System.Windows.Forms.Button BtnBot_c4;
        private System.Windows.Forms.Button BtnBot_d1;
        private System.Windows.Forms.Button BtnBot_d2;
        private System.Windows.Forms.Button BtnBot_d3;
        private System.Windows.Forms.Button BtnBot_d4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Timer tempoEsperaInimigo;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer tempoJogadaInimigo;
        private System.Windows.Forms.ComboBox inimigoCasas;
        private System.Windows.Forms.Label textoAuxiliar;
        private System.Windows.Forms.Label indicadorNavioslb;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Label alo;
        private System.Windows.Forms.Label PONTUACAOP;
        private System.Windows.Forms.Label PONTUACAOE;
    }
}

