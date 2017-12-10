using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Controller
{
    public class CCurso
    {
        public static void Inserir(MCurso item)
        {
            if (item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPersonalizada(Erros.CursoNome);
            }

            item.Nome = item.Nome.Trim();

            List<MCurso> lista = Pesquisar(item);

            if (lista != null && lista.Count > 0)
                throw new ExcecaoPersonalizada(Erros.CursoNomeJaExiste);

            DCurso.Inserir(item);
        }

        public static List<MCurso> Pesquisar(MCurso item)
        {
            return DCurso.Pesquisar(item);
        }
        public static void Remover(MCurso item)
        {
            DCurso.Remover(item);
        }

        public static MCurso Obter(MCurso item)
        {
            
                return DCurso.Obter(item);
        }

        public static void Atualizar(MCurso item)
        {
            if (item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPersonalizada(Erros.CursoNome);
            }

            item.Nome = item.Nome.Trim();

            List<MCurso> lista = Pesquisar(item);

            if (lista != null && lista.Count > 0 && lista[0].Id != item.Id)
                throw new ExcecaoPersonalizada(Erros.CursoNomeJaExiste);

            DCurso.Atualizar(item);
        }
    }
}
