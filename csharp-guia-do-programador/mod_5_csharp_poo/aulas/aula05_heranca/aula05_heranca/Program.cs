using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula05_heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno("Matutino", "Andre", "mrsaturnino@outmail.com", "123456");
            
            a.Logar();

            a.Exibir(); //função da classe "pai" que exibe todos os valores inseridos nos campos/atributos "pai".

            Console.WriteLine("=========================================================");

            Professor b = new Professor("Bill", "bill@hotmail.com", "465465456");

            b.Logar();

            b.Exibir();
        }
    }
}
