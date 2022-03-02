using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprendendo_structs
{
    internal class Program
    {
        struct Produto //Imagine as structs como "Super Variáveis", que guardam outras variáveis. (bem superficialmente)
        {
            public string nome; //Os atributos devem ter "public" declarados, para que sejam utilizáveis em todo o código.
            public float preco;
            public string marca;
        }
        static void Main(string[] args)
        {
            Produto bola = new Produto(); //Criamos uma variável do tipo "Produto". Leia-se: Novo produto sendo cadastrado dentro da super variável "Produto". 
            bola.nome = "Bola da champions league 2022"; //Chamando os atributos da struct para a variável "bola" e adicionando valores aos campos.
            bola.preco = 500f;
            bola.marca = "Nike";

            Console.WriteLine(bola.nome); //Imprimindo os valores adicionados aos campos da variável "bola".
            Console.WriteLine(bola.preco);

            Console.ReadLine();
            
            //Claro que existe uma forma mais fácil e usual para adicionar valores aos campos da struct.
            
        }
    }
}
