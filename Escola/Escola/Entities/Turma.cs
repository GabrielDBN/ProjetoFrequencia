using Escola.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Entities
{
    internal class Turma
    {
        public int Id { get; set; }  
        public string Nome { get; set; }
        public string Semestre { get; set; }

        public void Insert()
        {

            using (var cn = ConexaoDB.GetConexao())
            {
                using var cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO Turmas (nome, semestre) VALUES (@nome, @semestre)";
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@semestre", Semestre);
                int linhasAfetadas = cmd.ExecuteNonQuery();
                string selectQuery = "SELECT LAST_INSERT_ID()";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, cn);
                int lastInsertedId = Convert.ToInt32(selectCommand.ExecuteScalar());
                MessageBox.Show("Turma criada");
            }
        }

        public List<Turma> ListAll()
        {
            List<Turma> list = new List<Turma>();
            using (var cn = ConexaoDB.GetConexao())
            {
                using var cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT * FROM Turmas";
                
                using (var reader = cmd.ExecuteReader()) { 
                   while (reader.Read())
                    {
                        var turma = new Turma
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Semestre = reader.GetString(2)
                        };
                        list.Add(turma);
                    }
                }
            }
            return list;
        }
    }
}
