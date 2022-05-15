using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula04_static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //campo estático sendo acessado diretamente pela classe.
            Pessoa.CallName();

            Console.WriteLine();

            //campo não-estático sendo acessado por um objeto
            Pessoa pessoa = new Pessoa();
            pessoa.nome = "André";
            pessoa.ChamarNome();
        }
    }
}
