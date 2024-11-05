using Mestre_de_Rpg.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mestre_de_Rpg
{
    public partial class frmInicial : Form
    {
        public Dictionary<NumericUpDown, int> dados;
        private readonly string botaoNormald4 = @"..\..\..\Icons\D4_default.png";
        private readonly string botaoClicadod4 = @"..\..\..\Icons\D4_selected.png";
        private readonly string botaoNormald6 = @"..\..\..\Icons\D6_default.png";
        private readonly string botaoClicadod6 = @"..\..\..\Icons\D6_selected.png";
        private readonly string botaoNormald8 = @"..\..\..\Icons\D8_default.png";
        private readonly string botaoClicadod8 = @"..\..\..\Icons\D8_selected.png";
        private readonly string botaoNormald10 = @"..\..\..\Icons\D10_default.png";
        private readonly string botaoClicadod10 = @"..\..\..\Icons\D10_selected.png";

        public frmInicial()
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
            pBd4.Image = Image.FromFile(botaoNormald4);
            pBd6.Image = Image.FromFile(botaoNormald6);
            pBd8.Image = Image.FromFile(botaoNormald8);
            pBd10.Image = Image.FromFile(botaoNormald10);
        }

        /// <summary>
        /// Rola a quantidade total de dados selecionados no menu
        /// </summary>
        private void btnRolar_Click(object sender, EventArgs e)
        {
            List<int> totalResultado = [];

            foreach (var logicaDados in dados)
            {
                NumericUpDown qtddados = logicaDados.Key;
                int qtdlados = logicaDados.Value;

                if (qtddados.Value > 0)
                {
                    for (int i = 0; i < qtddados.Value; i++)
                    {
                        int resultado = Dado.RolarDados(1, qtdlados);
                        totalResultado.Add(resultado);
                    }
                    //MessageBox.Show($"{qtddados.Value} dados de {qtdlados} lados rolados, resultados: {string.Join(", ", totalResultado)}");
                }
            }
            _ = int.TryParse(tbModificador.Text, out int modificador);

            string resultadoroll = $"Soma da Rolagens ({totalResultado.Sum()}) + Modificador ({modificador}) = {(totalResultado.Sum() + modificador)}";

            lbValorResultado.Text = resultadoroll;
        }

        /// <summary>
        /// Reseta o valor dos NumericUpDown para 0
        /// </summary>
        private void btLimpar_Click(object sender, EventArgs e)
        {
            foreach (NumericUpDown nUDValor in dados.Keys)
            {
                nUDValor.Value = 0;
            }
        }

        /// <summary>
        /// Incrementa em 1 a quantidade do dado selecionado
        /// </summary>
        private void Dice_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox button)
            {
                switch (button.Name)
                {
                    case "pBd4":
                        pBd4.Image = Image.FromFile(botaoClicadod4);
                        nUDd4.Value += 1;
                        break;
                    case "pBd6":
                        pBd6.Image = Image.FromFile(botaoClicadod6);
                        nUDd6.Value += 1;
                        break;
                    case "pBd8":
                        pBd8.Image = Image.FromFile(botaoClicadod8);
                        nUDd8.Value += 1;
                        break;
                    case "pBd10":
                        pBd10.Image = Image.FromFile(botaoClicadod10);
                        nUDd10.Value += 1;
                        break;
                    case "pBd12":
                        nUDd12.Value += 1;
                        break;
                    case "pBd20":
                        nUDd20.Value += 1;
                        break;
                    case "pBd100":
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
                    case "pBd4":
                        pBd4.Image = Image.FromFile(botaoNormald4);
                        break;
                    case "pBd6":
                        pBd6.Image = Image.FromFile(botaoNormald6);
                        break;
                    case "pBd8":
                        pBd8.Image = Image.FromFile(botaoNormald8);
                        break;
                    case "pBd10":
                        pBd10.Image = Image.FromFile(botaoNormald10);
                        break;
                    case "pBd12":
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
