using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_constructors
{
    internal class Program
    {
        struct Produto
        {
            public string nome;
            public float preco;
            public string marca;

            public Produto(string nome, float preco, string marca) //Sempre com o mesmo nome das structs.
            {
                this.nome = nome; //O "this" serve para referenciar aos atributos, já que estão fora do escopo do constructor

                this.preco = preco; //Leia-se: A variável "nome"(atributo da struct) =(recebe) a variável nome(parâmetro do constructor).

                this.marca = marca; //obrigatório definir todos os campos da struct
            }
        }

        
        static void Main(string[] args)
        {
            Produto bola = new Produto("Bola Champions League 2022", 500f, "Nike"); //Aqui declaramos os valores a serem passados aos parâmetros do constructor.
            Produto tenis = new Produto("Tenis Adidas Unissex", 200f, "Adidas");

            Console.WriteLine(bola.nome);
            Console.WriteLine(tenis.nome);

            Console.ReadLine();
        }
    }
}
