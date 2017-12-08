using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Controller
{
    public class CTipoCurso
    {
       public static void Inserir(MTipoCurso item)
       {
            if(item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPersonalizada(Erros.TipoCursoNome);
            }

            item.Nome = item.Nome.Trim();

            List<MTipoCurso> lista = Pesquisar(item);

            if (lista != null && lista.Count > 0)
                throw new ExcecaoPersonalizada(Erros.TipoCursoNomeJaExiste);

            DTipoCurso.Inserir(item);
       }

        public static List<MTipoCurso> Pesquisar(MTipoCurso item)
        {
            return DTipoCurso.Pesquisar(item);
        }

        public static void Remover(MTipoCurso item)
        {
            DTipoCurso.Remover(item);
        }

        public static MTipoCurso Obter(MTipoCurso item)
        {
            return DTipoCurso.Obter(item);
        }

        public static void Atualizar(MTipoCurso item)
        {
            if (item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPersonalizada(Erros.TipoCursoNome);
            }

            item.Nome = item.Nome.Trim();

            List<MTipoCurso> lista = Pesquisar(item);

            if (lista != null && lista.Count > 0 && lista[0].Id != item.Id)
                throw new ExcecaoPersonalizada(Erros.TipoCursoNomeJaExiste);

            DTipoCurso.Atualizar(item);
        }
    }
}
