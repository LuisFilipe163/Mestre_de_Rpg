using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Mestre_de_Rpg.Entities;

namespace Mesa_do_Mestre
{
    public partial class frmRegistrodePersonagem : Form
    {
        #region Variáveis
        public NumericUpDown[] numericUpDownsEM;
        public NumericUpDown[] allnumericUpDowns;
        public Dictionary<Control, bool> controlePersonagem;
        #endregion  

        public frmRegistrodePersonagem()
        {
            InitializeComponent();
            NumericUpDownsConfig();
            PlayerControlConfig();            
            CheckBoxChecked(ckbSpellSlot, EventArgs.Empty);
            FillComboBox();
            DefaultIndexForm();
        }

        #region Métodos de Configuração
        /// <summary>
        /// Configura os NumericUpDowns do formulario
        /// </summary>
        private void NumericUpDownsConfig()
        {
            allnumericUpDowns = new NumericUpDown[]
            {
                nUDVidaMaxima,
                nUDClasseArmadura,
                nUDQuantidadeInvocacoes,
                nUD1,
                nUD2,
                nUD3,
                nUD4,
                nUD5,
                nUD6,
                nUD7,
                nUD8,
                nUD9
            };

            foreach (var nUpDown in allnumericUpDowns)
            {
                nUpDown.Enter += NumericUpDown_Enter;
                nUpDown.MouseClick += NumericUpDown_MouseClick;
            }

            numericUpDownsEM = new NumericUpDown[]
            {
                nUD1,
                nUD2,
                nUD3,
                nUD4,
                nUD5,
                nUD6,
                nUD7,
                nUD8,
                nUD9
            };
        }
        /// <summary>
        /// Configura o valor de visibilidade do formulario quando indicado ser um registro de jogador/inimigo
        /// </summary>
        private void PlayerControlConfig()
        {
            controlePersonagem = new Dictionary<Control, bool>
            {
                { lbClasse, lbClasse.Visible },
                { cboClasse, cboClasse.Visible },
                { lbNivel, lbNivel.Visible },
                { cboNivel, cboNivel.Visible },
                { lbEspacoMagias, lbEspacoMagias.Visible },
                { ckbSpellSlot, ckbSpellSlot.Visible },
                { lb1, lb1.Visible },
                { lb2, lb2.Visible },
                { lb3, lb3.Visible },
                { lb4, lb4.Visible },
                { lb5, lb5.Visible },
                { lb6, lb6.Visible },
                { lb7, lb7.Visible },
                { lb8, lb8.Visible },
                { lb9, lb9.Visible },
                { nUD1, nUD1.Visible },
                { nUD2, nUD2.Visible },
                { nUD3, nUD3.Visible },
                { nUD4, nUD4.Visible },
                { nUD5, nUD5.Visible },
                { nUD6, nUD6.Visible },
                { nUD7, nUD7.Visible },
                { nUD8, nUD8.Visible },
                { nUD9, nUD9.Visible }
            };
        }         
        /// <summary>
        /// Define o valor padrão dos campos do formulario
        /// </summary>
        private void DefaultIndexForm()
        {
            cboTipodeFicha.SelectedIndex = 0;
            tBNomePersonagem.Clear();
            nUDVidaMaxima.Value = 0;
            nUDClasseArmadura.Value = 0;
            foreach (var nUP in numericUpDownsEM)
            {
                nUP.Value = 0;
            }
            cboClasse.SelectedIndex = -1;
            cboNivel.SelectedIndex = -1;
            ckbSpellSlot.Checked = false;
            btnLimpar.Location = new Point(223, 487);
            btnSalvar.Location = new Point(323, 487);
        }
        /// <summary>
        /// Preenche o ComboBox de classes
        /// </summary>
        private void FillComboBox()
        {
            cboClasse.DataSource = Enum.GetValues(typeof(FichaJogador.Classe));
        }
        #endregion        

        #region Eventos
        void CheckBoxChecked(object sender, EventArgs e)
        {
            if (ckbSpellSlot.Checked)
            {
                foreach (var nUP in numericUpDownsEM)
                {
                    nUP.Enabled = true;
                }
            }
            else
            {
                foreach (var nUP in numericUpDownsEM)
                {
                    nUP.Enabled = false;
                }
            }
        }
        void ChangeTypeForm(object sender, EventArgs e)
        {            
            if (cboTipodeFicha.SelectedIndex == 0)
            {
                lbNivel.Text = "Nível: ";
                nUDVidaMaxima.Maximum = 500;
                tlpQuantidadeInvocacoes.Visible = false;
                this.Size = new System.Drawing.Size(449, 578);
                btnLimpar.Location = new Point(223, 487);
                btnSalvar.Location = new Point(323, 487);
                foreach (var controle in controlePersonagem.Keys)
                {
                    controle.Visible = true;
                }
                for (int i = 30; i >= 21; i--)
                {
                    cboNivel.Items.Remove(i);
                }
            }
            if (cboTipodeFicha.SelectedIndex == 1)
            {
                lbNivel.Text = "CR: ";
                nUDVidaMaxima.Maximum = 1000;
                tlpQuantidadeInvocacoes.Visible = false;
                this.Size = new System.Drawing.Size(449, 578);
                btnLimpar.Location = new Point(223, 487);
                btnSalvar.Location = new Point(323, 487);
                foreach (var controle in controlePersonagem.Keys)
                {
                    controle.Visible = true;
                }
                for (int i = 21; i <= 30; i++)
                {
                    cboNivel.Items.Add(i);
                }
            }
            if (cboTipodeFicha.SelectedIndex == 2)
            {
                nUDVidaMaxima.Maximum = 200;
                lbNivel.Text = "Nível: ";
                tlpQuantidadeInvocacoes.Visible = true;
                btnLimpar.Location = new Point(223, 382);
                btnSalvar.Location = new Point(323, 382);
                this.Size = new System.Drawing.Size(449, 367);
                foreach (var controle in controlePersonagem.Keys)
                {
                    controle.Visible = false;
                }
            }
        }
        void DoClickSalvar(object sender, EventArgs e)
        {
            if (cboTipodeFicha.SelectedIndex == 0)
            {
                if (MessageBox.Show("Deseja salvar o personagem?", "Tábua do Mestre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        CadastraPersonagem();
                        LimpaForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar personagem: " + ex.Message, "Tábua do Mestre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (cboTipodeFicha.SelectedIndex == 1)
            {
                if (MessageBox.Show("Deseja salvar o inimigo?", "Tábua do Mestre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        CadastraPersonagem();
                        LimpaForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar inimigo: " + ex.Message, "Tábua do Mestre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (cboTipodeFicha.SelectedIndex == 2)
            {
                if (MessageBox.Show("Deseja salvar o invocação?", "Tábua do Mestre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        CadastraPersonagem();
                        LimpaForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar invocação: " + ex.Message, "Tábua do Mestre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        void DoClickLimpar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja limpar todos os campos?", "Tabua do Mestre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LimpaForm();
                MessageBox.Show("Campos limpos!", "Tabua do Mestre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Cadastra a entidade a partir do tipo selecionado
        /// </summary>
        private void CadastraPersonagem()
        {            
            if (cboTipodeFicha.SelectedIndex == 0)
            {
                string NomePersonagem = tBNomePersonagem.Text;
                uint VidaMaximaPersonagem = (uint)nUDVidaMaxima.Value;
                uint ClasseArmaduraPersonagem = (uint)nUDClasseArmadura.Value;
                uint[] EspacoMagias = new uint[9]
                {
                (uint)nUD1.Value,
                (uint)nUD2.Value,
                (uint)nUD3.Value,
                (uint)nUD4.Value,
                (uint)nUD5.Value,
                (uint)nUD6.Value,
                (uint)nUD7.Value,
                (uint)nUD8.Value,
                (uint)nUD9.Value
                };
                FichaJogador.Classe ClassePersonagem = (FichaJogador.Classe)cboClasse.SelectedItem;
                uint Nivel = Convert.ToUInt32(cboNivel.SelectedItem);

                FichaJogador personagem = new FichaJogador(NomePersonagem, VidaMaximaPersonagem, ClasseArmaduraPersonagem, EspacoMagias, ClassePersonagem, Nivel);
                personagem.CadastraFicha();
            }
            if (cboTipodeFicha.SelectedIndex == 1)
            {
                string NomeInimigo = tBNomePersonagem.Text;
                uint VidaMaximaInimigo = (uint)nUDVidaMaxima.Value;
                uint ClasseArmaduraInimigo = (uint)nUDClasseArmadura.Value;
                uint[] EspacoMagias = new uint[9]
                {
                (uint)nUD1.Value,
                (uint)nUD2.Value,
                (uint)nUD3.Value,
                (uint)nUD4.Value,
                (uint)nUD5.Value,
                (uint)nUD6.Value,
                (uint)nUD7.Value,
                (uint)nUD8.Value,
                (uint)nUD9.Value
                };
                FichaInimigo.Classe ClasseInimigo = (FichaInimigo.Classe)cboClasse.SelectedItem;
                uint CR = Convert.ToUInt32(cboNivel.SelectedItem);

                FichaInimigo inimigo = new FichaInimigo(NomeInimigo, VidaMaximaInimigo, ClasseArmaduraInimigo, EspacoMagias, ClasseInimigo, CR);
                inimigo.CadastraFicha();
            }
            if (cboTipodeFicha.SelectedIndex == 2)
            {
                string NomeInvocacao = tBNomePersonagem.Text;
                uint VidaMaximaInvocacao = (uint)nUDVidaMaxima.Value;
                uint ClasseArmaduraInvicacao = (uint)nUDClasseArmadura.Value;
                uint QuantidadeInvocacoes = (uint)nUDQuantidadeInvocacoes.Value;

                FichaInvocacao inivocaco = new FichaInvocacao(NomeInvocacao, VidaMaximaInvocacao, ClasseArmaduraInvicacao, QuantidadeInvocacoes);
                inivocaco.CadastraFicha();
            }
        }        
        private void LimpaForm()
        {            
            tBNomePersonagem.Clear();
            nUDVidaMaxima.Value = 0;
            nUDClasseArmadura.Value = 0;
            nUDQuantidadeInvocacoes.Value = 0;
            foreach (var nUP in numericUpDownsEM)
            {
                nUP.Value = 0;
            }
            cboClasse.SelectedIndex = -1;
            cboNivel.SelectedIndex = -1;
            ckbSpellSlot.Checked = false;
        }
        #endregion

        #region Eventos Auxiliares 
        private void NumericUpDown_Enter(object sender, EventArgs e)
        {
            NumericUpDown numUpDown = sender as NumericUpDown;
            numUpDown.Select(0, numUpDown.Text.Length); // Seleciona o valor inteiro
        }
        private void NumericUpDown_MouseClick(object sender, MouseEventArgs e)
        {
            NumericUpDown numUpDown = sender as NumericUpDown;
            numUpDown.Select(0, numUpDown.Text.Length); // Seleciona o valor inteiro
        }
        #endregion
    }
}