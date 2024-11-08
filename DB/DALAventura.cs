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
    internal class DALAventura
    {
        public static void RegistraAventura(Aventura aventura)
        {
            try
            {
                using var cmd = BancoDados.DBConnection().CreateCommand();
                cmd.CommandText = "INSERT INTO Aventura(nome) values (@nome)";
                cmd.Parameters.AddWithValue("@nome", aventura.Nome);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static DataTable CarregaAventuras()
        {
            SQLiteDataAdapter? da = null;
            DataTable dt = new DataTable();
            try
            {
                using var cmd = BancoDados.DBConnection().CreateCommand();
                {
                    cmd.CommandText = "SELECT * FROM Aventura";
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

        public static int GetIdAventuraPorNome(string nomeAventura)
        {
            try
            {
                using var cmd = BancoDados.DBConnection().CreateCommand();
                {
                    cmd.CommandText = @"SELECT id_aventura FROM Aventura WHERE nome = @nome";
                    cmd.Parameters.AddWithValue("@nome", nomeAventura);
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
                MessageBox.Show("Erro ao buscar o id da aventura: " + ex.Message);
                return -1;
            }
        }

        public static void ExcluiAventura(int idAventura)
        {
            try
            {
                using var cmd = BancoDados.DBConnection().CreateCommand();
                {
                    // Prepara o comando SQL para excluir a aventura pelo id_aventura
                    cmd.CommandText = @"DELETE FROM Aventura WHERE id_aventura = @id";
                    cmd.Parameters.AddWithValue("@id", idAventura);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir a aventura: " + ex.Message);
            }
        }
    }
}
