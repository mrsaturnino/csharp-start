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
            Aluno aluno1 = new Aluno(); //erro pois não há uma utilização parametro do construtor.

            aluno1.nome = "Andre";
            aluno1.email = "andre_santos2012@hotmail.com";
            aluno1.turno = "Matutino";
            aluno1.turmas.Add("B");
            aluno1.Logar();

            aluno1.Exibir(); //Função/método que será utilizado para exibir as informações dos atributos da classe Aluno, que foram herdados da classe pai.

            Console.WriteLine();

            Professor prof = new Professor();

            prof.nome = "Professor";
            prof.email = "professor@gmail.com";
            aluno1.turmas.Add("B");
            prof.disciplina = "Matemática";

            prof.Exibir();

        }
    }
}
