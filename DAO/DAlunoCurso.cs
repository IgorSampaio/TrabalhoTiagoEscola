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
    public class DAlunoCurso
    {
        public static void Inserir(MAlunoCurso item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "INSERT INTO TBAluno VALUES (@FKAlunoCPF, @FKCursoID, @Inicio, @Termino, @Prontuario, @FKTipoTerminoCursoID)";

            SqlParameter param = new SqlParameter("@FKAlunoCPF", System.Data.SqlDbType.Char);
            param.Value = item.FKAlunoCPF;
            comando.Parameters.Add(param);
            param = new SqlParameter("@FKCursoID", System.Data.SqlDbType.Int);
            param.Value = item.FKCursoID;
            comando.Parameters.Add(param);
            param = new SqlParameter("@FKTipoTerminoCursoID", System.Data.SqlDbType.Int);
            param.Value = item.FKTipoTerminoCursoID;
            comando.Parameters.Add(param);
            param = new SqlParameter("@Inicio", System.Data.SqlDbType.Date);
            param.Value = item.Inicio;
            comando.Parameters.Add(param);
            param = new SqlParameter("@Termino", System.Data.SqlDbType.Date);
            param.Value = item.Termino;
            comando.Parameters.Add(param);
            param = new SqlParameter("@Prontuario", System.Data.SqlDbType.Char);
            param.Value = item.Prontuario;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }

        public static List<MAlunoCurso> Pesquisar(MAlunoCurso item)
        {
            List<MAlunoCurso> retorno = new List<MAlunoCurso>();

            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;

            comando.CommandText = "SELECT ac.FKAlunoCPF CPF, ac.FKCursoID IDCurso, ac.FKTipoTerminoCursoID IDTipoTermino, ac.Inicio Inicio, ac.Prontuario Prontuario, ac.Termino Termino, a.Nascimento Nascimento, a.Nome AlunoNome, c.CHMaxima CHMaxima, c.FKTipoCursoID IDTipoCurso, c.Nome NomeCurso, t.Nome NomeTipoTermino FROM TBAlunoCurso ac INNER JOIN TBCurso c ON (c.ID = ac.FKCursoID) INNER JOIN TBAluno a  ON (ac.FKAlunoCPF= a.CPF) INNER JOIN TBTipoTerminoCurso t ON (t.ID = ac.FKTipoTerminoCursoID) WHERE Prontuario = @Prontuario";

            SqlParameter param = new SqlParameter("@Prontuario", SqlDbType.Char);
            param.Value = item.Prontuario;
            comando.Parameters.Add(param);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                MAlunoCurso ret = new MAlunoCurso();
                ret.FKCursoID = new MCurso();
                ret.FKCursoID.Id = (int)reader["IDCurso"];
                ret.FKCursoID.CHMaxima = (int)reader["CHMaxima"];
                ret.FKCursoID.Nome = reader["NomeCurso"].ToString();
                //ret.FKCursoID.FKTipoCurso = new MTipoCurso();
                //ret.FKCursoID.FKTipoCurso.Id = (int)reader["FkTipoCursoID"];
                //ret.FKCursoID.FKTipoCurso.Nome = reader["NomeTC"].ToString();
                ret.FKAlunoCPF = new MAluno();
                ret.FKAlunoCPF.CPF = reader["CPF"].ToString();
                ret.FKAlunoCPF.Nascimento = (DateTime)reader["Nascimento"];
                ret.FKAlunoCPF.Nome = reader["NomeAluno"].ToString();
                ret.FKTipoTerminoCursoID = new MTipoTerminoCurso();
                ret.FKTipoTerminoCursoID.Id = (int)reader["IDTipoTermino"];
                ret.Inicio = (DateTime)reader["Inicio"];
                ret.Prontuario = reader["Prontuario"].ToString();
                ret.Termino = (DateTime)reader["Termino"];

                retorno.Add(ret);
            }

            reader.Close();

            Conexao.Fechar();

            return retorno;
        }

        //public static void Atualizar(MCurso item)
        //{
        //    Conexao.Abrir();

        //    SqlCommand comando = new SqlCommand();
        //    comando.Connection = Conexao.conexao;

        //    comando.CommandText = "UPDATE TBCurso set NOME = @NOME, CHMaxima = @CHMaxima, FKTipoCursoID = @FKTipoCursoID where ID = @ID";

        //    SqlParameter param = new SqlParameter("@NOME", SqlDbType.VarChar);
        //    param.Value = item.Nome;
        //    comando.Parameters.Add(param);
        //    SqlParameter param1 = new SqlParameter("@ID", SqlDbType.Int);
        //    param1.Value = item.Id;
        //    comando.Parameters.Add(param1);
        //    SqlParameter param2 = new SqlParameter("@CHMaxima", SqlDbType.Int);
        //    param2.Value = item.CHMaxima;
        //    comando.Parameters.Add(param2);
        //    SqlParameter param3 = new SqlParameter("@FKTipoCursoID", SqlDbType.Int);
        //    param3.Value = item.FKTipoCurso;
        //    comando.Parameters.Add(param3);

        //    comando.ExecuteNonQuery();

        //    Conexao.Fechar();
        //}

        //public static MCurso Obter(MCurso item)
        //{
        //    MCurso retorno = null;

        //    Conexao.Abrir();

        //    SqlCommand comando = new SqlCommand();
        //    comando.Connection = Conexao.conexao;

        //    comando.CommandText = "SELECT c.ID ID, c.NOME Nome, c.CHMaxima CHMaxima, c.FkTipoCursoID FkTipoCursoID, t.NOME NomeTC FROM TBCurso c inner join TBTipoCurso t on FKTipoCursoID = t.ID WHERE c.ID = @ID";

        //    SqlParameter param = new SqlParameter("@ID", SqlDbType.Int);
        //    param.Value = item.Id;
        //    comando.Parameters.Add(param);

        //    SqlDataReader reader = comando.ExecuteReader();

        //    if (reader.Read())
        //    {
        //        retorno = new MCurso();
        //        retorno.FKTipoCurso = new MTipoCurso();
        //        retorno.Id = (int)reader["ID"];
        //        retorno.Nome = reader["Nome"].ToString();
        //        retorno.CHMaxima = (int)reader["CHMaxima"];
        //        retorno.FKTipoCurso.Id = (int)reader["FkTipoCursoID"];
        //        retorno.FKTipoCurso.Nome = reader["NomeTC"].ToString();
        //    }

        //    reader.Close();

        //    Conexao.Fechar();

        //    return retorno;
        //}

        //public static void Remover(MCurso item)
        //{
        //    Conexao.Abrir();

        //    SqlCommand comando = new SqlCommand();
        //    comando.Connection = Conexao.conexao;

        //    comando.CommandText = "DELETE FROM TBCurso where ID = @ID";

        //    SqlParameter param = new SqlParameter("@ID", SqlDbType.Int);
        //    param.Value = item.Id;
        //    comando.Parameters.Add(param);

        //    comando.ExecuteNonQuery();

        //    Conexao.Fechar();
        //}
    }
}
