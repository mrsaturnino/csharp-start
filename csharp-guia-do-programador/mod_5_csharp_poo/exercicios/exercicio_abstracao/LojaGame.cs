using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_abstracao
{
    internal class LojaGame
    {
        public int id;
        public string name;
        public string plataforma;
        public string descricao;
        public float preco;

        public void Games()
        {
            Console.WriteLine(name);
            Console.WriteLine(plataforma);
            Console.WriteLine($"R${preco}");
            Console.WriteLine(descricao);
        }

    }
}
