using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesa_do_Mestre.Classes
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
        #endregion

        #region Propriedades        
        public uint[] EspacoMagias
        {
            get { return espacoMagias; }
            set { espacoMagias = value; }
        }
        public Classe ClassePersonagem
        {
            get { return classePersonagem; }
            set { classePersonagem = value; }
        }
        public uint Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        #endregion

        #region Construtor
        public FichaJogador(string nomePersonagem, uint vidaMaximaPersonagem, uint classeArmadura, uint[] espacoMagias, Classe classePersonagem, uint nivel) : base(nomePersonagem, vidaMaximaPersonagem, classeArmadura)
        {
            this.espacoMagias = espacoMagias;
            this.classePersonagem = classePersonagem;
            this.nivel = nivel;
        }
        #endregion

        #region Métodos
        public override void CadastroFicha()
        {
            try
            {
                FichaJogador Jogador = new FichaJogador(this.NomePersonagem, this.VidaMaximaPersonagem, this.ClasseArmadura, this.EspacoMagias, this.ClassePersonagem, this.Nivel);

                string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Personagem.json");

                string json = JsonConvert.SerializeObject(Jogador, Formatting.Indented);

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
