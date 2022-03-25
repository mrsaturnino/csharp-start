using System;
using System.Collections.Generic; //Adiciona: Listas, Dicionários, Sets, HashTables e várias outras estruturas de dados;
using System.Linq; //Manipular conjuntos de dados C#; Funcionalidades como filtragem, remoção, busca, e muitas outras.
using System.Text;
using System.Threading.Tasks;

namespace aula_1_criando_listas_e_null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> clientes = new List<string>(); 
            /* 
             O "new List<string>();" cria uma nova lista e coloca dentro da lista clientes,
             já que tipos complexos, como Listas, não podem ter valores "null".
             */
            
            //Adicionando itens à lista

            clientes.Add("Andre"); //Aqui, adicionamos uma string à nossa lista.
            clientes.Add("Saturnino"); //Lembre-se sempre de colocar elementos do mesmo tipo da lista.
            string pessoa = "Pedro";
            clientes.Add(pessoa); //Também podemos adicionar variáveis (que sejam do msm tipo) às listas!

            Console.WriteLine(clientes[2]); //"Acessamos" as listas da mesma forma que as Arrays.

            clientes [1] = "Clint"; //Alterando itens da lista
            Console.WriteLine(clientes[1]);
            Console.ReadLine();


        }
    }
}
