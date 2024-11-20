namespace Mestre_de_Rpg
{
    partial class frmRegistroAventura
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
            lbRAventura = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbRAventura
            // 
            lbRAventura.AutoSize = true;
            lbRAventura.Font = new Font("Pixel UniCode", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRAventura.Location = new Point(12, 29);
            lbRAventura.Margin = new Padding(3, 20, 3, 0);
            lbRAventura.Name = "lbRAventura";
            lbRAventura.Size = new Size(188, 32);
            lbRAventura.TabIndex = 0;
            lbRAventura.Text = "Nome da Aventura:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Pixel UniCode", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(206, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 38);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Pixel UniCode", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(352, 78);
            button1.Name = "button1";
            button1.Size = new Size(108, 38);
            button1.TabIndex = 2;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // frmRegistroAventura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 128);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(lbRAventura);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmRegistroAventura";
            Text = "Registro de Aventura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbRAventura;
        private TextBox textBox1;
        private Button button1;
    }
}