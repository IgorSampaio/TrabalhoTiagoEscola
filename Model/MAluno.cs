using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    class MAluno
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
    }
}
