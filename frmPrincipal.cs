using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mestre_de_Rpg
{
    public partial class frmPrincipal : Form
    {
        public Dictionary<NumericUpDown, int> dados;
        public Dictionary<string, int> DictAventuras;
        private readonly string botaoNormald4 = @"..\..\..\Icons\D4_default.png";
        private readonly string botaoClicadod4 = @"..\..\..\Icons\D4_selected.png";
        private readonly string botaoNormald6 = @"..\..\..\Icons\D6_default.png";
        private readonly string botaoClicadod6 = @"..\..\..\Icons\D6_selected.png";
        private readonly string botaoNormald8 = @"..\..\..\Icons\D8_default.png";
        private readonly string botaoClicadod8 = @"..\..\..\Icons\D8_selected.png";
        private readonly string botaoNormald10 = @"..\..\..\Icons\D10_default.png";
        private readonly string botaoClicadod10 = @"..\..\..\Icons\D10_selected.png";
        private readonly string botaoNormald12 = @"..\..\..\Icons\D12_default.png";
        private readonly string botaoClicadod12 = @"..\..\..\Icons\D12_selected.png";

        public frmPrincipal()
        {
            InitializeComponent();
            dados = new Dictionary<NumericUpDown, int>()
            {
                {nUDd4, 4 },
                {nUDd6, 6 },
                {nUDd8, 8 },
                {nUDd10, 10},
                {nUDd12, 12},
                {nUDd20, 20},
                {nUDd100, 100},
            };
            pbD4.Image = Image.FromFile(botaoNormald4);
            pbD6.Image = Image.FromFile(botaoNormald6);
            pbD8.Image = Image.FromFile(botaoNormald8);
            pbD10.Image = Image.FromFile(botaoNormald10);
            pbD12.Image = Image.FromFile(botaoNormald12);
        }

        private void Dice_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox button)
            {
                switch (button.Name)
                {
                    case "pbD4":
                        pbD4.Image = Image.FromFile(botaoClicadod4);
                        nUDd4.Value += 1;
                        break;
                    case "pbD6":
                        pbD6.Image = Image.FromFile(botaoClicadod6);
                        nUDd6.Value += 1;
                        break;
                    case "pbD8":
                        pbD8.Image = Image.FromFile(botaoClicadod8);
                        nUDd8.Value += 1;
                        break;
                    case "pbD10":
                        pbD10.Image = Image.FromFile(botaoClicadod10);
                        nUDd10.Value += 1;
                        break;
                    case "pbD12":
                        pbD12.Image = Image.FromFile(botaoClicadod12);
                        nUDd12.Value += 1;
                        break;
                    case "pbD20":
                        nUDd20.Value += 1;
                        break;
                    case "pbD100":
                        nUDd100.Value += 1;
                        break;
                }
            }
        }

        private void Dice_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox button)
            {
                switch (button.Name)
                {
                    case "pbD4":
                        pbD4.Image = Image.FromFile(botaoNormald4);
                        break;
                    case "pbD6":
                        pbD6.Image = Image.FromFile(botaoNormald6);
                        break;
                    case "pbD8":
                        pbD8.Image = Image.FromFile(botaoNormald8);
                        break;
                    case "pbD10":
                        pbD10.Image = Image.FromFile(botaoNormald10);
                        break;
                    case "pbD12":
                        pbD12.Image = Image.FromFile(botaoNormald12);
                        break;
                    case "pBd20":
                        break;
                    case "pBd100":
                        break;
                }
            }
        }
    }
}
