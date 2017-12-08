using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class Conexao
    {
        internal static SqlConnection conexao = null;

        public static void Abrir()
        {
            conexao = new SqlConnection();
            conexao.ConnectionString = ConfigurationManager.ConnectionStrings["conecta"].ConnectionString;

            conexao.Open();
        }

        public static void Fechar()
        {
            if(conexao != null)
                conexao.Close();
        }
    }
}
