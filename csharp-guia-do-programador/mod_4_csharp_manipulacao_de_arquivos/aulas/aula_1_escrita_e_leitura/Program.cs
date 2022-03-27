using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace aula_1_escrita_e_leitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter escritor = new StreamWriter("teste.txt"); 
            //O "StreamWriter" abre o fluxo de comunicação para a escrita no arquivo.
            escritor.WriteLine("André");
            escritor.WriteLine("Saturnino");
            escritor.WriteLine("Santos");
            escritor.Close(); //Fecha o fluxo de comunicação.


            /*A diferença é que o "AppendText" é um tipo de stream que toda vez que for gravado um novo dado,
              os que já foram anteriormente GRAVADOS não são afetados.*/
            StreamWriter escritor2 = File.AppendText("teste2.txt");
            escritor2.WriteLine("André");
            escritor2.Close();

            Console.WriteLine("Arquivos gerados com sucesso.");
            Console.ReadLine();
        }
    }
}
