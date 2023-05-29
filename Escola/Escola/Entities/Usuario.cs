using Escola.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Entities
{
    internal class Usuario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Tipo { get; set; }
        public Usuario() { }
        
        public int InsertUser()
        {

                using (var cn = ConexaoDB.GetConexao())
                {
                    using var cmd = new MySqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "INSERT INTO Usuarios (nome, email, senha, tipo) VALUES (@nome, @email, @senha, @tipo)";
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@senha", Senha);
                    cmd.Parameters.AddWithValue("@tipo", Tipo);
                    int linhasAfetadas = cmd.ExecuteNonQuery();
                    string selectQuery = "SELECT LAST_INSERT_ID()";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, cn);
                    int lastInsertedId = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return lastInsertedId;
                }
        }


        public Usuario GetUserByEmailAndPassword(string email, string password)
        {
            Usuario user = null;

            try
            {
                using (var cn = ConexaoDB.GetConexao())
                {
                    using var cmd = new MySqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandText = "SELECT * FROM Usuarios WHERE senha = @password and email = @email";
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new Usuario
                            {
                                Id = reader.GetInt32(0),
                                Email= reader.GetString(1),
                                Senha= reader.GetString(2),
                                Tipo = reader.GetString(4)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            return user;
        }
    }
}
