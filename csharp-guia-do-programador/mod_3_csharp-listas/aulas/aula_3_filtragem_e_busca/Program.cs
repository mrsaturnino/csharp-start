using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_3_filtragem_e_busca
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

            foreach (string cliente in clientes) //Um foreach para mostrar cada cliente que está na lista.
            {
                Console.WriteLine(cliente);
            }

            //Busca de itens nas listas (biblioteca System.Linq)

            Console.WriteLine("============================");


            //O "Find" busca de acordo com a condicional, e retorna apenas o primeiro que encontrar.
            string busca = clientes.Find(cliente => cliente.Length <= 5);

            Console.WriteLine(busca);

            Console.WriteLine("============================");

            //Basicamente, o "FindAll" cria uma lista dos elementos que estão de acordo com a condicional (filtro)
            List<string> buscaFiltrada = clientes.FindAll(cliente => cliente.Length <= 5);

            foreach (string cliente in buscaFiltrada) 
            {
                Console.WriteLine(cliente);
            }
        }
    }
}
