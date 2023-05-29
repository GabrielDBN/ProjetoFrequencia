using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.DB
{
    internal class DB
    {
        private string servidor;
        private string nomeBanco;
        private string usuario;
        private string senha;

        public DB(string servidor, string nomeBanco, string usuario, string senha)
        {
            this.servidor = servidor;
            this.nomeBanco = nomeBanco;
            this.usuario = usuario;
            this.senha = senha;
        }
        public MySqlConnection GetConexao()
        {
            string strConexao = $"Data Source={servidor};Initial Catalog={nomeBanco};User ID={usuario};Password={senha};";
            MySqlConnection conexao = new MySqlConnection(strConexao);
            conexao.Open();

            return conexao;
        }
    }
}
