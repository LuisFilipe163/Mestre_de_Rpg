using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesa_do_Mestre.Classes
{
    public class FichaInvocacao : Ficha
    {
        #region Váriaveis
        private uint quantidadeInvocacoes;
        #endregion

        #region Propriedades
        public uint QuantidadeInvocacoes
        {
            get { return quantidadeInvocacoes; }
            set
            {
                if (QuantidadeInvocacoes > 0)
                {
                    quantidadeInvocacoes = value;
                }
            }
        }
        #endregion

        #region Construtor
        public FichaInvocacao(string nomePersonagem, uint vidaMaximaPersonagem, uint classeArmadura, uint quantidadeInvocacoes) : base(nomePersonagem, vidaMaximaPersonagem, classeArmadura)
        {
            this.quantidadeInvocacoes = quantidadeInvocacoes;
        }
        #endregion

        #region Métodos
        public override void CadastroFicha()
        {
            try
            {
                FichaInvocacao Invocacao = new FichaInvocacao(this.NomePersonagem, this.VidaMaximaPersonagem, this.ClasseArmadura, this.QuantidadeInvocacoes);

                string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Invocação.json");

                string json = JsonConvert.SerializeObject(Invocacao, Formatting.Indented);

                File.WriteAllText(caminhoArquivo, json);

                cadastroConcluido = true;
            }
            catch (Exception ex)
            {
                string message = ex.ToString();
            }
        }
        #endregion
    }
}
