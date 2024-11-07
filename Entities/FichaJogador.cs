using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Mestre_de_Rpg.DB;

namespace Mestre_de_Rpg.Entities
{
    public class FichaJogador : Ficha
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
        public uint nivel;
        private uint idaventura;
        #endregion

        #region Propriedades        
        public uint[] EspacoMagias
        {
            get { return espacoMagias; }
            set { espacoMagias = value; }
        }
        public Classe ClassePersonagem { get; set; }
        public uint Nivel { get; set; }

        public uint IDAventura { get; set; }
        #endregion

        #region Construtor
        public FichaJogador(string nomePersonagem, uint vidaMaximaPersonagem, uint classeArmadura, uint[] espacoMagias, Classe classePersonagem, uint nivel) : base(nomePersonagem, vidaMaximaPersonagem, classeArmadura)
        {
            this.espacoMagias = espacoMagias;
            this.classePersonagem = classePersonagem;
            this.nivel = nivel;
        }
        public FichaJogador(string nomePersonagem, uint vidaMaximaPersonagem, uint classeArmadura, uint[] espacoMagias, Classe classePersonagem, uint nivel, uint idAventura) : base(nomePersonagem, vidaMaximaPersonagem, classeArmadura)
        {
            this.espacoMagias = espacoMagias;
            this.classePersonagem = classePersonagem;
            this.nivel = nivel;
            this.idaventura = idAventura;
        }
        #endregion

        #region Métodos

        
        /// <summary>
        /// Registra um Jogador
        /// </summary>
        public override void CadastraFicha()
        {
            try
            {
                DALFichaJogador.RegistraJogador(this);
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
