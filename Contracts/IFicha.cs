namespace Mestre_de_Rpg.Contracts
{
    internal interface IFicha
    {
        public string NomePersonagem { get; set; }
        public uint VidaMaximaPersonagem { get; set; }
        public uint ClasseArmadura { get; set; }
        public void CadastraFicha();
        public void EditaFicha();
        public void ExcluiFicha();
    }
}
