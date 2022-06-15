using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_static2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o título do filme: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a descrição do filme: ");
            string desc = Console.ReadLine();
            Console.WriteLine("Digite o ano do filme: ");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o estúdio do filme: ");
            string estudio = Console.ReadLine();

            Console.WriteLine();

            Filme filme = new Filme(nome, desc, ano, estudio);

            Console.WriteLine($"Título: {filme.nome}");
            Console.WriteLine($"Descrição do filme: {filme.desc}");
            Console.WriteLine($"Ano: {filme.ano}");
            Console.WriteLine($"Estúdio: {filme.estudio}");
            Console.ReadLine();
        }
    }
}
