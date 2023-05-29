using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Escola.DB
{
    static class ConexaoDB
    {
        private static string servidor;
        private static string nomeBanco;
        private static int port;
        private static string usuario;
        private static string senha;

        static ConexaoDB()
        {
            servidor = "localhost";
            nomeBanco = "escolla";
            usuario = "root";
            senha = "";
        }

        public static string strConn = $"Data Source={servidor};Initial Catalog={nomeBanco};User ID={usuario};Password={senha};";
        public static MySqlConnection GetConexao()
        {
            string strConexao = $"server={servidor};uid={usuario};database={nomeBanco};";
                
            MySqlConnection conexao = new MySqlConnection(strConexao);
            conexao.Open();

            return conexao;
        }

    }
}
