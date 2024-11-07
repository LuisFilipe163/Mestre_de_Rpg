namespace Mestre_de_Rpg
{
    partial class frmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            menuStrip1 = new MenuStrip();
            campanhaToolStripMenuItem = new ToolStripMenuItem();
            tsmiAdicionarAventura = new ToolStripMenuItem();
            tsmiRemoverAventura = new ToolStripMenuItem();
            tsmiAventuras = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            carregarJogadoresToolStripMenuItem = new ToolStripMenuItem();
            adicionarJogadorToolStripMenuItem = new ToolStripMenuItem();
            dadosToolStripMenuItem = new ToolStripMenuItem();
            nUDd4 = new NumericUpDown();
            nUDd6 = new NumericUpDown();
            nUDd8 = new NumericUpDown();
            nUDd10 = new NumericUpDown();
            nUDd12 = new NumericUpDown();
            nUDd20 = new NumericUpDown();
            nUDd100 = new NumericUpDown();
            lbResultado = new Label();
            lbValorResultado = new Label();
            label1 = new Label();
            btnRolar = new Button();
            btLimpar = new Button();
            tbModificador = new MaskedTextBox();
            pBd4 = new PictureBox();
            pBd6 = new PictureBox();
            pBd8 = new PictureBox();
            pBd10 = new PictureBox();
            pBd12 = new PictureBox();
            pBd20 = new PictureBox();
            pBd100 = new PictureBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            checkBox1 = new CheckBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDd4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd100).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBd4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBd6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBd8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBd10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBd12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBd20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBd100).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Pixel UniCode", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { campanhaToolStripMenuItem, dadosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1902, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // campanhaToolStripMenuItem
            // 
            campanhaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiAdicionarAventura, tsmiRemoverAventura, tsmiAventuras, toolStripSeparator1, carregarJogadoresToolStripMenuItem, adicionarJogadorToolStripMenuItem });
            campanhaToolStripMenuItem.Name = "campanhaToolStripMenuItem";
            campanhaToolStripMenuItem.Size = new Size(87, 26);
            campanhaToolStripMenuItem.Text = "&Aventura";
            // 
            // tsmiAdicionarAventura
            // 
            tsmiAdicionarAventura.Name = "tsmiAdicionarAventura";
            tsmiAdicionarAventura.Size = new Size(236, 26);
            tsmiAdicionarAventura.Text = "Adicionar Aventura";
            tsmiAdicionarAventura.Click += tsmiAdicionarAventura_Click;
            // 
            // tsmiRemoverAventura
            // 
            tsmiRemoverAventura.Name = "tsmiRemoverAventura";
            tsmiRemoverAventura.Size = new Size(236, 26);
            tsmiRemoverAventura.Text = "Excluir Aventura";
            tsmiRemoverAventura.Click += tsmiRemoverAventura_Click;
            // 
            // tsmiAventuras
            // 
            tsmiAventuras.Name = "tsmiAventuras";
            tsmiAventuras.Size = new Size(236, 26);
            tsmiAventuras.Text = "Aventuras";
            tsmiAventuras.Click += tsmiAventuras_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(233, 6);
            // 
            // carregarJogadoresToolStripMenuItem
            // 
            carregarJogadoresToolStripMenuItem.Name = "carregarJogadoresToolStripMenuItem";
            carregarJogadoresToolStripMenuItem.Size = new Size(236, 26);
            carregarJogadoresToolStripMenuItem.Text = "Carregar Jogadores";
            carregarJogadoresToolStripMenuItem.Click += carregarJogadoresToolStripMenuItem_Click;
            // 
            // adicionarJogadorToolStripMenuItem
            // 
            adicionarJogadorToolStripMenuItem.Name = "adicionarJogadorToolStripMenuItem";
            adicionarJogadorToolStripMenuItem.Size = new Size(236, 26);
            adicionarJogadorToolStripMenuItem.Text = "Adicionar Jogador";
            adicionarJogadorToolStripMenuItem.Click += adicionarJogadorToolStripMenuItem_Click;
            // 
            // dadosToolStripMenuItem
            // 
            dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            dadosToolStripMenuItem.Size = new Size(65, 26);
            dadosToolStripMenuItem.Text = "Dados";
            // 
            // nUDd4
            // 
            nUDd4.Location = new Point(29, 138);
            nUDd4.Margin = new Padding(3, 4, 3, 4);
            nUDd4.Name = "nUDd4";
            nUDd4.Size = new Size(66, 33);
            nUDd4.TabIndex = 9;
            nUDd4.TextAlign = HorizontalAlignment.Center;
            // 
            // nUDd6
            // 
            nUDd6.Location = new Point(135, 138);
            nUDd6.Margin = new Padding(3, 4, 3, 4);
            nUDd6.Name = "nUDd6";
            nUDd6.Size = new Size(66, 33);
            nUDd6.TabIndex = 10;
            nUDd6.TextAlign = HorizontalAlignment.Center;
            // 
            // nUDd8
            // 
            nUDd8.Location = new Point(241, 138);
            nUDd8.Margin = new Padding(3, 4, 3, 4);
            nUDd8.Name = "nUDd8";
            nUDd8.Size = new Size(66, 33);
            nUDd8.TabIndex = 11;
            nUDd8.TextAlign = HorizontalAlignment.Center;
            // 
            // nUDd10
            // 
            nUDd10.Location = new Point(347, 138);
            nUDd10.Margin = new Padding(3, 4, 3, 4);
            nUDd10.Name = "nUDd10";
            nUDd10.Size = new Size(66, 33);
            nUDd10.TabIndex = 12;
            nUDd10.TextAlign = HorizontalAlignment.Center;
            // 
            // nUDd12
            // 
            nUDd12.Location = new Point(453, 138);
            nUDd12.Margin = new Padding(3, 4, 3, 4);
            nUDd12.Name = "nUDd12";
            nUDd12.Size = new Size(66, 33);
            nUDd12.TabIndex = 13;
            nUDd12.TextAlign = HorizontalAlignment.Center;
            // 
            // nUDd20
            // 
            nUDd20.Location = new Point(559, 138);
            nUDd20.Margin = new Padding(3, 4, 3, 4);
            nUDd20.Name = "nUDd20";
            nUDd20.Size = new Size(66, 33);
            nUDd20.TabIndex = 14;
            nUDd20.TextAlign = HorizontalAlignment.Center;
            // 
            // nUDd100
            // 
            nUDd100.Location = new Point(665, 138);
            nUDd100.Margin = new Padding(3, 4, 3, 4);
            nUDd100.Name = "nUDd100";
            nUDd100.Size = new Size(66, 33);
            nUDd100.TabIndex = 15;
            nUDd100.TextAlign = HorizontalAlignment.Center;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(917, 68);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(92, 26);
            lbResultado.TabIndex = 16;
            lbResultado.Text = "Resultado: ";
            // 
            // lbValorResultado
            // 
            lbValorResultado.AutoSize = true;
            lbValorResultado.Location = new Point(1015, 68);
            lbValorResultado.Name = "lbValorResultado";
            lbValorResultado.Size = new Size(0, 26);
            lbValorResultado.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Pixel UniCode", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(814, 62);
            label1.Name = "label1";
            label1.Size = new Size(30, 39);
            label1.TabIndex = 18;
            label1.Text = "+";
            // 
            // btnRolar
            // 
            btnRolar.Location = new Point(976, 129);
            btnRolar.Name = "btnRolar";
            btnRolar.Size = new Size(159, 36);
            btnRolar.TabIndex = 20;
            btnRolar.Text = "Rolar Dados";
            btnRolar.UseVisualStyleBackColor = true;
            btnRolar.Click += btnRolar_Click;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(850, 129);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(120, 36);
            btLimpar.TabIndex = 21;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // tbModificador
            // 
            tbModificador.Location = new Point(850, 65);
            tbModificador.Mask = "00000";
            tbModificador.Name = "tbModificador";
            tbModificador.RightToLeft = RightToLeft.No;
            tbModificador.Size = new Size(54, 33);
            tbModificador.TabIndex = 23;
            tbModificador.ValidatingType = typeof(int);
            // 
            // pBd4
            // 
            pBd4.Image = (Image)resources.GetObject("pBd4.Image");
            pBd4.Location = new Point(29, 56);
            pBd4.Margin = new Padding(20);
            pBd4.Name = "pBd4";
            pBd4.Size = new Size(66, 55);
            pBd4.TabIndex = 24;
            pBd4.TabStop = false;
            pBd4.MouseDown += Dice_MouseDown;
            pBd4.MouseUp += Dice_MouseUp;
            // 
            // pBd6
            // 
            pBd6.Image = (Image)resources.GetObject("pBd6.Image");
            pBd6.Location = new Point(135, 49);
            pBd6.Margin = new Padding(20);
            pBd6.Name = "pBd6";
            pBd6.Size = new Size(66, 68);
            pBd6.TabIndex = 25;
            pBd6.TabStop = false;
            pBd6.MouseDown += Dice_MouseDown;
            pBd6.MouseUp += Dice_MouseUp;
            // 
            // pBd8
            // 
            pBd8.Image = (Image)resources.GetObject("pBd8.Image");
            pBd8.Location = new Point(241, 49);
            pBd8.Margin = new Padding(20);
            pBd8.Name = "pBd8";
            pBd8.Size = new Size(66, 69);
            pBd8.TabIndex = 26;
            pBd8.TabStop = false;
            pBd8.MouseDown += Dice_MouseDown;
            pBd8.MouseUp += Dice_MouseUp;
            // 
            // pBd10
            // 
            pBd10.Image = (Image)resources.GetObject("pBd10.Image");
            pBd10.Location = new Point(347, 49);
            pBd10.Margin = new Padding(20);
            pBd10.Name = "pBd10";
            pBd10.Size = new Size(66, 69);
            pBd10.TabIndex = 27;
            pBd10.TabStop = false;
            pBd10.MouseDown += Dice_MouseDown;
            pBd10.MouseUp += Dice_MouseUp;
            // 
            // pBd12
            // 
            pBd12.Image = (Image)resources.GetObject("pBd12.Image");
            pBd12.Location = new Point(453, 49);
            pBd12.Margin = new Padding(20);
            pBd12.Name = "pBd12";
            pBd12.Size = new Size(66, 69);
            pBd12.TabIndex = 28;
            pBd12.TabStop = false;
            pBd12.MouseDown += Dice_MouseDown;
            pBd12.MouseUp += Dice_MouseUp;
            // 
            // pBd20
            // 
            pBd20.Location = new Point(559, 52);
            pBd20.Margin = new Padding(20);
            pBd20.Name = "pBd20";
            pBd20.Size = new Size(66, 62);
            pBd20.TabIndex = 29;
            pBd20.TabStop = false;
            pBd20.MouseDown += Dice_MouseDown;
            // 
            // pBd100
            // 
            pBd100.Location = new Point(665, 52);
            pBd100.Margin = new Padding(20);
            pBd100.Name = "pBd100";
            pBd100.Size = new Size(66, 62);
            pBd100.TabIndex = 30;
            pBd100.TabStop = false;
            pBd100.MouseDown += Dice_MouseDown;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1106, 188);
            dataGridView1.TabIndex = 31;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(29, 394);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1106, 188);
            dataGridView2.TabIndex = 32;
            // 
            // button1
            // 
            button1.Location = new Point(1168, 200);
            button1.Name = "button1";
            button1.Size = new Size(120, 92);
            button1.TabIndex = 33;
            button1.Text = "Excluir tudo da Tabelas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(623, 951);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 30);
            checkBox1.TabIndex = 34;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmInicial
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1902, 993);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(pBd100);
            Controls.Add(pBd20);
            Controls.Add(pBd12);
            Controls.Add(pBd10);
            Controls.Add(pBd8);
            Controls.Add(pBd6);
            Controls.Add(pBd4);
            Controls.Add(tbModificador);
            Controls.Add(btLimpar);
            Controls.Add(btnRolar);
            Controls.Add(label1);
            Controls.Add(lbValorResultado);
            Controls.Add(lbResultado);
            Controls.Add(nUDd100);
            Controls.Add(nUDd20);
            Controls.Add(nUDd12);
            Controls.Add(nUDd10);
            Controls.Add(nUDd8);
            Controls.Add(nUDd6);
            Controls.Add(nUDd4);
            Controls.Add(menuStrip1);
            Font = new Font("Pixel UniCode", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInicial";
            Text = "Mesa do Mestre";
            WindowState = FormWindowState.Maximized;
            Load += frmInicial_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDd4).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd6).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd8).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd10).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd12).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd20).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd100).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBd4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBd6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBd8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBd10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBd12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBd20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBd100).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem campanhaToolStripMenuItem;
        private ToolStripMenuItem tsmiAdicionarAventura;
        private ToolStripMenuItem tsmiRemoverAventura;
        private ToolStripMenuItem dadosToolStripMenuItem;
        private ToolStripMenuItem tsmiAventuras;
        private ToolStripSeparator toolStripSeparator1;
        private NumericUpDown nUDd4;
        private NumericUpDown nUDd6;
        private NumericUpDown nUDd8;
        private NumericUpDown nUDd10;
        private NumericUpDown nUDd12;
        private NumericUpDown nUDd20;
        private NumericUpDown nUDd100;
        private Label lbResultado;
        private Label lbValorResultado;
        private Label label1;
        private Button btnRolar;
        private Button btLimpar;
        private MaskedTextBox tbModificador;
        private ToolStripMenuItem carregarJogadoresToolStripMenuItem;
        private PictureBox pBd4;
        private PictureBox pBd6;
        private PictureBox pBd8;
        private PictureBox pBd10;
        private PictureBox pBd12;
        private PictureBox pBd20;
        private PictureBox pBd100;
        private DataGridView dataGridView1;
        private ToolStripMenuItem adicionarJogadorToolStripMenuItem;
        private DataGridView dataGridView2;
        private Button button1;
        private Panel panel1;
        private CheckBox checkBox1;
    }
}