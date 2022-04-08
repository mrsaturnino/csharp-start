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
                        Adicionar();
                        break;
                    case Menu.Listagem:
                        Listagem();
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

        static void Adicionar()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Cadastro de cliente: ");
            Console.WriteLine("Nome do cliente: ");
            cliente.nome = Console.ReadLine();
            Console.WriteLine("Email do cliente: ");
            cliente.email = Console.ReadLine();
            Console.WriteLine("CPF do cliente: ");
            cliente.cpf = Console.ReadLine();
            
            clienteList.Add(cliente);
            
            Console.WriteLine("Cadastro concluído, aperte 'Enter' para sair.");
            Console.ReadLine();

        }

        static void Listagem()
        {
            if(clienteList.Count > 0) //Leia-se: SE tem pelo menos 1 (um) cliente nessa lista, execute a função abaixo.
            {
                Console.WriteLine("Lista de clientes: ");

                int i = 0; //contador para alimentar o ID a cada cliente cadastrado.

                foreach (Cliente cliente in clienteList)
                {
                    Console.WriteLine($"ID: {i}");
                    Console.WriteLine($"Nome: {cliente.nome}");
                    Console.WriteLine($"E-mail: {cliente.email}");
                    Console.WriteLine($"CPF: {cliente.cpf}");
                    Console.WriteLine("===========================");
                    i++; //incremento do contador do ID.
                }
            }
            else 
            {
                Console.WriteLine("Nenhum cliente cadastrado!");
            }

            Console.WriteLine("Aperte 'Enter' para sair.");
            Console.ReadLine();
        }
    }
}
