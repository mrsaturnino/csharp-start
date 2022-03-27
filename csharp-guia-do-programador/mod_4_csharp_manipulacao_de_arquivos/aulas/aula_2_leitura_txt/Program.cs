using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace aula_2_leitura_txt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrevendo um arquivo de texto
            /*
            StreamWriter escritor = File.AppendText("teste.txt");
            escritor.WriteLine("André");
            escritor.WriteLine("Saturnino");
            escritor.WriteLine("Dos");
            escritor.WriteLine("Santos");

            escritor.Close();
            */

            Leitura1();

            Console.WriteLine("================================");

            Leitura2();
        
        }
        public static void Leitura1()
        {
            StreamReader leitor = new StreamReader("teste.txt"); //abrindo o stream de leitura

            // Primeira forma
             
            string linhaLida = ""; //Var "linhaLida" para armazenar o que já foi feito dentro do laço de repetição.

            while (linhaLida != null) 
                //Enquanto o valor da variável linhaLida for diferente de "null", execute o codigo abaixo:
            {
                linhaLida = leitor.ReadLine(); //Leia uma linha e coloque-a dentro da variável "linhaLida"
                Console.WriteLine(linhaLida); //Exiba a linha que foi lida
            }

            leitor.Close(); //fechando o stream de leitura

            Console.WriteLine("Arquivos gerados com sucesso.");
            Console.ReadLine();

        }

        public static void Leitura2()
        {
            //Podemos também, ler linha por linha e armazenar cada uma em uma posição de uma lista/array.

            StreamReader leitor = new StreamReader("teste.txt"); //abrindo o stream de leitura

            List<string> linhas = new List<string>();

            string linha = ""; //var que irá armazenar a linha que já foi lida.

            while (linha != null) //enquanto as linhas do conteúdo forem diferentes de null, o laço será executado.
            {
                linha = leitor.ReadLine(); //o leitor, lê as linhas uma por uma e as armazena na var "linha".
                if (linha != null)
                {
                    linhas.Add(linha); //Se a linha lida for diferente de null, será adicionada a uma posição na lista.
                }
            }

            foreach (string line in linhas) //Para cada linha na lista, exibir no console.
            {
                Console.WriteLine(line);
            }

            leitor.Close(); //fechando o stream de leitura

            Console.WriteLine("Arquivos gerados com sucesso.");
            Console.ReadLine();
        }
    }
}
