namespace Mestre_de_Rpg.Formularios_adicionais
{
    partial class frmExcluirAventuras
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
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 13);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(393, 179);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(307, 199);
            button1.Name = "button1";
            button1.Size = new Size(98, 34);
            button1.TabIndex = 1;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmExcluirAventuras
            // 
            AutoScaleDimensions = new SizeF(8F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 245);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Font = new Font("Pixel UniCode", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmExcluirAventuras";
            Text = "frmExcluirAventuras";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
    }
}