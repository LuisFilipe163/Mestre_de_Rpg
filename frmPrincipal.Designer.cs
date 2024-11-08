namespace Mestre_de_Rpg
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            aventurasToolStripMenuItem = new ToolStripMenuItem();
            tsmiAdicionarAventura = new ToolStripMenuItem();
            tsmiExcluirAventura = new ToolStripMenuItem();
            tmsiAventurasReg = new ToolStripMenuItem();
            dadosToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            tlpTodosDados = new TableLayoutPanel();
            nUDd4 = new NumericUpDown();
            nUDd6 = new NumericUpDown();
            nUDd8 = new NumericUpDown();
            nUDd10 = new NumericUpDown();
            nUDd12 = new NumericUpDown();
            nUDd20 = new NumericUpDown();
            nUDd100 = new NumericUpDown();
            tbModificador = new TextBox();
            pbD20 = new PictureBox();
            pbD100 = new PictureBox();
            pbD12 = new PictureBox();
            pbD10 = new PictureBox();
            pbD8 = new PictureBox();
            pbD6 = new PictureBox();
            pbD4 = new PictureBox();
            sbLimpar = new Button();
            lbModificador = new Label();
            label1 = new Label();
            pbLogo = new PictureBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tlpTodosDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDd4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDd100).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbD20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbD100).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbD12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbD10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbD8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbD6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbD4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aventurasToolStripMenuItem, dadosToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // aventurasToolStripMenuItem
            // 
            resources.ApplyResources(aventurasToolStripMenuItem, "aventurasToolStripMenuItem");
            aventurasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmiAdicionarAventura, tsmiExcluirAventura, tmsiAventurasReg });
            aventurasToolStripMenuItem.Name = "aventurasToolStripMenuItem";
            // 
            // tsmiAdicionarAventura
            // 
            resources.ApplyResources(tsmiAdicionarAventura, "tsmiAdicionarAventura");
            tsmiAdicionarAventura.Name = "tsmiAdicionarAventura";
            tsmiAdicionarAventura.Click += tsmiAdicionarAventura_Click;
            // 
            // tsmiExcluirAventura
            // 
            resources.ApplyResources(tsmiExcluirAventura, "tsmiExcluirAventura");
            tsmiExcluirAventura.Name = "tsmiExcluirAventura";
            // 
            // tmsiAventurasReg
            // 
            resources.ApplyResources(tmsiAventurasReg, "tmsiAventurasReg");
            tmsiAventurasReg.Name = "tmsiAventurasReg";
            // 
            // dadosToolStripMenuItem
            // 
            resources.ApplyResources(dadosToolStripMenuItem, "dadosToolStripMenuItem");
            dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.BackColor = Color.Bisque;
            tableLayoutPanel1.Controls.Add(tlpTodosDados, 1, 0);
            tableLayoutPanel1.Controls.Add(pbLogo, 0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tlpTodosDados
            // 
            resources.ApplyResources(tlpTodosDados, "tlpTodosDados");
            tlpTodosDados.Controls.Add(nUDd4, 0, 2);
            tlpTodosDados.Controls.Add(nUDd6, 1, 2);
            tlpTodosDados.Controls.Add(nUDd8, 2, 2);
            tlpTodosDados.Controls.Add(nUDd10, 3, 2);
            tlpTodosDados.Controls.Add(nUDd12, 4, 2);
            tlpTodosDados.Controls.Add(nUDd20, 5, 2);
            tlpTodosDados.Controls.Add(nUDd100, 6, 2);
            tlpTodosDados.Controls.Add(tbModificador, 8, 1);
            tlpTodosDados.Controls.Add(pbD20, 5, 0);
            tlpTodosDados.Controls.Add(pbD100, 6, 0);
            tlpTodosDados.Controls.Add(pbD12, 4, 0);
            tlpTodosDados.Controls.Add(pbD10, 3, 0);
            tlpTodosDados.Controls.Add(pbD8, 2, 0);
            tlpTodosDados.Controls.Add(pbD6, 1, 0);
            tlpTodosDados.Controls.Add(pbD4, 0, 0);
            tlpTodosDados.Controls.Add(sbLimpar, 7, 2);
            tlpTodosDados.Controls.Add(lbModificador, 8, 0);
            tlpTodosDados.Controls.Add(label1, 7, 0);
            tlpTodosDados.Name = "tlpTodosDados";
            // 
            // nUDd4
            // 
            resources.ApplyResources(nUDd4, "nUDd4");
            nUDd4.Name = "nUDd4";
            // 
            // nUDd6
            // 
            resources.ApplyResources(nUDd6, "nUDd6");
            nUDd6.Name = "nUDd6";
            // 
            // nUDd8
            // 
            resources.ApplyResources(nUDd8, "nUDd8");
            nUDd8.Name = "nUDd8";
            // 
            // nUDd10
            // 
            resources.ApplyResources(nUDd10, "nUDd10");
            nUDd10.Name = "nUDd10";
            // 
            // nUDd12
            // 
            resources.ApplyResources(nUDd12, "nUDd12");
            nUDd12.Name = "nUDd12";
            // 
            // nUDd20
            // 
            resources.ApplyResources(nUDd20, "nUDd20");
            nUDd20.Name = "nUDd20";
            // 
            // nUDd100
            // 
            resources.ApplyResources(nUDd100, "nUDd100");
            nUDd100.Name = "nUDd100";
            // 
            // tbModificador
            // 
            resources.ApplyResources(tbModificador, "tbModificador");
            tbModificador.Name = "tbModificador";
            // 
            // pbD20
            // 
            resources.ApplyResources(pbD20, "pbD20");
            pbD20.Name = "pbD20";
            tlpTodosDados.SetRowSpan(pbD20, 2);
            pbD20.TabStop = false;
            pbD20.MouseDown += Dice_MouseDown;
            pbD20.MouseUp += Dice_MouseUp;
            // 
            // pbD100
            // 
            resources.ApplyResources(pbD100, "pbD100");
            pbD100.Name = "pbD100";
            tlpTodosDados.SetRowSpan(pbD100, 2);
            pbD100.TabStop = false;
            pbD100.MouseDown += Dice_MouseDown;
            pbD100.MouseUp += Dice_MouseUp;
            // 
            // pbD12
            // 
            resources.ApplyResources(pbD12, "pbD12");
            pbD12.Name = "pbD12";
            tlpTodosDados.SetRowSpan(pbD12, 2);
            pbD12.TabStop = false;
            pbD12.MouseDown += Dice_MouseDown;
            pbD12.MouseUp += Dice_MouseUp;
            // 
            // pbD10
            // 
            resources.ApplyResources(pbD10, "pbD10");
            pbD10.Name = "pbD10";
            tlpTodosDados.SetRowSpan(pbD10, 2);
            pbD10.TabStop = false;
            pbD10.MouseDown += Dice_MouseDown;
            pbD10.MouseUp += Dice_MouseUp;
            // 
            // pbD8
            // 
            resources.ApplyResources(pbD8, "pbD8");
            pbD8.Name = "pbD8";
            tlpTodosDados.SetRowSpan(pbD8, 2);
            pbD8.TabStop = false;
            pbD8.MouseDown += Dice_MouseDown;
            pbD8.MouseUp += Dice_MouseUp;
            // 
            // pbD6
            // 
            resources.ApplyResources(pbD6, "pbD6");
            pbD6.Name = "pbD6";
            tlpTodosDados.SetRowSpan(pbD6, 2);
            pbD6.TabStop = false;
            pbD6.MouseDown += Dice_MouseDown;
            pbD6.MouseUp += Dice_MouseUp;
            // 
            // pbD4
            // 
            resources.ApplyResources(pbD4, "pbD4");
            pbD4.Name = "pbD4";
            tlpTodosDados.SetRowSpan(pbD4, 2);
            pbD4.TabStop = false;
            pbD4.MouseDown += Dice_MouseDown;
            pbD4.MouseUp += Dice_MouseUp;
            // 
            // sbLimpar
            // 
            resources.ApplyResources(sbLimpar, "sbLimpar");
            tlpTodosDados.SetColumnSpan(sbLimpar, 2);
            sbLimpar.Name = "sbLimpar";
            sbLimpar.UseVisualStyleBackColor = true;
            sbLimpar.Click += btLimpar_Click;
            // 
            // lbModificador
            // 
            resources.ApplyResources(lbModificador, "lbModificador");
            lbModificador.Name = "lbModificador";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            tlpTodosDados.SetRowSpan(label1, 2);
            label1.Click += label1_Click;
            // 
            // pbLogo
            // 
            resources.ApplyResources(pbLogo, "pbLogo");
            pbLogo.Name = "pbLogo";
            pbLogo.TabStop = false;
            // 
            // frmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tlpTodosDados.ResumeLayout(false);
            tlpTodosDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDd4).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd6).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd8).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd10).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd12).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd20).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDd100).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbD20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbD100).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbD12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbD10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbD8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbD6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbD4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aventurasToolStripMenuItem;
        private ToolStripMenuItem tsmiAdicionarAventura;
        private ToolStripMenuItem tsmiExcluirAventura;
        private ToolStripMenuItem tmsiAventurasReg;
        private ToolStripMenuItem dadosToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tlpTodosDados;
        private PictureBox pbD4;
        private PictureBox pbD6;
        private PictureBox pbD8;
        private PictureBox pbD10;
        private PictureBox pbD12;
        private PictureBox pbD20;
        private PictureBox pbD100;
        private NumericUpDown nUDd4;
        private NumericUpDown nUDd6;
        private NumericUpDown nUDd8;
        private NumericUpDown nUDd10;
        private NumericUpDown nUDd12;
        private NumericUpDown nUDd20;
        private NumericUpDown nUDd100;
        private Label label1;
        private TextBox tbModificador;
        private Button sbLimpar;
        private Label lbModificador;
        private PictureBox pbLogo;
    }
}