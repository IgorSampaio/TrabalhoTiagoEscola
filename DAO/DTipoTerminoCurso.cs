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
    public class DTipoTerminoCurso
    {
        public static void Inserir(MTipoTerminoCurso item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "INSERT INTO TBTipoTerminoCurso values(@NOME)";

            SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar);
            param.Value = item.Nome;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }

        public static List<MTipoTerminoCurso> Pesquisar(MTipoTerminoCurso item)
        {
            List<MTipoTerminoCurso> retorno = new List<MTipoTerminoCurso>();

            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "SELECT ID, NOME FROM TBTipoTerminoCurso WHERE NOME LIKE @NOME ORDER BY NOME ASC";

            SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar);
            param.Value = "%" + item.Nome + "%";
            comando.Parameters.Add(param);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                MTipoTerminoCurso ret = new MTipoTerminoCurso();
                ret.Id = (int)reader["ID"];
                ret.Nome = reader["NOME"].ToString();

                retorno.Add(ret);
            }

            reader.Close();

            Conexao.Fechar();

            return retorno;
        }

        public static void Atualizar(MTipoTerminoCurso item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "UPDATE TBTipoTerminoCurso set NOME = @NOME where ID = @ID";

            SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar);
            param.Value = item.Nome;
            comando.Parameters.Add(param);

            param = new SqlParameter("@ID", SqlDbType.Int);
            param.Value = item.Id;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }

        public static MTipoTerminoCurso Obter(MTipoTerminoCurso item)
        {
            MTipoTerminoCurso retorno = null;

            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "SELECT ID, NOME FROM TBTipoTerminoCurso WHERE ID = @ID";

            SqlParameter param = new SqlParameter("@ID", SqlDbType.Int);
            param.Value = item.Id;
            comando.Parameters.Add(param);

            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                retorno = new MTipoTerminoCurso();
                retorno.Id = (int)reader["ID"];
                retorno.Nome = reader["NOME"].ToString();
            }

            reader.Close();

            Conexao.Fechar();

            return retorno;
        }

        public static void Remover(MTipoTerminoCurso item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "DELETE FROM TBTipoTerminoCurso where ID = @ID";

            SqlParameter param = new SqlParameter("@ID", SqlDbType.Int);
            param.Value = item.Id;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }
    }
}
