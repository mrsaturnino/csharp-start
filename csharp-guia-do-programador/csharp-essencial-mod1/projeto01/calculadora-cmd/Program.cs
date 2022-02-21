namespace Cal
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }

        static void Main(string[] args)
        {


            bool escolheuSair = false;
            while(!escolheuSair)
            {
                Console.WriteLine("Olá, seja bem-vindo ao Cal!, Selecione uma das opções abaixo: ");
                Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisao\n4-Multiplicacao\n5-Potencia\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                
                switch (opcao)
                {
                    case Menu.Sair:
                        escolheuSair = true;
                    break;
                }

                Console.Clear();
            }
        }
    }
}