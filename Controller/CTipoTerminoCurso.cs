using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Controller
{
    public class CTipoTerminoCurso
    {
        public static void Inserir(MTipoTerminoCurso item)
        {
            if (item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPersonalizada(Erros.TipoTerminoCursoInvalido);
            }

            item.Nome = item.Nome.Trim();

            List<MTipoTerminoCurso> lista = Pesquisar(item);

            if (lista != null && lista.Count > 0)
                throw new ExcecaoPersonalizada(Erros.TipoTerminoCursoExiste);

            DTipoTerminoCurso.Inserir(item);
        }

        public static List<MTipoTerminoCurso> Pesquisar(MTipoTerminoCurso item)
        {
            return DTipoTerminoCurso.Pesquisar(item);
        }

        public static void Remover(MTipoTerminoCurso item)
        {
            DTipoTerminoCurso.Remover(item);
        }

        public static MTipoTerminoCurso Obter(MTipoTerminoCurso item)
        {
            return DTipoTerminoCurso.Obter(item);
        }

        public static void Atualizar(MTipoTerminoCurso item)
        {
            if (item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPersonalizada(Erros.TipoTerminoCursoInvalido);
            }

            item.Nome = item.Nome.Trim();

            List<MTipoTerminoCurso> lista = Pesquisar(item);

            if (lista != null && lista.Count > 0 && lista[0].Id != item.Id)
                throw new ExcecaoPersonalizada(Erros.TipoTerminoCursoExiste);

            DTipoTerminoCurso.Atualizar(item);
        }
    }
}
