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
            adicionarAventuraToolStripMenuItem = new ToolStripMenuItem();
            excluirAventuraToolStripMenuItem = new ToolStripMenuItem();
            aventurasToolStripMenuItem1 = new ToolStripMenuItem();
            dadosToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            tlpTodosDados = new TableLayoutPanel();
            pbD4 = new PictureBox();
            pbD6 = new PictureBox();
            pbD8 = new PictureBox();
            pbD10 = new PictureBox();
            pbD12 = new PictureBox();
            pbD20 = new PictureBox();
            pbD100 = new PictureBox();
            nUDd4 = new NumericUpDown();
            nUDd6 = new NumericUpDown();
            nUDd8 = new NumericUpDown();
            nUDd10 = new NumericUpDown();
            nUDd12 = new NumericUpDown();
            nUDd20 = new NumericUpDown();
            nUDd100 = new NumericUpDown();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tlpTodosDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbD4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbD6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbD8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbD10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbD12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbD20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbD100).BeginInit();
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
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aventurasToolStripMenuItem, dadosToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // aventurasToolStripMenuItem
            // 
            resources.ApplyResources(aventurasToolStripMenuItem, "aventurasToolStripMenuItem");
            aventurasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarAventuraToolStripMenuItem, excluirAventuraToolStripMenuItem, aventurasToolStripMenuItem1 });
            aventurasToolStripMenuItem.Name = "aventurasToolStripMenuItem";
            // 
            // adicionarAventuraToolStripMenuItem
            // 
            resources.ApplyResources(adicionarAventuraToolStripMenuItem, "adicionarAventuraToolStripMenuItem");
            adicionarAventuraToolStripMenuItem.Name = "adicionarAventuraToolStripMenuItem";
            // 
            // excluirAventuraToolStripMenuItem
            // 
            resources.ApplyResources(excluirAventuraToolStripMenuItem, "excluirAventuraToolStripMenuItem");
            excluirAventuraToolStripMenuItem.Name = "excluirAventuraToolStripMenuItem";
            // 
            // aventurasToolStripMenuItem1
            // 
            resources.ApplyResources(aventurasToolStripMenuItem1, "aventurasToolStripMenuItem1");
            aventurasToolStripMenuItem1.Name = "aventurasToolStripMenuItem1";
            // 
            // dadosToolStripMenuItem
            // 
            resources.ApplyResources(dadosToolStripMenuItem, "dadosToolStripMenuItem");
            dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(tlpTodosDados, 1, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tlpTodosDados
            // 
            resources.ApplyResources(tlpTodosDados, "tlpTodosDados");
            tlpTodosDados.Controls.Add(pbD4, 0, 0);
            tlpTodosDados.Controls.Add(pbD6, 1, 0);
            tlpTodosDados.Controls.Add(pbD8, 2, 0);
            tlpTodosDados.Controls.Add(pbD10, 3, 0);
            tlpTodosDados.Controls.Add(pbD12, 4, 0);
            tlpTodosDados.Controls.Add(pbD20, 5, 0);
            tlpTodosDados.Controls.Add(pbD100, 6, 0);
            tlpTodosDados.Controls.Add(nUDd4, 0, 1);
            tlpTodosDados.Controls.Add(nUDd6, 1, 1);
            tlpTodosDados.Controls.Add(nUDd8, 2, 1);
            tlpTodosDados.Controls.Add(nUDd10, 3, 1);
            tlpTodosDados.Controls.Add(nUDd12, 4, 1);
            tlpTodosDados.Controls.Add(nUDd20, 5, 1);
            tlpTodosDados.Controls.Add(nUDd100, 6, 1);
            tlpTodosDados.Name = "tlpTodosDados";
            // 
            // pbD4
            // 
            resources.ApplyResources(pbD4, "pbD4");
            pbD4.Name = "pbD4";
            pbD4.TabStop = false;
            pbD4.MouseDown += Dice_MouseDown;
            pbD4.MouseUp += Dice_MouseUp;
            // 
            // pbD6
            // 
            resources.ApplyResources(pbD6, "pbD6");
            pbD6.Name = "pbD6";
            pbD6.TabStop = false;
            pbD6.MouseDown += Dice_MouseDown;
            pbD6.MouseUp += Dice_MouseUp;
            // 
            // pbD8
            // 
            resources.ApplyResources(pbD8, "pbD8");
            pbD8.Name = "pbD8";
            pbD8.TabStop = false;
            pbD8.MouseDown += Dice_MouseDown;
            pbD8.MouseUp += Dice_MouseUp;
            // 
            // pbD10
            // 
            resources.ApplyResources(pbD10, "pbD10");
            pbD10.Name = "pbD10";
            pbD10.TabStop = false;
            pbD10.MouseDown += Dice_MouseDown;
            pbD10.MouseUp += Dice_MouseUp;
            // 
            // pbD12
            // 
            resources.ApplyResources(pbD12, "pbD12");
            pbD12.Name = "pbD12";
            pbD12.TabStop = false;
            pbD12.MouseDown += Dice_MouseDown;
            pbD12.MouseUp += Dice_MouseUp;
            // 
            // pbD20
            // 
            resources.ApplyResources(pbD20, "pbD20");
            pbD20.Name = "pbD20";
            pbD20.TabStop = false;
            // 
            // pbD100
            // 
            resources.ApplyResources(pbD100, "pbD100");
            pbD100.Name = "pbD100";
            pbD100.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pbD4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbD6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbD8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbD10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbD12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbD20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbD100).EndInit();
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
        private ToolStripMenuItem aventurasToolStripMenuItem;
        private ToolStripMenuItem adicionarAventuraToolStripMenuItem;
        private ToolStripMenuItem excluirAventuraToolStripMenuItem;
        private ToolStripMenuItem aventurasToolStripMenuItem1;
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
    }
}