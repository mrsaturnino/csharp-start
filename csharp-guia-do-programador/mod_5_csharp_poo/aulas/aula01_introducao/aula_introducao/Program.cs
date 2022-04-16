using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_introducao
{
    class Jogo
    {
        //atributos da classe (Dados da classe "jogo")
        public string titulo;
        public string genero;
        public string desenvolvedora;
        public float preco;

        //métodos da classe (Ações que a classe realiza)
        
        public void Abrir() 
        {
            Console.WriteLine("Abrindo...");
        }

        public void Carregar() 
        { 
            Console.WriteLine("Loading...");
        }

        public void Fechar() 
        { 
            Console.WriteLine("Aperte ESC para sair...");
        }

    }
}
