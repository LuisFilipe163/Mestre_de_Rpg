using Mestre_de_Rpg.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestre_de_Rpg.DB
{
    public static class DALFichaJogador
    {
        public static void RegistraJogador(FichaJogador jogador)
        {
            try
            {
                using var cmd = BancoDados.DBConnection().CreateCommand();
                string espacosMagias = string.Join(",", jogador.EspacoMagias);
                cmd.CommandText = "INSERT INTO FichaJogador(nomePersonagem, vida_max, classe_armadura, espacos_de_magias, classe_personagem, nivel) values (@nomePersonagem, @vida_max, @classe_armadura, @espacos_de_magias, @classe_personagem, @nivel)";
                cmd.Parameters.AddWithValue("@nomePersonagem", jogador.NomePersonagem);
                cmd.Parameters.AddWithValue("@vida_max", jogador.VidaMaximaPersonagem);
                cmd.Parameters.AddWithValue("@classe_armadura", jogador.ClasseArmadura);
                cmd.Parameters.AddWithValue("@espacos_de_magias", espacosMagias);
                cmd.Parameters.AddWithValue("@classe_personagem", jogador.ClassePersonagem);
                cmd.Parameters.AddWithValue("@nivel", jogador.Nivel);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static DataTable CarregaJogadores()
        {
            SQLiteDataAdapter? da = null;
            DataTable dt = new DataTable();
            try
            {
                using var cmd = BancoDados.DBConnection().CreateCommand();
                {
                    cmd.CommandText = "SELECT * FROM FichaJogador";
                    da = new SQLiteDataAdapter(cmd.CommandText, BancoDados.DBConnection());
                    da.Fill(dt);
                    return dt;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int GetIdJogadorPorNome(string nomeJogador)
        {
            try
            {
                using var cmd = BancoDados.DBConnection().CreateCommand();
                {
                    cmd.CommandText = @"SELECT id_jogador FROM FichaJogador WHERE nome = @nome";
                    cmd.Parameters.AddWithValue("@nome", nomeJogador);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar o id de Jogador: " + ex.Message);
                return -1;
            }
        }
    }
}
