using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula05_heranca
{
    internal class Usuario //Classe pai a partir da qual serão herdados os atributos e métodos comuns para as subclasses Aluno, Professor e Diretor.
    {
        public string nome;
        public string email;
        public string senha;

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
    }
}
