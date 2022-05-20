using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula05_heranca
{
    internal class Professor : Usuario
    {
        public string[] turmas = {};
        public string[] disciplinas = {};

        public Professor(string nome, string email, string senha) : base(nome, email, senha)
        {
            
        }
    }
}
