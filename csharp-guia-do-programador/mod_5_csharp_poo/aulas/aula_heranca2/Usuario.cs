using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_heranca2
{
    class Usuario //Classe "Pai"
    {
        //Atributos e métodos que serão herdados pelas classes filhas
        public string nome;
        public string email;
        public string senha;
        private string atributoPrivate; //Atributos privados podem ser acessados apenas dentro das classes
        protected string atributoProtected; //Atributos "Protected" podem ser acessados apenas pelas classes filhas.

        public Usuario(string nome, string email, string senha) //quando geramos um construtor para na classe Pai, é obrigatório declará-lo nas classes filhas.
        {
            this.nome = nome;
            this.nome = email;
            this.nome = senha;

        }

        public void Logar() //demonstração da utilização do método/função das classes filhas.
        {
            Console.WriteLine("Fazendo login...");
        }

        public void Exibir() // Método/função para exibir as informações das classes
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"E-mail: {email}");
            Console.WriteLine($"Senha: {senha}");
        }
    }

    class Aluno : Usuario //classe filha "Aluno" que herda os atributos e métodos da classe pai "Usuario".
    {
        public List<string> turmas = new List<string>();
        public string turno = "Matutino";

        public Aluno(string turno, string nome, string email, string senha) : base(nome, email, senha) //"base()" serve para referenciar aos atributos da classe Pai.
        {
            this.turno = turno; //Não é necessário declarar os outros parâmetros por causa do "base()"
        }
    }

    class Professor : Usuario //classe filha "Professor" que herda os atributos e métodos da classe pai "Usuario".
    {
        public List<string> turmas = new List<string>();
        public string disciplina;

        public Professor(string nome, string email, string senha) : base(nome, email, senha)
        {

        }
    }

    //OBS: As classes "Pai" jamais poderão herdar atributos das classes filhas (logicamente).
}
