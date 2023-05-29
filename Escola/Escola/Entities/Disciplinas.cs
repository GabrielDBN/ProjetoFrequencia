using Escola.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Entities
{
    internal class Disciplinas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Professor_id { get; set; }
        public string Tipo_disciplina { get; set; }


        public int Insert()
        {

            using (var cn = ConexaoDB.GetConexao())
            {
                using var cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO Disciplinas (nome, professor_id, tipo_disciplina) VALUES (@nome, @professor_id, @tipo_disciplina)";
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@professor_id", Professor_id);
                cmd.Parameters.AddWithValue("@tipo_disciplina", Tipo_disciplina);
                int linhasAfetadas = cmd.ExecuteNonQuery();
                string selectQuery = "SELECT LAST_INSERT_ID()";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, cn);
                int lastInsertedId = Convert.ToInt32(selectCommand.ExecuteScalar());
                return lastInsertedId;
            }
        }
    }
}
