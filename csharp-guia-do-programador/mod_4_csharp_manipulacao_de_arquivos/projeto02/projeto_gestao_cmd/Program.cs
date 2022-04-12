using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

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
            Carregar(); //a função é chamada aqui para que o arquivo seja carregado com os dados já salvos anteriormente.

            bool escolheuSair = false;

            while (!escolheuSair)
            {
                Console.WriteLine("[ SISTEMA DE CLIENTES ]");
                Console.WriteLine();
                Console.WriteLine(" 1 - Listagem\n 2 - Adicionar\n 3 - Remover\n 4 - Sair");
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
                        Remover();
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
                Console.WriteLine(" [CADASTRO DE CLIENTES] ");
                Console.WriteLine(" Nome do cliente: ");
                cliente.nome = Console.ReadLine();
                Console.WriteLine(" Email do cliente: ");
                cliente.email = Console.ReadLine();
                Console.WriteLine(" CPF do cliente: ");
                cliente.cpf = Console.ReadLine();
            
                clienteList.Add(cliente);
                Salvar();
                Console.WriteLine("Cliente registrado com sucesso!");
            
                Console.WriteLine("Cadastro concluído, aperte 'Enter' para sair.");
                Console.ReadLine();

            }

            static void Listagem()
            {
                if(clienteList.Count > 0) //Leia-se: SE tem pelo menos 1 (um) cliente nessa lista, execute a função abaixo.
                {
                    Console.WriteLine(" [ LISTA DE CLIENTES ] ");

                    int i = 0; //contador para alimentar o ID a cada cliente cadastrado.

                    foreach (Cliente cliente in clienteList)
                    {
                        Console.WriteLine($" ID: {i}");
                        Console.WriteLine($" Nome: {cliente.nome}");
                        Console.WriteLine($" E-mail: {cliente.email}");
                        Console.WriteLine($" CPF: {cliente.cpf}");
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

            static void Remover()
            {
                Listagem();
                Console.WriteLine("Digite o ID do cliente que você quer remover: ");
                int id = int.Parse(Console.ReadLine());
                //validação do usuário
                if(id >= 0 && id < clienteList.Count) //o ID não pode ser um número maior que o número de clientes.
                {

                    clienteList.RemoveAt(id);
                    Salvar();

                }
                else
                {
                    Console.WriteLine("ID inválido, tente novamente.");
                    Console.ReadLine();
                }
            }
            
            static void Salvar() //função para salvar os clientes listados no arquivo no HD.
            {
                FileStream stream = new FileStream("clients.dat",FileMode.OpenOrCreate); 
                //Abrindo uma stream para escrever um arquivo binário, no modo Abertura/Criação
                BinaryFormatter encoder = new BinaryFormatter();
                //Para salvar os dados em formato binário dos arquivos
                
                encoder.Serialize(stream, clienteList); //utilizando o encoder para serializar a lista "clienteList" no arquivo.

                stream.Close();
            }

            static void Carregar()
            {
                FileStream stream = new FileStream("clients.dat",FileMode.OpenOrCreate); 
                
                try /*A estrutura "try-catch" serve para, no try, executarmos um bloco de código, de forma que se houver algum
                    erro, o programa não será parado.*/
                {
                    
                    BinaryFormatter encoder = new BinaryFormatter();
                
                
                    clienteList = (List<Cliente>)encoder.Deserialize(stream);

                    if(clienteList == null)
                    {
                        clienteList = new List<Cliente>();
                    }

                    
                }
                catch(Exception e) /*O erro visto no "try" será jogado aqui, no catch, para que tratemos dessa exceção.*/
                {

                    clienteList = new List<Cliente>(); 
                //caso haja algum erro jogado no catch, será criada uma nova lista para a var clienteList.

                }
                
                stream.Close();
            }
        }
    }
