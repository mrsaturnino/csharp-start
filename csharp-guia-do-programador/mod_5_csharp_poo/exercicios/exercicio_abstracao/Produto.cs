using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_abstracao
{
    internal class Produto
    {
        public string modelo;
        public float preco;
        public string descricao;
        public int estoque;

        public void Smartphone()
        {
            Console.WriteLine(modelo);
            Console.WriteLine($"Preço: R${preco}");
            Console.WriteLine(descricao);
            Console.WriteLine($"Quantidade em estoque: {estoque}un");
        }
    }
}
