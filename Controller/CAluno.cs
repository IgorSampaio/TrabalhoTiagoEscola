using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Controller
{
    public class CAluno
    {
        public static void Inserir(MAluno item)
        {
            item.Nome = item.Nome.Trim();
            item.CPF = item.CPF.Trim();
            if(item.Nome == "")
            {
                throw new ExcecaoPersonalizada(Erros.AlunoNome);
            }
            if(item.CPF == "")
            {
                throw new ExcecaoPersonalizada(Erros.AlunoCPF);
            }
            if (DAluno.ExisteCPF(item))
            {
                throw new ExcecaoPersonalizada(Erros.AlunoCPFExiste);
            }

            DAluno.Inserir(item);
        }

        public static List<MAluno> Pesquisar(MAluno item)
        {
            if (item.Nome.Length > 100)
                throw new ExcecaoPersonalizada(Erros.AlunoNome);
            
            return DAluno.Pesquisar(item);
        }

        public static void Remover(MAluno item)
        {
            DAluno.Remover(item);
        }

        public static void Alterar(MAluno item)
        {
            item.Nome = item.Nome.Trim();
            item.CPF = item.CPF.Trim();
            if(item.Nome == "")
            {
                throw new ExcecaoPersonalizada(Erros.AlunoNome);
            }
            if(item.CPF == "")
            {
                throw new ExcecaoPersonalizada(Erros.AlunoCPF);
            }

            DAluno.Alterar(item);
        }
    }
}
