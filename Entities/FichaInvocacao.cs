﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestre_de_Rpg.Entities
{
    internal class FichaInvocacao : Ficha
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

        /// <summary>
        /// Registra uma Invocação
        /// </summary>
        public override void CadastraFicha()
        {
            try
            {
                FichaInvocacao Invocacao = new FichaInvocacao(this.NomePersonagem, this.VidaMaximaPersonagem, this.ClasseArmadura, this.QuantidadeInvocacoes);

                string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Invocação.json");

                string json = JsonConvert.SerializeObject(Invocacao, Formatting.Indented);

                File.WriteAllText(caminhoArquivo, json);
            }
            catch (Exception ex)
            {
                string message = ex.ToString();
            }
        }

        public override void EditaFicha()
        {

        }

        public override void ExcluiFicha()
        {

        }
        #endregion
    }
}
