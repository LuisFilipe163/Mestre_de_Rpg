﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestre_de_Rpg.Entities
{
    internal class FichaInimigo : Ficha
    {
        public enum Classe
        {
            Bárbaro,
            Bardo,
            Bruxo,
            Clérigo,
            Druida,
            Feiticeiro,
            Guerreiro,
            Ladino,
            Mago,
            Monge,
            Paladino,
            Patrulheiro
        }

        #region Variáveis        
        private uint[] espacoMagias = [0, 0, 0, 0, 0, 0, 0, 0, 0];
        public Classe classePersonagem;
        public uint cr;
        #endregion

        #region Propriedades
        public uint[] EspacoMagias { get; set; }
        public Classe ClassePersonagem { get; set; }
        public uint CR { get; set; }
        #endregion

        #region Construtor
        public FichaInimigo(string nomePersonagem, uint vidaMaximaPersonagem, uint classeArmadura, uint[] espacoMagias, Classe classePersonagem, uint cr) : base(nomePersonagem, vidaMaximaPersonagem, classeArmadura)
        {
            this.espacoMagias = espacoMagias;
            this.classePersonagem = classePersonagem;
            this.cr = cr;
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Registra um Inimigo
        /// </summary>
        public override void CadastraFicha()
        {
            try
            {
                FichaInimigo Inimigo = new FichaInimigo(this.NomePersonagem, this.VidaMaximaPersonagem, this.ClasseArmadura, this.EspacoMagias, this.ClassePersonagem, this.CR);

                string pastaDados = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
                
                Directory.CreateDirectory(pastaDados);

                string caminhoArquivo = Path.Combine(pastaDados, "Inimigo.json");

                string json = JsonConvert.SerializeObject(Inimigo, Formatting.Indented);

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
