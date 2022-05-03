using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula03_classes
{
    internal class Filme
    {
        //atributos da classe Filme
        public string title;
        public string desc;
        public int year;
        public string studio;
        public List<string> actors = new List<string>();

        //métodos da classe Filme
        public void Executar()
        {
            Console.WriteLine($"Playing: {title}");
        }

        public void Pausar()
        {
            Console.WriteLine("||");
        }

        //A partir disto, temos a estrutura de que precisamos para CRIAR um filme em nossa classe principal, que contém o método "Main". 

    }
}
