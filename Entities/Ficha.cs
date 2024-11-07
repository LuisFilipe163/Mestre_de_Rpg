using Mestre_de_Rpg.Contracts;

namespace Mestre_de_Rpg.Entities
{
    public abstract class Ficha 
    {
        #region Variaveis
        private string nomePersonagem;
        private uint vidaMaximaPersonagem;
        private uint classeArmadura;
        public bool cadastroConcluido = false;
        enum EnumCondicao
        {
            Amedrontado = 0,
            Atordoado,
            Caido,
            Cego,
            Contido,
            Enfeitiçado,
            Envenenado,
            Exausto,
            Incapacitado,
            Inconsciente,
            Invisível,
            Paralisado,
            Petrificado,
            Preso,
            Surdo
        }
        #endregion

        #region Propriedades
        public string NomePersonagem
        {
            get { return nomePersonagem; }
            set { nomePersonagem = value; }
        }
        public uint VidaMaximaPersonagem
        {
            get { return vidaMaximaPersonagem; }
            set { vidaMaximaPersonagem = value; }
        }
        public uint ClasseArmadura
        {
            get { return classeArmadura; }
            set { classeArmadura = value; }
        }
        #endregion

        #region Construtor
        public Ficha(string nomePersonagem, uint vidaMaximaPersonagem, uint classeArmadura)
        {
            this.nomePersonagem = nomePersonagem;
            this.vidaMaximaPersonagem = vidaMaximaPersonagem;
            this.classeArmadura = classeArmadura;
        }
        #endregion

        public abstract void CadastraFicha();

        public abstract void EditaFicha();

        public abstract void ExcluiFicha();
    }
}
