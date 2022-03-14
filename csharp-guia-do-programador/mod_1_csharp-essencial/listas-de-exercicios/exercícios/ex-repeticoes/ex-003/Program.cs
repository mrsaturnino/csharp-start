/*
Crie um programa C# que exiba para os clientes de um mercado que está aberto
sob a condição do seu horário de funcionamento das 7h às 17h após esse horário
exibir uma mensagem de que se encontra fechado e indicando o horário de
funcionamento deste estabelecimento.
*/

namespace ExercicioRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("=========== Mercadinho Mau-Preço ===========");
            Console.WriteLine("================ 7h às 17h =================");

            for (int horario = 7; horario <= 17 ; horario++)
            {
                Console.WriteLine($"Estamos funcionando!\n Agora são {horario}h.");
            }

            Console.WriteLine();
            Console.WriteLine("Estamos fechados.\n Volte amanhã!");
        }
    }//developed by mrsaturnino
}