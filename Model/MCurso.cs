using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class MCurso
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public int CHMaxima { get; set; }
        public MTipoCurso FKTipoCurso { get; set; }
    }
}
