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
    public class DCurso
    {
        public static void Inserir(MCurso item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "INSERT INTO TBCurso values(@NOME, @CH, @IDTipoCurso)";

            SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar);
            param.Value = item.Nome;
            comando.Parameters.Add(param);
            SqlParameter param1 = new SqlParameter("@CH", SqlDbType.Int);
            param1.Value = item.CHMaxima;
            comando.Parameters.Add(param1);
            SqlParameter param2 = new SqlParameter("@IDTipoCurso", SqlDbType.Int);
            param2.Value = item.FKTipoCurso.Id;
            comando.Parameters.Add(param2);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }

        public static List<MCurso> Pesquisar(MCurso item)
        {
            List<MCurso> retorno = new List<MCurso>();

            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "SELECT c.ID ID, c.NOME Nome, c.CHMaxima CHMaxima, c.FkTipoCursoID FkTipoCursoID, t.NOME NomeTC FROM TBCurso c inner join TBTipoCurso t on FKTipoCursoID = t.ID WHERE c.Nome LIKE @NOME ORDER BY c.Nome ASC";

            SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar);
            param.Value = "%" + item.Nome + "%";
            comando.Parameters.Add(param);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                MCurso ret = new MCurso();
                ret.FKTipoCurso = new MTipoCurso();
                ret.Id = (int)reader["ID"];
                ret.Nome = reader["Nome"].ToString();
                ret.CHMaxima = (int)reader["CHMaxima"];
                ret.FKTipoCurso.Id = (int)reader["FkTipoCursoID"];
                ret.FKTipoCurso.Nome = reader["NomeTC"].ToString();

                retorno.Add(ret);
            }

            reader.Close();

            Conexao.Fechar();

            return retorno;
        }

        public static void Atualizar(MCurso item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "UPDATE TBCurso set NOME = @NOME, CHMaxima = @CHMaxima, FKTipoCursoID = @FKTipoCursoID where ID = @ID";

            SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar);
            param.Value = item.Nome;
            comando.Parameters.Add(param);
            SqlParameter param1 = new SqlParameter("@ID", SqlDbType.Int);
            param1.Value = item.Id;
            comando.Parameters.Add(param1);
            SqlParameter param2 = new SqlParameter("@CHMaxima", SqlDbType.Int);
            param2.Value = item.CHMaxima;
            comando.Parameters.Add(param2);
            SqlParameter param3 = new SqlParameter("@FKTipoCursoID", SqlDbType.Int);
            param3.Value = item.FKTipoCurso;
            comando.Parameters.Add(param3);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }

        public static MCurso Obter(MCurso item)
        {
            MCurso retorno = null;

            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "SELECT c.ID ID, c.NOME Nome, c.CHMaxima CHMaxima, c.FkTipoCursoID FkTipoCursoID, t.NOME NomeTC FROM TBCurso c inner join TBTipoCurso t on FKTipoCursoID = t.ID WHERE ID = @ID";

            SqlParameter param = new SqlParameter("@ID", SqlDbType.Int);
            param.Value = item.Id;
            comando.Parameters.Add(param);

            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                retorno = new MCurso();
                retorno.FKTipoCurso = new MTipoCurso();
                retorno.Id = (int)reader["ID"];
                retorno.Nome = reader["Nome"].ToString();
                retorno.CHMaxima = (int)reader["CHMaxima"];
                retorno.FKTipoCurso.Id = (int)reader["FkTipoCursoID"];
                retorno.FKTipoCurso.Nome = reader["NomeTC"].ToString();  
            }

            reader.Close();

            Conexao.Fechar();

            return retorno;
        }

        public static void Remover(MCurso item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "DELETE FROM TBCurso where ID = @ID";

            SqlParameter param = new SqlParameter("@ID", SqlDbType.Int);
            param.Value = item.Id;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }
    }
}
