using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; //módulo de serialização

namespace aula_3_escrita_bin
{
    internal class Program
    {

        [System.Serializable] 
        //necessário para informar que o tipo costumizado (struct Produto) pode ser serializado.
        struct Produto //criando um tipo costumizado
        {
            public string nome;
            public float preco;
        }
        static void Main(string[] args)
        {
            
            //Variáveis
            int a = 550;
            string nome = "Joao";
            float b = 12.8f;

            //List
            List<string> langs = new List<string>();
            langs.Add("C#");
            langs.Add("Python");
            langs.Add("JavaScript");
            langs.Add("PHP");

            //Struct
            Produto banana = new Produto();
            banana.nome = "Banana";
            banana.preco = 2f;


            FileStream stream = new FileStream("meuarquivo.andre", FileMode.OpenOrCreate);
            //FileStream para ler e escrever o arquivo
            //FileMode para definir a forma como trabalharemos no arquivo
            BinaryFormatter encoder = new BinaryFormatter();
            //BinaryFormatter é o serializador que vai transformar os tipos em conjuntos de bytes.


            //Escrevendo tipos diretamente no arquivo binário
            encoder.Serialize(stream, 550);
            encoder.Serialize(stream, "André Santos");
            encoder.Serialize(stream, true);
            encoder.Serialize(stream, false);

            //Escrevendo variáveis no arquivo binário
            encoder.Serialize(stream, a);
            encoder.Serialize(stream, nome);
            encoder.Serialize(stream, b);

            //Escrevendo uma List no arquivo binário
            encoder.Serialize(stream, langs);

            //Escrevendo uma Struct no arquivo binário
            encoder.Serialize(stream, banana);

            stream.Close();


        }
    }
}
