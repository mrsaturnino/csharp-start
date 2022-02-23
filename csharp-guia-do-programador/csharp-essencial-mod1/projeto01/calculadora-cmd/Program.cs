namespace Cal
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        //Aqui criamos um enum que comportará as opções do nosso menu.

        static void Main(string[] args)
        {


            bool Saida = false; 
            //Basicamente, esta variável começa como false para que, abaixo, o while possa inverter este valor com o operador "!".
            while(!Saida) //O motivo de inverter?: "Enquanto a saída for true, execute todo o código."

            //Veja no switch a opção "Menu.Saida"
            {
                Console.WriteLine("= = = Bem-vindo ao [C A L] = = =");
                Console.WriteLine("O 'C A L' é um programa que faz algumas operações matemáticas para você.");
                Console.WriteLine("Selecione alguma delas a seguir: ");
                Console.WriteLine("[1] Soma\n[2] Subtracao\n[3] Divisao\n[4] Multiplicacao\n[5] Potencia\n[6] Raiz\n[7] Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine()); 
                /*Aqui ocorre o casting para que a opção escolhida, na forma de um inteiro, seja transformado em um índice do enum,
                  que corresponde a uma opção do nosso menu.*/ 
                
                switch (opcao)
                {
                    case Menu.Sair:
                        Saida = true; /*Será atribuído "true" à variável "Saida", que até aqui está com o valor "false", em que este permanece permitindo a execução do while, ou seja, de todo o programa.*/ 
                    break;
                    
                    case Menu.Soma:
                        Sum(); //Chamando a função de acordo com a opção escolhida.
                    break;

                    case Menu.Subtracao:
                        Sub();
                    break;

                    case Menu.Divisao:
                        Div();
                    break;

                    case Menu.Multiplicacao:
                        Mult();
                    break;

                    case Menu.Potencia:
                        Pot();
                    break;

                    case Menu.Raiz:
                        Rai();
                    break;

                    default:
                        Console.WriteLine("Selecione uma das opções válidas.");
                    break;
                }

                Console.Clear();
            }
        }

        static void Sum()
        {
            Console.WriteLine("Soma entre dois números");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());   
            
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            int result = a + b;

            Console.WriteLine($"O resultado desta operação é: {result}"); 
            
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
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
            
            Console.WriteLine($"O resultado desta operação é: {result}");
            
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();
        }

        static void Div()
        {
            Console.WriteLine("Divisão entre dois números");

            Console.WriteLine("Digite o primeiro número: ");
            float a = float.Parse(Console.ReadLine());   
            
            Console.WriteLine("Digite o segundo número: ");
            float b = float.Parse(Console.ReadLine());

            float result = a / b;
            
            Console.WriteLine($"O resultado desta operação é: {result}");
            
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();
        }

        static void Mult()
        {
            Console.WriteLine("Multiplicação entre dois números");

            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());   
            
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());

            int result = a * b;
            
            Console.WriteLine($"O resultado desta operação é: {result}");
            
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();
        }

        static void Pot()
        {
            Console.WriteLine("Operação de potência");

            Console.WriteLine("Digite a base numérica: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o expoente: ");
            int expoNum = int.Parse(Console.ReadLine());

            int result = (int)Math.Pow(baseNum, expoNum); //A biblioteca "Math" nos ajuda com algumas operações já prontas.
            //O primeiro parâmetro é a base numérica, o segundo, é o expoente.
            
            Console.WriteLine($"O resultado desta operação é: {result}");
            
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();
        }

        static void Rai()
        {
            Console.WriteLine("Operação de raiz quadrada");

            Console.WriteLine("Digite o número que deseja saber o resultado de sua raiz quadrada: ");
            int radicando = int.Parse(Console.ReadLine());

            double result = Math.Sqrt(radicando);
            //Square root = raiz quadrada

            Console.WriteLine($"O resultado desta operação é: {result}");
            
            Console.WriteLine("Aperte ENTER para voltar ao menu.");
            Console.ReadLine();
        }
    }
}//developed by mrsaturnino