using Escola.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Entities
{
    internal class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }


        public void SalvarAluno()
        {
            try
            {
                using (var cn = ConexaoDB.GetConexao())
                {
                    using var cmd = new MySqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "INSERT INTO Alunos (nome, dataNascimento, email) VALUES (@nome, @dataNascimento, @email)";
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@dataNascimento", DataNascimento);
                    cmd.Parameters.AddWithValue("@email", Email);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Aluno salvo com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar aluno: " + ex.Message);
            }
        }
    }
}
