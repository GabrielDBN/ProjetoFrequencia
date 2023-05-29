using Escola.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Entities
{
    internal class Horario
    {
        public int Id { get; set; }
        public string Dia_semana { get; set; }
        public string Time { get; set; }
        public int Disciplina_id { get; set; }
        public int Turma_id { get; set; }

        public void Insert()
        {
            
            using (var cn = ConexaoDB.GetConexao())
            {
                using var cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO Horarios (dia_semana, horario, disciplina_id, turma_id) VALUES (@dia_semana, @horario, @disciplina_id, @turma_id)";
                cmd.Parameters.AddWithValue("@dia_semana", Dia_semana);
                cmd.Parameters.AddWithValue("@horario", Time);
                cmd.Parameters.AddWithValue("@disciplina_id", Disciplina_id);
                cmd.Parameters.AddWithValue("@turma_id", Turma_id);
                int linhasAfetadas = cmd.ExecuteNonQuery();
                string selectQuery = "SELECT LAST_INSERT_ID()";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, cn);
                int lastInsertedId = Convert.ToInt32(selectCommand.ExecuteScalar());
            }
        } 
    }
}
