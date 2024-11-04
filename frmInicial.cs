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
        }

        /// <summary>
        /// Incrementa em 1 a quantidade do dado selecionado
        /// </summary>
        private void Dice_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "d4":
                        nUDd4.Value += 1;
                        break;
                    case "d6":
                        nUDd6.Value += 1;
                        break;
                    case "d8":
                        nUDd8.Value += 1;
                        break;
                    case "d10":
                        nUDd10.Value += 1;
                        break;
                    case "d12":
                        nUDd12.Value += 1;
                        break;
                    case "d20":
                        nUDd20.Value += 1;
                        break;
                    case "d100":
                        nUDd100.Value += 1;
                        break;
                }
            }
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
                    MessageBox.Show($"{qtddados.Value} dados de {qtdlados} lados rolados, resultados: {string.Join(", ", totalResultado)}");
                }
            }
            _ = int.TryParse(tbModificador.Text, out int modificador);

            lbValorResultado.Text = (totalResultado.Sum() + modificador).ToString();

        }

        /// <summary>
        /// Reset o valor dos NumericUpDown para 0
        /// </summary>
        private void btLimpar_Click(object sender, EventArgs e)
        {
            foreach (NumericUpDown nUDValor in dados.Keys)
            {
                nUDValor.Value = 0;
            }
        }
    }
}
