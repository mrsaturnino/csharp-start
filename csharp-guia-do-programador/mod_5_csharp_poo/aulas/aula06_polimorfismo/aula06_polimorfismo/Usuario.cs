using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula06_polimorfismo
{
    class Usuario //classe Pai
    {
        public string nome;
        public string email;
        public string senha;

        public Usuario(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        //Assinatura: Logar(void)
        public void Logar()
        {
            Console.WriteLine("Logando...");
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Senha: {senha}");
        }

        /* AULA POLIMORFISMO DE SOBRECARGA
        public void Logar(string x)
        {
            Console.WriteLine("Logando o código sms");
        }

        //Assinatura: Logar(string, string)
        public void Logar(string email, string senha)
        {
            Console.WriteLine("Logando com e-mail e senha");
        }

        public void Logar(string email, int pin)
        {
            Console.WriteLine("Logando com e-mail e PIN");
        }
        */
       
    }

    class Aluno : Usuario //classe "Aluno" filha da classe pai "Usuario"
    {
        //atributos da classe filha
        public List<string> turmas = new List<string>();
        public string turno = "Matutino";

        //construtor com herança, referenciando ("base(nome, email, senha)") os atributos da classe Pai (usuario).
        public Aluno(string turno, string nome, string email, string senha) : base(nome, email, senha)
        {
            this.turno = turno;
        }
    }
}
