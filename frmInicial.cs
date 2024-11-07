using Mesa_do_Mestre;
using Mestre_de_Rpg.DB;
using Mestre_de_Rpg.Entities;
using Mestre_de_Rpg.Formularios_adicionais;
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
        private readonly string botaoNormald12 = @"..\..\..\Icons\D12_default.png";
        private readonly string botaoClicadod12 = @"..\..\..\Icons\D12_selected.png";

        public frmInicial()
        {
            InitializeComponent();
            CarregarAventurasNoMenu();
            ExibirAventura();
            ExibirJogadores();
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
            pBd12.Image = Image.FromFile(botaoNormald12);
        }

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
                }
            }

            _ = int.TryParse(tbModificador.Text, out int modificador);

            string resultadoroll = $"Soma da Rolagens ({totalResultado.Sum()}) + Modificador ({modificador}) = {(totalResultado.Sum() + modificador)}";

            lbValorResultado.Text = resultadoroll;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            foreach (NumericUpDown nUDValor in dados.Keys)
            {
                nUDValor.Value = 0;
            }
        }

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
                        pBd12.Image = Image.FromFile(botaoClicadod12);
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
                        pBd12.Image = Image.FromFile(botaoNormald12);
                        break;
                    case "pBd20":
                        break;
                    case "pBd100":
                        break;
                }
            }
        }

        private void tsmiAdicionarAventura_Click(object sender, EventArgs e)
        {
            frmRegistroAventura registroAventuraForm = new frmRegistroAventura();
            registroAventuraForm.ShowDialog();
            CarregarAventurasNoMenu();
            ExibirAventura();
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {
            BancoDados.InicializarBanco();
        }

        private void carregarJogadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirJogadores();
        }

        private void adicionarJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrodePersonagem registroPersonagemForm = new frmRegistrodePersonagem();
            registroPersonagemForm.ShowDialog();
            ExibirJogadores();
        }

        private void tsmiAventuras_Click(object sender, EventArgs e)
        {
            ExibirAventura();
        }

        private void ExibirJogadores()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DALFichaJogador.CarregaJogadores();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void ExibirAventura()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DALAventura.CarregaAventuras();
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void EcluirAventura()
        {
            try
            {
                DataTable aventuras = DALAventura.CarregaAventuras();
                foreach (DataRow row in aventuras.Rows)
                {
                    string nomeAventura = row["nome"].ToString();
                    ToolStripMenuItem aventuraItem = new ToolStripMenuItem(nomeAventura);
                }
                ExibirAventura();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void CarregarAventurasNoMenu()
        {
            tsmiAventuras.DropDownItems.Clear();
            DataTable aventuras = DALAventura.CarregaAventuras();
            foreach (DataRow row in aventuras.Rows)
            {
                string nomeAventura = row["nome"].ToString();
                int idAventura = Convert.ToInt32(row["id_aventura"]);
                ToolStripMenuItem aventuraItem = new(nomeAventura)
                {
                    Tag = idAventura
                };
                tsmiAventuras.DropDownItems.Add(aventuraItem);
            }
        }

        private void tsmiRemoverAventura_Click(object sender, EventArgs e)
        {
            frmExcluirAventuras registroExcluirAForm = new frmExcluirAventuras();
            registroExcluirAForm.ShowDialog();
            CarregarAventurasNoMenu();
            ExibirAventura();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BancoDados.ExcluirTabelas();
            ExibirAventura();
            ExibirJogadores();
        }
    }
}
