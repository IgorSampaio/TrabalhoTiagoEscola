using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class MAlunoCurso
    {
        public MAluno FKAlunoCPF { get; set; }
        public MCurso FKCursoID { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public string Prontuario { get; set; }
        public MTipoTerminoCurso FKTipoTerminoCursoID { get; set; }

    }
}
