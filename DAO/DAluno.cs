using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAO
{
    public class DAluno
    {
        public static void Inserir(MAluno item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "INSERT INTO TBAluno values(@CPF, @NOME, @NASCIMENTO)";

            SqlParameter param = new SqlParameter("@CPF", SqlDbType.Char);
            param.Value = item.CPF;
            comando.Parameters.Add(param);
            param = new SqlParameter("@NOME", SqlDbType.VarChar);
            param.Value = item.Nome;
            comando.Parameters.Add(param);
            param = new SqlParameter("@NASCIMENTO", SqlDbType.Date);
            param.Value = item.Nascimento;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }

        public static List<MAluno> Pesquisar(MAluno item)
        {
            List<MAluno> retorno = new List<MAluno>();

            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "SELECT * FROM TBAluno WHERE NOME LIKE @NOME ORDER BY NOME ASC";

            SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar);
            param.Value = "%" + item.Nome + "%";
            comando.Parameters.Add(param);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                MAluno ret = new MAluno();
                ret.CPF = reader["CPF"].ToString();
                ret.Nome = reader["NOME"].ToString();
                ret.Nascimento = (DateTime)reader["NASCIMENTO"];

                retorno.Add(ret);
            }

            reader.Close();

            Conexao.Fechar();

            return retorno;
        }

        public static void Atualizar(MAluno item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "UPDATE TBAluno set NOME = @NOME where CPF = @CPF";

            SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar);
            param.Value = item.Nome;
            comando.Parameters.Add(param);

            param = new SqlParameter("@CPF", SqlDbType.Char);
            param.Value = item.CPF;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }

        public static MAluno Obter(MAluno item)
        {
            MAluno retorno = null;

            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "SELECT * FROM TBAluno WHERE CPF = @CPF";

            SqlParameter param = new SqlParameter("@CPF", SqlDbType.Char);
            param.Value = item.CPF;
            comando.Parameters.Add(param);

            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                retorno = new MAluno();
                retorno.CPF = reader["CPF"].ToString();
                retorno.Nome = reader["NOME"].ToString();
                retorno.Nascimento = (DateTime)reader["NASCIMENTO"];
            }

            reader.Close();

            Conexao.Fechar();

            return retorno;
        }

        public static void Remover(MAluno item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "DELETE FROM TBAluno where CPF = @CPF";

            SqlParameter param = new SqlParameter("@CPF", SqlDbType.Char);
            param.Value = item.CPF;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }
    }
}
