using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula05_heranca
{
    internal class Aluno : Usuario
    {
        public List<string> turma = new List<string>();
        public string turno = "Matutino";
    }
}
