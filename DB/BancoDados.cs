using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestre_de_Rpg.DB
{
    public static class BancoDados
    {
        public static string path = Directory.GetCurrentDirectory() + "\\Data\\data.sqlite";
        private static SQLiteConnection? _connection;

        public static void InicializarBanco()
        {
            CriarBancoSQLite();
            CriarTabelas();
        }

        public static SQLiteConnection DBConnection()
        {
            if (_connection == null)
            {
                _connection = new SQLiteConnection("Data Source=" + path);
                _connection.Open();
            }
            else if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
            return _connection;
        }

        public static void CriarBancoSQLite()
        {
            try
            {
                if (!File.Exists(path))
                {
                    SQLiteConnection.CreateFile(path);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao criar o banco de dados: " + ex.Message);
                throw;
            }
        }

        private static void CriarTabelas()
        {
            using var cmd = DBConnection().CreateCommand();
            // Tabela Aventura
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Aventura (
                                    id_aventura INTEGER PRIMARY KEY, 
                                    nome TEXT NOT NULL);";
            cmd.ExecuteNonQuery();

            // Tabela FichaJogador
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS FichaJogador (
                                    id_jogador INTEGER PRIMARY KEY, 
                                    nomePersonagem TEXT NOT NULL, 
                                    vida_max INTEGER NOT NULL, 
                                    classe_armadura INTEGER NOT NULL, 
                                    espacos_de_magias TEXT, 
                                    classe_personagem TEXT NOT NULL, 
                                    nivel INTEGER NOT NULL,
                                    id_aventura INTEGER,
                                    FOREIGN KEY (id_aventura) REFERENCES Aventura(id_aventura) ON DELETE CASCADE);";
            cmd.ExecuteNonQuery();
        }

        public static void ExcluirTabelas()
        {
            using var cmd = DBConnection().CreateCommand();
            // Tabela Aventura
            cmd.CommandText = @"DELETE FROM Aventura;";
            cmd.ExecuteNonQuery();

            // Tabela FichaJogador
            cmd.CommandText = @"DELETE FROM FichaJogador;";
            cmd.ExecuteNonQuery();
        }
    }
}
