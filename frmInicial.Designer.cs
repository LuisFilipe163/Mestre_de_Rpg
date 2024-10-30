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
            menuStrip1 = new MenuStrip();
            campanhaToolStripMenuItem = new ToolStripMenuItem();
            adicionarCampanhaToolStripMenuItem = new ToolStripMenuItem();
            camapnhasToolStripMenuItem = new ToolStripMenuItem();
            aventurasToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            dadosToolStripMenuItem = new ToolStripMenuItem();
            d4 = new Button();
            d6 = new Button();
            d8 = new Button();
            d10 = new Button();
            d100 = new Button();
            d20 = new Button();
            d12 = new Button();
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
            textBox1 = new TextBox();
            btnRolar = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDd4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd100).BeginInit();
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
            menuStrip1.Size = new Size(1262, 32);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // campanhaToolStripMenuItem
            // 
            campanhaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarCampanhaToolStripMenuItem, camapnhasToolStripMenuItem, aventurasToolStripMenuItem, toolStripSeparator1 });
            campanhaToolStripMenuItem.Name = "campanhaToolStripMenuItem";
            campanhaToolStripMenuItem.Size = new Size(94, 26);
            campanhaToolStripMenuItem.Text = "Campanha";
            // 
            // adicionarCampanhaToolStripMenuItem
            // 
            adicionarCampanhaToolStripMenuItem.Name = "adicionarCampanhaToolStripMenuItem";
            adicionarCampanhaToolStripMenuItem.Size = new Size(223, 26);
            adicionarCampanhaToolStripMenuItem.Text = "Adicionar Aventura";
            // 
            // camapnhasToolStripMenuItem
            // 
            camapnhasToolStripMenuItem.Name = "camapnhasToolStripMenuItem";
            camapnhasToolStripMenuItem.Size = new Size(223, 26);
            camapnhasToolStripMenuItem.Text = "Excluir Aventura";
            // 
            // aventurasToolStripMenuItem
            // 
            aventurasToolStripMenuItem.Name = "aventurasToolStripMenuItem";
            aventurasToolStripMenuItem.Size = new Size(223, 26);
            aventurasToolStripMenuItem.Text = "Aventuras";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(220, 6);
            // 
            // dadosToolStripMenuItem
            // 
            dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            dadosToolStripMenuItem.Size = new Size(65, 26);
            dadosToolStripMenuItem.Text = "Dados";
            // 
            // d4
            // 
            d4.Location = new Point(16, 62);
            d4.Margin = new Padding(3, 4, 3, 4);
            d4.Name = "d4";
            d4.Size = new Size(106, 38);
            d4.TabIndex = 2;
            d4.Text = "d4";
            d4.UseVisualStyleBackColor = true;
            d4.Click += Dice_Click;
            // 
            // d6
            // 
            d6.Location = new Point(128, 62);
            d6.Margin = new Padding(3, 4, 3, 4);
            d6.Name = "d6";
            d6.Size = new Size(106, 38);
            d6.TabIndex = 3;
            d6.Text = "d6";
            d6.UseVisualStyleBackColor = true;
            d6.Click += Dice_Click;
            // 
            // d8
            // 
            d8.Location = new Point(241, 62);
            d8.Margin = new Padding(3, 4, 3, 4);
            d8.Name = "d8";
            d8.Size = new Size(106, 38);
            d8.TabIndex = 4;
            d8.Text = "d8";
            d8.UseVisualStyleBackColor = true;
            d8.Click += Dice_Click;
            // 
            // d10
            // 
            d10.Location = new Point(353, 62);
            d10.Margin = new Padding(3, 4, 3, 4);
            d10.Name = "d10";
            d10.Size = new Size(106, 38);
            d10.TabIndex = 5;
            d10.Text = "d10";
            d10.UseVisualStyleBackColor = true;
            d10.Click += Dice_Click;
            // 
            // d100
            // 
            d100.Location = new Point(691, 62);
            d100.Margin = new Padding(3, 4, 3, 4);
            d100.Name = "d100";
            d100.Size = new Size(106, 38);
            d100.TabIndex = 6;
            d100.Text = "d100";
            d100.UseVisualStyleBackColor = true;
            d100.Click += Dice_Click;
            // 
            // d20
            // 
            d20.Location = new Point(578, 62);
            d20.Margin = new Padding(3, 4, 3, 4);
            d20.Name = "d20";
            d20.Size = new Size(106, 38);
            d20.TabIndex = 7;
            d20.Text = "d20";
            d20.UseVisualStyleBackColor = true;
            d20.Click += Dice_Click;
            // 
            // d12
            // 
            d12.Location = new Point(466, 62);
            d12.Margin = new Padding(3, 4, 3, 4);
            d12.Name = "d12";
            d12.Size = new Size(106, 38);
            d12.TabIndex = 8;
            d12.Text = "d12";
            d12.UseVisualStyleBackColor = true;
            d12.Click += Dice_Click;
            // 
            // nUDd4
            // 
            nUDd4.Location = new Point(16, 108);
            nUDd4.Margin = new Padding(3, 4, 3, 4);
            nUDd4.Name = "nUDd4";
            nUDd4.Size = new Size(106, 33);
            nUDd4.TabIndex = 9;
            nUDd4.TextAlign = HorizontalAlignment.Center;
            // 
            // nUDd6
            // 
            nUDd6.Location = new Point(128, 108);
            nUDd6.Margin = new Padding(3, 4, 3, 4);
            nUDd6.Name = "nUDd6";
            nUDd6.Size = new Size(106, 33);
            nUDd6.TabIndex = 10;
            nUDd6.TextAlign = HorizontalAlignment.Center;
            // 
            // nUDd8
            // 
            nUDd8.Location = new Point(241, 108);
            nUDd8.Margin = new Padding(3, 4, 3, 4);
            nUDd8.Name = "nUDd8";
            nUDd8.Size = new Size(106, 33);
            nUDd8.TabIndex = 11;
            nUDd8.TextAlign = HorizontalAlignment.Center;
            // 
            // nUDd10
            // 
            nUDd10.Location = new Point(353, 108);
            nUDd10.Margin = new Padding(3, 4, 3, 4);
            nUDd10.Name = "nUDd10";
            nUDd10.Size = new Size(106, 33);
            nUDd10.TabIndex = 12;
            nUDd10.TextAlign = HorizontalAlignment.Center;
            // 
            // nUDd12
            // 
            nUDd12.Location = new Point(466, 108);
            nUDd12.Margin = new Padding(3, 4, 3, 4);
            nUDd12.Name = "nUDd12";
            nUDd12.Size = new Size(106, 33);
            nUDd12.TabIndex = 13;
            nUDd12.TextAlign = HorizontalAlignment.Center;
            // 
            // nUDd20
            // 
            nUDd20.Location = new Point(578, 108);
            nUDd20.Margin = new Padding(3, 4, 3, 4);
            nUDd20.Name = "nUDd20";
            nUDd20.Size = new Size(106, 33);
            nUDd20.TabIndex = 14;
            nUDd20.TextAlign = HorizontalAlignment.Center;
            // 
            // nUDd100
            // 
            nUDd100.Location = new Point(691, 108);
            nUDd100.Margin = new Padding(3, 4, 3, 4);
            nUDd100.Name = "nUDd100";
            nUDd100.Size = new Size(106, 33);
            nUDd100.TabIndex = 15;
            nUDd100.TextAlign = HorizontalAlignment.Center;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(1030, 68);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(92, 26);
            lbResultado.TabIndex = 16;
            lbResultado.Text = "Resultado: ";
            // 
            // lbValorResultado
            // 
            lbValorResultado.AutoSize = true;
            lbValorResultado.Location = new Point(1129, 68);
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
            // textBox1
            // 
            textBox1.Location = new Point(850, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 33);
            textBox1.TabIndex = 19;
            // 
            // btnRolar
            // 
            btnRolar.Location = new Point(850, 105);
            btnRolar.Name = "btnRolar";
            btnRolar.Size = new Size(159, 36);
            btnRolar.TabIndex = 20;
            btnRolar.Text = "Rolar Dados";
            btnRolar.UseVisualStyleBackColor = true;
            btnRolar.Click += btnRolar_Click;
            // 
            // frmInicial
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnRolar);
            Controls.Add(textBox1);
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
            Controls.Add(d12);
            Controls.Add(d20);
            Controls.Add(d100);
            Controls.Add(d10);
            Controls.Add(d8);
            Controls.Add(d6);
            Controls.Add(d4);
            Controls.Add(menuStrip1);
            Font = new Font("Pixel UniCode", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInicial";
            Text = "frmInicial";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDd4).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd6).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd8).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd10).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd12).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd20).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd100).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem campanhaToolStripMenuItem;
        private ToolStripMenuItem adicionarCampanhaToolStripMenuItem;
        private ToolStripMenuItem camapnhasToolStripMenuItem;
        private ToolStripMenuItem dadosToolStripMenuItem;
        private ToolStripMenuItem aventurasToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private Button d4;
        private Button d6;
        private Button d8;
        private Button d10;
        private Button d100;
        private Button d20;
        private Button d12;
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
        private TextBox textBox1;
        private Button btnRolar;
    }
}