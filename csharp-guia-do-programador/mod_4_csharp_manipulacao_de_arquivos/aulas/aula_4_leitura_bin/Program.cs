using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; //módulo de serialização

namespace aula_4_leitura_binn
{
    internal class Program
    {

        [System.Serializable]
        
        struct Produto
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
            BinaryFormatter encoder = new BinaryFormatter();

            /*
            //Escrevendo uma List no arquivo binário
            encoder.Serialize(stream, langs);

            //Escrevendo uma Struct no arquivo binário
            encoder.Serialize(stream, banana);
            */

            //Na Leitura de arquivos, é essencial saber os tipos que existem e a ordem em que foram escritos.
            // Int
            // float
            // Lista string
            // struct Produto

            List<string> listaDoArquivo = (List<string>)encoder.Deserialize(stream);
            Produto prod = (Produto)encoder.Deserialize(stream);

            Console.WriteLine(listaDoArquivo[1]);
            Console.WriteLine(prod.nome);

            stream.Close();

            Console.ReadLine();


        }
    }
}
