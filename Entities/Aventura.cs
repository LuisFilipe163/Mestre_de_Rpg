using Mestre_de_Rpg.DB;
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
        private string nome;
        private int id;

        public string Nome 
        { 
            get { return nome; }
            set { nome = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Aventura(string Nome) 
        {
            this.nome = Nome;
        }


        public void RegistraAventura()
        {
            try
            {
                DALAventura.RegistraAventura(this);
            }
            catch (Exception ex)
            {
                string message = ex.ToString();
            }
        }
    }  
}
