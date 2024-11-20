using Mestre_de_Rpg.Contracts;

namespace Mestre_de_Rpg.Entities
{
    public abstract class Ficha 
    {
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

        #region Propriedades
        public string NomePersonagem { get; set; } = string.Empty;

        public uint VidaMaximaPersonagem { get; set; } = 0;

        public uint ClasseArmadura { get; set; } = 0;
        
        #endregion

        #region Construtor
        public Ficha(string nomePersonagem, uint vidaMaximaPersonagem, uint classeArmadura)
        {
            this.NomePersonagem = nomePersonagem;
            this.VidaMaximaPersonagem = vidaMaximaPersonagem;
            this.ClasseArmadura = classeArmadura;
        }
        #endregion

        public abstract void CadastraFicha();

        public abstract void EditaFicha();

        public abstract void ExcluiFicha();
    }
}
