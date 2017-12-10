using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class Erros
    {
        public static string ErroPadrao = "Houve um erro no sistema. Por favor, contate o administrador.";
        public static string TipoCursoNome = "O nome do tipo de curso informado é inválido.";
        public static string TipoCursoNomeJaExiste = "Já existe um tipo de curso cadastrado com o nome informado.";
        public static string CursoNome = "O nome do curso informado é inválido.";
        public static string CursoNomeJaExiste = "Já existe um curso cadastrado com o nome informado.";
        public static string AlunoNome = "O nome do aluno informado é inválido.";
        public static string AlunoCPF = "O CPF do aluno informado é inválido.";
        public static string AlunoCPFExiste = "O CPF do aluno informado já existe.";
        public static string ProntuarioExiste = "O prontuário informado já existe.";
        public static string ProntuarioInvalido = "O número de prontuário informado é inválido.";
        public static string TipoTerminoCursoExiste = "O tipo de término de curso informado já existe.";
        public static string TipoTerminoCursoInvalido = "O tipo de término de curso informado é inválido.";
        public static string CargaHoraria = "A carga horária informada é inválida.";
    }
}
