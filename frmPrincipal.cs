using Mestre_de_Rpg.DB;
using Mestre_de_Rpg.Entities;
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
        private readonly string botaoNormald20 = @"..\..\..\Icons\D20_default.png";
        private readonly string botaoClicadod20 = @"..\..\..\Icons\D20_selected.png";
        private readonly string botaoNormald100 = @"..\..\..\Icons\D100_default.png";
        private readonly string botaoClicadod100 = @"..\..\..\Icons\D100_selected.png";
        private readonly string deathsaveunchecked = @"..\..\..\Icons\Radio_button_unchecked.png";
        private readonly string deathsavechecked = @"..\..\..\Icons\Radio_button_checked.png";


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
            pbD20.Image = Image.FromFile(botaoNormald20);
            pbD100.Image = Image.FromFile(botaoNormald100);
        }

        #region Métodos
        private void CarregarAventurasNoMenu()
        {
            tmsiAventurasReg.DropDownItems.Clear();
            DataTable aventuras = DALAventura.CarregaAventuras();
            foreach (DataRow row in aventuras.Rows)
            {
                string nomeAventura = row["nome"].ToString();
                int idAventura = Convert.ToInt32(row["id_aventura"]);
                ToolStripMenuItem aventuraItem = new(nomeAventura)
                {
                    Tag = idAventura
                };
                tmsiAventurasReg.DropDownItems.Add(aventuraItem);
            }
        }
        #endregion


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
                        pbD20.Image = Image.FromFile(botaoClicadod20);
                        nUDd20.Value += 1;
                        break;
                    case "pbD100":
                        pbD100.Image = Image.FromFile(botaoClicadod100);
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
                    case "pbD20":
                        pbD20.Image = Image.FromFile(botaoNormald20);
                        break;
                    case "pbD100":
                        pbD100.Image = Image.FromFile(botaoNormald100);
                        break;
                }
            }
        }

        private void tsmiAdicionarAventura_Click(object sender, EventArgs e)
        {
            frmRegistroAventura registroAventuraForm = new frmRegistroAventura();
            registroAventuraForm.ShowDialog();
            CarregarAventurasNoMenu();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            foreach (NumericUpDown nUDValor in dados.Keys)
            {
                nUDValor.Value = 0;
            }
        }

        private void btnRolar_Click(object sender, EventArgs e)
        {
            if (dados.All(dado => dado.Key.Value == 0))
            {
                lbValorResultado.Text = "";
                return;
            }

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
                }
            }

            _ = int.TryParse(tbModificador.Text, out int modificador);

            string resultadoroll = $"Soma da Rolagens ({totalResultado.Sum()}) + Modificador ({modificador}) = {(totalResultado.Sum() + modificador)}";

            lbValorResultado.Text = resultadoroll;
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
