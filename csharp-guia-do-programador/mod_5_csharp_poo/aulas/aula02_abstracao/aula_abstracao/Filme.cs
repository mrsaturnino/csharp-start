using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_abstracao
{
    internal class Filme
    {
        //definindo atributos/campos da classe
        public string nome; //"public" para que qualquer classe possa acessar este campo
        public string desc;
        public string estudio;
        public int ano;
        public List<string> atores = new List<string>();

        //definindo métodos

        public void Executar()
        {
            Console.WriteLine($"Reproduzindo: {nome}");
        }

        public void Pausar()
        {
            Console.WriteLine("||");
        }
    }
}
