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

        //Podemos ter várias funções/métodos de uma classe com o mesmo nome. Desde que suas assinaturas sejam diferentes. Polimorfismo de sobrecarga.
        
        //Assinatura: Logar(void)
        public void Logar() 
        {
            Console.WriteLine("Fazendo login...");
        }
        
        //Assinatura: Logar(string)
        public void Logar(string codigo)
        {
            Console.WriteLine("Fazendo login com o código...");
        }

        //Assinatura: Logar(string, string)
        public void Logar(string email, string senha) 
        {
            Console.WriteLine("Fazendo login com o email e a senha...");
        }

        //Se invertermos a ordem dos tipos, criamos assinaturas diferentes.

        //Assinatura: Logar(string, int)
        public void Logar(string email, int pin)
        {
            Console.WriteLine("Fazendo login com o email e o pin...");
        }

        //Assinatura: Logar(int, string)
        public void Logar(int pin, string email)
        {
            Console.WriteLine("Fazendo login com o pin e o email...");
        }


        public virtual void Exibir() //Método/função para exibir as informações das classes
            //o "virtual" serve para permitir que esse método, que pertence à classe Pai "Usuario", seja costumizável para as classes filhas.
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

        public override void Exibir() //Uma "cópia" costumizável do MÉTODO Exibir() ORIGINAL DA CLASSE PAI "Usuario".
            //override para "Sobreescrever".
        {
            Console.WriteLine("Dados do Aluno: ");
            base.Exibir(); //o base serve para executarmos também o método original da classe Pai em conjunto.
            Console.WriteLine("Turno: " + turno); //Aqui utilizamos um atributo exclusivo da classe "Aluno". Para isso que serve o polimorfismo de sobreposição.
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
