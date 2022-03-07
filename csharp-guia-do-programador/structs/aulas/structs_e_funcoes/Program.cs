using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structs_e_funcoes
{
    internal class Program
    {
        struct Produto
        {
            public string nome;
            public float preco;
            public string marca;

            public Produto(string nome, float preco, string marca)
            {
                this.nome = nome; //O "this" serve para referenciar aos atributos, já que estão fora do escopo do constructor

                this.preco = preco; //Leia-se: A variável "nome"(atributo da struct) =(recebe) a variável nome(parâmetro do constructor).

                this.marca = marca; 
            }

            public void ExibirInfo()
            {
                Console.WriteLine($"Nome: {this.nome}"); //Esta função pegará os valores das variáveis e executará estes comandos.
                Console.WriteLine($"Preço: R$ {this.preco}");
                Console.WriteLine($"Marca: {this.marca}");
                AdicionarCupom(50f);
            }

            public void AdicionarCupom(float porc)
            {
                float desconto = this.preco * porc / 100f;
                Console.WriteLine($"Este é o valor deste produto com o cupom: {this.preco - desconto}");

            }
        }

        static void Main(string[] args)
        {
            //Adicionando valores (que são as variáveis bola e chuteira) aos parâmetros da nossa construct, que irá atribuí-los aos campos/atributos da struct.
            Produto bola = new Produto("Bola da UEFA Champions League 2022", 100f, "Nike"); 
            Produto chuteira = new Produto("Chuteira Adidas", 200f, "Adidas");

            bola.ExibirInfo(); //Leia-se: Pegue os campos da variável bola e execute a função com esses valores.
            Console.WriteLine("================");
            chuteira.ExibirInfo();

            /*
               1º) Adicionamos ao construtor as variáveis bola e chuteira, e seus valores relativos aos parâmetros do construtor.
                2º) O construtor capta e "joga" estas variáveis e seus valores para dentro dos campos/atributos da 
                    struct Produto.
                 3º) Por fim, a função "ExibirInfo" pega estes valores e os utiliza conforme os comandos.
            */
            Console.WriteLine("================");
            bola.AdicionarCupom(50f);
            chuteira.AdicionarCupom(50f);

            Console.ReadLine();
        }
    }
}
