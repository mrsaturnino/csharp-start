using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula04_static
{
    internal class Pessoa
    {
        public string nome;
        static public string name = "Andre";

        static public void CallName()
        {
            Console.WriteLine(name);
        }

        public void ChamarNome()
        {
            Console.WriteLine(nome);
        }
    }

    
}
