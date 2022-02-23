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
                    
                    case Menu.Soma:
                        Soma();
                    break;

                    case Menu.Subtracao:
                        Sub();
                    break;
                }

                Console.Clear();
            }
        }

        static void Soma()
        {
            Console.WriteLine("Soma entre dois números");

            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());   
            
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            int result = a + b;

            Console.WriteLine($"O resultado da soma é: {result}"); 
            
            Console.WriteLine($"Aperte ENTER para voltar ao menu.");
            Console.ReadLine();

        }
        static void Sub()
        {
            Console.WriteLine("Subtração entre dois números");

            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());   
            
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            int result = a - b;
            
            Console.WriteLine($"O resultado da subtração é: {result}");
            
            Console.WriteLine($"Aperte ENTER para voltar ao menu.");
            Console.ReadLine();
        }
    }
}