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
    public class DTipoCurso
    {
        public static void Inserir(MTipoCurso item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "INSERT INTO TBTipoCurso values(@NOME)";

            SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar);
            param.Value = item.Nome;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }

        public static List<MTipoCurso> Pesquisar(MTipoCurso item)
        {
            List<MTipoCurso> retorno = new List<MTipoCurso>();

            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "SELECT ID, NOME FROM TBTipoCurso WHERE NOME LIKE @NOME ORDER BY NOME ASC";

            SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar);
            param.Value = "%" + item.Nome + "%";
            comando.Parameters.Add(param);

            SqlDataReader reader = comando.ExecuteReader();

            while(reader.Read())
            {
                MTipoCurso ret = new MTipoCurso();
                ret.Id = (int)reader["ID"];
                ret.Nome = reader["NOME"].ToString();

                retorno.Add(ret);
            }

            reader.Close();

            Conexao.Fechar();

            return retorno;
        }

        public static void Atualizar(MTipoCurso item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "UPDATE TBTipoCurso set NOME = @NOME where ID = @ID";

            SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar);
            param.Value = item.Nome;
            comando.Parameters.Add(param);

            param = new SqlParameter("@ID", SqlDbType.Int);
            param.Value = item.Id;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }

        public static MTipoCurso Obter(MTipoCurso item)
        {
            MTipoCurso retorno = null;

            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "SELECT ID, NOME FROM TBTipoCurso WHERE ID = @ID";

            SqlParameter param = new SqlParameter("@ID", SqlDbType.Int);
            param.Value = item.Id;
            comando.Parameters.Add(param);

            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                retorno = new MTipoCurso();
                retorno.Id = (int)reader["ID"];
                retorno.Nome = reader["NOME"].ToString();
            }

            reader.Close();

            Conexao.Fechar();

            return retorno;
        }

        public static void Remover(MTipoCurso item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "DELETE FROM TBTipoCurso where ID = @ID";

            SqlParameter param = new SqlParameter("@ID", SqlDbType.Int);
            param.Value = item.Id;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }
    }
}
