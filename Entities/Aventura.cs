using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestre_de_Rpg.Entities
{
    public class Aventura
    {
        public string Nome { get; set; }
        
        public int ID { get; set; }

        public ICollection<FichaJogador> Jogadores { get; set; } = null!;



        public void RegistraAventura()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                string message = ex.ToString();
            }
        }
    }  
}
