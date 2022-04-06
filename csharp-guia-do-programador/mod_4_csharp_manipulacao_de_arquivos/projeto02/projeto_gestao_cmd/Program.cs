using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_gestao_cmd
{
    internal class Program
    {
        [System.Serializable] //Lib pra salvar arquivos do tipo costumizado(struct) dentro de arquivos.
        struct Cliente //Tipo principal da aplicação
        {
            public string nome;
            public string email;
            public string cpf;
        }

        static List<Cliente> clienteList = new List<Cliente>(); //Lista onde ficarão os clientes cadastrados


        enum Menu { Listagem = 1, Adicionar = 2, Remover = 3, Sair = 4 }
        static void Main(string[] args)
        {
            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.WriteLine("Sistema de Clientes");
                Console.WriteLine("1 - Listagem\n2 - Adicionar\n3 - Remover\n4 - Sair");
                int intOpcao = int.Parse(Console.ReadLine());
                Menu opcao = (Menu)intOpcao; //Casting para que o número digitado pelo usuário se transforme em uma opção do menu.

                switch (opcao)
                {
                    case Menu.Adicionar:
                        break;
                    case Menu.Listagem:
                        break;
                    case Menu.Remover:
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();
            }
        }
    }
}
