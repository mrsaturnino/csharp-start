namespace X{

    class Program{

            enum Opcao {Criar = 1, Deletar, Editar, Listar, Atualizar} //Criação dos itens do Menu que serão utilizados posteriormente; Criação de nomes enum são sempre no singular;
            // O índice "Criar" começa do 1 para que as opções correspondam.
        static void Main(string[] args){

            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar"); //Dica para quebra de linhas
            
            int index = int.Parse(Console.ReadLine()); //Variável que armazenará a opção escolhida pelo usuário que digitará um valor inteiro
            Opcao opcaoSelecionada = (Opcao)index; // Aqui, acontecerá o casting, que irá transformar este inteiro armazenado (index) em um índice do enum..

            Console.WriteLine(opcaoSelecionada);
            
            switch(opcaoSelecionada) //Criação do menu no console, onde poderão ser escolhidas as opções
            {
                case Opcao.Criar:
                    Console.WriteLine("Você escolheu o menu de criação.");
                break;

                case Opcao.Deletar:
                    Console.WriteLine("Você deseja deletar algo...");
                break;

                case Opcao.Editar:
                    Console.WriteLine("Você irá editar algo?");
                break;

                case Opcao.Listar:
                    Console.WriteLine("Aqui está uma listagem");
                break;

                case Opcao.Atualizar:
                    Console.WriteLine("O que deseja atualizar?");
                break;
                
                default:
                    Console.WriteLine("Selecione uma opção válida");
                break;
            }
        }
    }
}
