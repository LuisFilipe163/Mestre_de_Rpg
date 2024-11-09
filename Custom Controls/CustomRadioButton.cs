using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Mestre_de_Rpg.Custom_Controls
{
    public class CustomRadioButton : RadioButton
    {
        public int CircleSize { get; set; } = 25;
        public Color SelectedColor { get; set; } = Color.Black;

        public CustomRadioButton()
        {
            this.AutoSize = false;
            this.Size = new Size(CircleSize, CircleSize);
            this.Text = ""; // Remove o texto por padrão
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Limpa a área de desenho
            e.Graphics.Clear(this.BackColor);

            // Define as cores de preenchimento e borda
            Color fillColor = this.Checked ? SelectedColor : Color.White;
            Color borderColor = Color.Black;

            // Calcula o retângulo centralizado para o círculo
            int diameter = CircleSize - 4;
            int offsetX = (this.Width - diameter) / 2;
            int offsetY = (this.Height - diameter) / 2;
            Rectangle rect = new Rectangle(offsetX, offsetY, diameter, diameter);

            // Desenha o círculo do RadioButton
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(fillColor))
            using (Pen pen = new Pen(borderColor, 2))
            {
                e.Graphics.FillEllipse(brush, rect);
                e.Graphics.DrawEllipse(pen, rect);
            }
        }
    }
}
