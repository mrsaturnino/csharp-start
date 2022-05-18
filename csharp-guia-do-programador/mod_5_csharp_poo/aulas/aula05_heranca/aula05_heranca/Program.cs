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
            Aluno a = new Aluno();

            a.nome = "André";
            a.email = "mrsaturnino@...";
            a.senha = "123456";
            a.turno = "Vespertino";
            
            a.Logar();

            a.Exibir(); //função da classe "pai" que exibe todos os valores inseridos nos campos/atributos "pai".

            Console.WriteLine("=========================================================");

            Professor b = new Professor();

            b.nome = "Bill";
            b.email = "bill@hotmail.com";
            b.senha = "5646556";
            b.Logar();

            b.Exibir();
        }
    }
}
