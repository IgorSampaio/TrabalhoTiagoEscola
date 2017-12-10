using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;

namespace DAO
{
    public class DAluno
    {
        public static bool ExisteCPF(MAluno aluno)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand();
            comando.Connection = Conexao.conexao;
            comando.CommandText = "SELECT * FROM TBAluno WHERE CPF = @CPF";

            SqlParameter param = new SqlParameter("@CPF", System.Data.SqlDbType.Char);
            param.Value = aluno.CPF;
            comando.Parameters.Add(param);
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                Conexao.Fechar();
                return true;
            }
            reader.Close();
            Conexao.Fechar();
            return false;
        }

        public static List<MAluno> Pesquisar(MAluno item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand("SELECT * FROM TBALUNO WHERE NOME LIKE @NOME", Conexao.conexao);

            SqlParameter param = new SqlParameter("@NOME", System.Data.SqlDbType.VarChar);
            param.Value = "%" + item.Nome + "%";
            comando.Parameters.Add(param);

            SqlDataReader reader = comando.ExecuteReader();

            List<MAluno> lista = new List<MAluno>();

            while (reader.Read())
            {
                MAluno ret = new MAluno();
                ret.Nome = reader["NOME"].ToString();
                ret.CPF = reader["CPF"].ToString();
                ret.Nascimento = (DateTime)reader["NASCIMENTO"];
                lista.Add(ret);
            }

            reader.Close();
            Conexao.Fechar();

            return lista;
        }

        public static void Alterar(MAluno item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand("UPDATE TBALUNO SET NOME = @NOME, NASCIMENTO = @NASCIMENTO WHERE CPF = @CPF", Conexao.conexao);

            SqlParameter param = new SqlParameter("@NOME", System.Data.SqlDbType.VarChar);
            param.Value = item.Nome;
            comando.Parameters.Add(param);

            param = new SqlParameter("@NASCIMENTO", System.Data.SqlDbType.Date);
            param.Value = item.Nascimento;
            comando.Parameters.Add(param);

            param = new SqlParameter("@CPF", System.Data.SqlDbType.Char);
            param.Value = item.CPF;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }

        public static void Remover(MAluno item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand("DELETE FROM TBALUNO WHERE CPF = @CPF", Conexao.conexao);

            SqlParameter param = new SqlParameter("@CPF", System.Data.SqlDbType.Char);
            param.Value = item.CPF;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }

        public static void Inserir(MAluno item)
        {
            Conexao.Abrir();

            SqlCommand comando = new SqlCommand("INSERT INTO TBAluno VALUES (@CPF, @NOME, @NASC)", Conexao.conexao);

            SqlParameter param = new SqlParameter("@CPF", System.Data.SqlDbType.Char);
            param.Value = item.CPF;
            comando.Parameters.Add(param);

            param = new SqlParameter("@NOME", System.Data.SqlDbType.VarChar);
            param.Value = item.Nome;
            comando.Parameters.Add(param);

            param = new SqlParameter("@NASC", System.Data.SqlDbType.Date);
            param.Value = item.Nascimento;
            comando.Parameters.Add(param);

            comando.ExecuteNonQuery();

            Conexao.Fechar();
        }
    }
}
