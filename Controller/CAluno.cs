﻿using System;
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
            if (item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPersonalizada(Erros.TipoCursoNome);
            }

            item.Nome = item.Nome.Trim();

            List<MAluno> lista = Pesquisar(item);

            if (lista != null && lista.Count > 0)
                throw new ExcecaoPersonalizada(Erros.TipoCursoNomeJaExiste);

            DAluno.Inserir(item);
        }

        public static List<MAluno> Pesquisar(MAluno item)
        {
            return DAluno.Pesquisar(item);
        }

        public static void Remover(MAluno item)
        {
            DAluno.Remover(item);
        }

        public static MAluno Obter(MAluno item)
        {
            return DAluno.Obter(item);
        }

        public static void Atualizar(MAluno item)
        {
            if (item.Nome.Trim() == "" || item.Nome.Length > 100)
            {
                throw new ExcecaoPersonalizada(Erros.TipoCursoNome);
            }

            item.Nome = item.Nome.Trim();

            List<MAluno> lista = Pesquisar(item);

            if (lista != null && lista.Count > 0 && lista[0].CPF != item.CPF)
                throw new ExcecaoPersonalizada(Erros.TipoCursoNomeJaExiste);

            DAluno.Atualizar(item);
        }
    }
}
