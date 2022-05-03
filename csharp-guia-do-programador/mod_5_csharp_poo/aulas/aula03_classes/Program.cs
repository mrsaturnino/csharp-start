using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula03_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme filme = new Filme();
            filme.title = "Titanic";
            filme.Executar();

            Filme filme2 = new Filme();
            filme.title = "Pearl Harbor";
            filme.Executar();
        }
    }
}
