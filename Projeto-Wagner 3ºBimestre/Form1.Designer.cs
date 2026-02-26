namespace Projeto_Wagner_3ºBimestre
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.recibo = new System.Windows.Forms.TextBox();
            this.finalizarProcesso = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.OKfinal = new System.Windows.Forms.Button();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.ponto = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.finalizar = new System.Windows.Forms.Button();
            this.adicionar = new System.Windows.Forms.Button();
            this.OKStart = new System.Windows.Forms.Button();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.produto = new System.Windows.Forms.TextBox();
            this.lblCompra = new System.Windows.Forms.Label();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblExemplo1 = new System.Windows.Forms.Label();
            this.lblExemplo2 = new System.Windows.Forms.Label();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recibo
            // 
            this.recibo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.recibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recibo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recibo.Cursor = System.Windows.Forms.Cursors.Default;
            this.recibo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recibo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recibo.Location = new System.Drawing.Point(716, 135);
            this.recibo.Multiline = true;
            this.recibo.Name = "recibo";
            this.recibo.ReadOnly = true;
            this.recibo.Size = new System.Drawing.Size(556, 412);
            this.recibo.TabIndex = 108;
            this.recibo.Visible = false;
            // 
            // finalizarProcesso
            // 
            this.finalizarProcesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.finalizarProcesso.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizarProcesso.ForeColor = System.Drawing.Color.White;
            this.finalizarProcesso.Location = new System.Drawing.Point(699, 611);
            this.finalizarProcesso.Name = "finalizarProcesso";
            this.finalizarProcesso.Size = new System.Drawing.Size(450, 65);
            this.finalizarProcesso.TabIndex = 107;
            this.finalizarProcesso.Text = "Finalizar Processo";
            this.finalizarProcesso.UseVisualStyleBackColor = false;
            this.finalizarProcesso.Visible = false;
            this.finalizarProcesso.Click += new System.EventHandler(this.finalizarProcesso_Click);
            // 
            // limpar
            // 
            this.limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.limpar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.ForeColor = System.Drawing.Color.White;
            this.limpar.Location = new System.Drawing.Point(147, 611);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(450, 65);
            this.limpar.TabIndex = 106;
            this.limpar.Text = "Limpar / Nova Compra";
            this.limpar.UseVisualStyleBackColor = false;
            this.limpar.Visible = false;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // OKfinal
            // 
            this.OKfinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OKfinal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OKfinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKfinal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKfinal.ForeColor = System.Drawing.Color.White;
            this.OKfinal.Location = new System.Drawing.Point(547, 135);
            this.OKfinal.Name = "OKfinal";
            this.OKfinal.Size = new System.Drawing.Size(129, 69);
            this.OKfinal.TabIndex = 105;
            this.OKfinal.Tag = "";
            this.OKfinal.Text = "OK";
            this.OKfinal.UseVisualStyleBackColor = false;
            this.OKfinal.Visible = false;
            this.OKfinal.Click += new System.EventHandler(this.OKfinal_Click);
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.Color.White;
            this.lblPrincipal.Location = new System.Drawing.Point(95, 151);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(410, 42);
            this.lblPrincipal.TabIndex = 103;
            this.lblPrincipal.Text = "R$0";
            this.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(85, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 80);
            this.button1.TabIndex = 91;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Numero_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Arial", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(85, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(432, 68);
            this.textBox1.TabIndex = 104;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(231, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 80);
            this.button2.TabIndex = 92;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(85, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 80);
            this.button4.TabIndex = 93;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(231, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 80);
            this.button5.TabIndex = 94;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(377, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 80);
            this.button3.TabIndex = 95;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(377, 295);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 80);
            this.button6.TabIndex = 96;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(377, 209);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(140, 80);
            this.button9.TabIndex = 102;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Numero_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(85, 209);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 80);
            this.button7.TabIndex = 97;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Numero_Click);
            // 
            // apagar
            // 
            this.apagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.apagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apagar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar.ForeColor = System.Drawing.Color.White;
            this.apagar.Location = new System.Drawing.Point(377, 467);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(140, 80);
            this.apagar.TabIndex = 101;
            this.apagar.Text = "CE";
            this.apagar.UseVisualStyleBackColor = false;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(231, 209);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 80);
            this.button8.TabIndex = 98;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Numero_Click);
            // 
            // ponto
            // 
            this.ponto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ponto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ponto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ponto.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ponto.ForeColor = System.Drawing.Color.White;
            this.ponto.Location = new System.Drawing.Point(231, 467);
            this.ponto.Name = "ponto";
            this.ponto.Size = new System.Drawing.Size(140, 80);
            this.ponto.TabIndex = 100;
            this.ponto.Text = ".";
            this.ponto.UseVisualStyleBackColor = false;
            this.ponto.Click += new System.EventHandler(this.ponto_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.Color.White;
            this.button0.Location = new System.Drawing.Point(85, 467);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(140, 80);
            this.button0.TabIndex = 99;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.Numero_Click);
            // 
            // finalizar
            // 
            this.finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.finalizar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizar.ForeColor = System.Drawing.Color.White;
            this.finalizar.Location = new System.Drawing.Point(771, 455);
            this.finalizar.Name = "finalizar";
            this.finalizar.Size = new System.Drawing.Size(450, 65);
            this.finalizar.TabIndex = 110;
            this.finalizar.Text = "Finalizar Compra";
            this.finalizar.UseVisualStyleBackColor = false;
            this.finalizar.Visible = false;
            this.finalizar.Click += new System.EventHandler(this.finalizar_Click);
            // 
            // adicionar
            // 
            this.adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adicionar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionar.ForeColor = System.Drawing.Color.White;
            this.adicionar.Location = new System.Drawing.Point(771, 362);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(450, 65);
            this.adicionar.TabIndex = 109;
            this.adicionar.Text = "Adicionar Produto";
            this.adicionar.UseVisualStyleBackColor = false;
            this.adicionar.Visible = false;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // OKStart
            // 
            this.OKStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OKStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OKStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKStart.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKStart.ForeColor = System.Drawing.Color.White;
            this.OKStart.Location = new System.Drawing.Point(547, 135);
            this.OKStart.Name = "OKStart";
            this.OKStart.Size = new System.Drawing.Size(129, 69);
            this.OKStart.TabIndex = 111;
            this.OKStart.Tag = "";
            this.OKStart.Text = "OK";
            this.OKStart.UseVisualStyleBackColor = false;
            this.OKStart.Click += new System.EventHandler(this.OKStart_Click);
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.ForeColor = System.Drawing.Color.White;
            this.lblCaixa.Location = new System.Drawing.Point(71, 91);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(469, 41);
            this.lblCaixa.TabIndex = 112;
            this.lblCaixa.Text = "Valor do Caixa Atualmente: ";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(95, 91);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(410, 41);
            this.lblCliente.TabIndex = 113;
            this.lblCliente.Text = "Valor Pago pelo Cliente:\r\n";
            this.lblCliente.Visible = false;
            // 
            // produto
            // 
            this.produto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.produto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.produto.Cursor = System.Windows.Forms.Cursors.Default;
            this.produto.Font = new System.Drawing.Font("Arial", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produto.ForeColor = System.Drawing.Color.White;
            this.produto.Location = new System.Drawing.Point(771, 233);
            this.produto.Name = "produto";
            this.produto.Size = new System.Drawing.Size(450, 68);
            this.produto.TabIndex = 114;
            this.produto.Visible = false;
            this.produto.TextChanged += new System.EventHandler(this.produto_TextChanged);
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompra.ForeColor = System.Drawing.Color.White;
            this.lblCompra.Location = new System.Drawing.Point(310, 36);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(572, 41);
            this.lblCompra.TabIndex = 115;
            this.lblCompra.Text = "Adicione os Produtos da Compra:";
            this.lblCompra.Visible = false;
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCompra.ForeColor = System.Drawing.Color.White;
            this.lblValorCompra.Location = new System.Drawing.Point(-3, 50);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(611, 41);
            this.lblValorCompra.TabIndex = 116;
            this.lblValorCompra.Text = "VALOR DA COMPRA: ";
            this.lblValorCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValorCompra.Visible = false;
            // 
            // lblExemplo1
            // 
            this.lblExemplo1.AutoSize = true;
            this.lblExemplo1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExemplo1.ForeColor = System.Drawing.Color.White;
            this.lblExemplo1.Location = new System.Drawing.Point(710, 135);
            this.lblExemplo1.Name = "lblExemplo1";
            this.lblExemplo1.Size = new System.Drawing.Size(563, 32);
            this.lblExemplo1.TabIndex = 117;
            this.lblExemplo1.Text = "Nome do Produto/Quantidade do Produto";
            this.lblExemplo1.Visible = false;
            // 
            // lblExemplo2
            // 
            this.lblExemplo2.AutoSize = true;
            this.lblExemplo2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExemplo2.ForeColor = System.Drawing.Color.White;
            this.lblExemplo2.Location = new System.Drawing.Point(892, 172);
            this.lblExemplo2.Name = "lblExemplo2";
            this.lblExemplo2.Size = new System.Drawing.Size(187, 32);
            this.lblExemplo2.TabIndex = 118;
            this.lblExemplo2.Text = "Ex: Banana/4";
            this.lblExemplo2.Visible = false;
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorProduto.ForeColor = System.Drawing.Color.White;
            this.lblValorProduto.Location = new System.Drawing.Point(116, 98);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(389, 32);
            this.lblValorProduto.TabIndex = 119;
            this.lblValorProduto.Text = "Valor do Produto ( Unidade )\n";
            this.lblValorProduto.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1350, 727);
            this.Controls.Add(this.lblValorProduto);
            this.Controls.Add(this.lblExemplo2);
            this.Controls.Add(this.lblExemplo1);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.lblCompra);
            this.Controls.Add(this.produto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCaixa);
            this.Controls.Add(this.OKStart);
            this.Controls.Add(this.finalizar);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.recibo);
            this.Controls.Add(this.finalizarProcesso);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.OKfinal);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.ponto);
            this.Controls.Add(this.button0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox recibo;
        private System.Windows.Forms.Button finalizarProcesso;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button OKfinal;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button ponto;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button finalizar;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Button OKStart;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox produto;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblExemplo1;
        private System.Windows.Forms.Label lblExemplo2;
        private System.Windows.Forms.Label lblValorProduto;
    }
}

