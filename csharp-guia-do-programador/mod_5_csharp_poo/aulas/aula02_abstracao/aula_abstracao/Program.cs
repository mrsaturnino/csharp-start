using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme filme = new Filme(); //Chamando a classe "Filme" para criar uma variável que utiliza seus campos/atributos.

            filme.nome = "Titanic"; //Atribuindo um valor a esta variável, que utilizará o campo "nome".

            filme.Executar(); //Após o valor "Titanic" estar dentro da variável, a função "Executar()" fará o seu papel.

            //Criando um segundo filme
            Console.WriteLine("============================");
            Filme filme2 = new Filme();
            filme2.nome = "Pearl Harbor";
            filme2.Executar();

            Console.ReadLine();
        }
    }
}
