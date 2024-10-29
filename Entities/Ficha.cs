using Mesa_do_Mestre.Classes.Contracts;

namespace Mesa_do_Mestre.Classes
{
    public abstract class Ficha : IFicha
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

        public abstract void CadastroFicha();
    }
}
