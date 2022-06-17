using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_heranca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando um objeto a partir da classe aluno
            Aluno aluno1 = new Aluno("Matutino", "Andre", "andre_santos@hotmail.com", "123321" ); //pode haver erro se não houver uma utilização para os parametros do construtor.


            //O C# vai identificar os parâmetros passados abaixo, e então vai procurar a qual método essa assinatura pertence.
            //Logar(string, string)
            aluno1.Logar("andre_@hotm.com", "senha");

            Console.WriteLine("=========================================");

            aluno1.Exibir(); //Função/método que será utilizado para exibir as informações dos atributos da classe Aluno, que foram herdados da classe pai.

            Console.WriteLine("=========================================");









            /*
            Professor prof = new Professor("Professor", "professor@gmail.com", "123321");

            prof.Exibir();
            */

            Console.ReadLine();
        }
    }
}
