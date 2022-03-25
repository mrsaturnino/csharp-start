using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_2_removendo_itens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> clientes = new List<string>();
            clientes.Add("Fish");
            clientes.Add("Mars");
            clientes.Add("FicaFliston");
            clientes.Add("Clint");
            clientes.Add("Guts");
            string pessoa = "Jotta";
            clientes.Add(pessoa);

            //Removendo itens de listas!

            foreach (string cliente in clientes) //Um foreach para mostrar cada cliente que está na lista.
            {
                Console.WriteLine(cliente);
            }

            clientes.RemoveAt(1); //Removendo o item de índice "1", ou seja, o "Mars".

            Console.WriteLine("=============================");

            foreach (string cliente in clientes) 
                //O mesmo foreach, desta vez, mostrando a lista já com o Mars excluído pelo RemoveAt(1);
            {
                Console.WriteLine(cliente);
            }

            //Agora, removendo pelo item em si, e não pelo seu índice.

            clientes.RemoveAll( cliente => cliente == "Fish");
            /*
             Basicamente, criamos uma frase para o C#.
             O RemoveAll vai "varrer" a lista clientes tentando encontrar o "Fish" e irá removê-lo. 
             Mesmo que ele esteja também em outra posição, o "RemoveAll" só acaba quando termina.
             */

            Console.WriteLine("=============================");

            foreach (string cliente in clientes) 
                //O mesmo foreach, desta vez, mostrando a lista já com o Fish excluído pelo RemoveAll();
            {
                Console.WriteLine(cliente);
            }

            Console.ReadLine();
        }
    }
}
