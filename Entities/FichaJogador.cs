using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace Mestre_de_Rpg.Entities
{
    public class FichaJogador : Ficha
    {
        public enum Classes
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

        #region Propriedades    

        [Key]
        public int ID { get; set; }

        public uint[] EspacoMagias {  get; set; } = new uint[9];

        public Classes ClassePersonagem { get; set; }

        public uint Nivel { get; set; } = 1;

        public uint IDAventura { get; set; }

        public Aventura? Aventura { get; set; }
        #endregion

        #region Construtor
        public FichaJogador(string nomePersonagem, uint vidaMaximaPersonagem, uint classeArmadura, uint[] espacoMagias, Classes classePersonagem, uint nivel, uint idAventura) : base(nomePersonagem, vidaMaximaPersonagem, classeArmadura)
        {
            this.IDAventura = idAventura;
            this.EspacoMagias = espacoMagias;
            this.ClassePersonagem = classePersonagem;
            this.Nivel = nivel;
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
