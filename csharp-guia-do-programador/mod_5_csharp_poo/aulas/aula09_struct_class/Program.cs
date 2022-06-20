using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula09_struct_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diferente das structs, quando trabalhamos com classes, o objeto que criamos é alocado em algum espaço na memória e então todas as variáveis que referenciamos esse objeto apontam diretamente para o endereço desse espaço alocado.

            Filme filme = new Filme("Topgun", "adkksoakd", 1990, "aaa"); 
            Filme filme2 = filme; //A variável "filme2" é o que chamamos de "ponteiro", já que esta aponta para o endereço do objeto.

            Console.WriteLine(filme2.nome); //A variável "filme2" está referenciando a var "filme" que possui o endereço da memória para chegar até o objeto.

            Console.ReadLine();
        }
    }
}
