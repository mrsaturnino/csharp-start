/*
Paulo é um pizzaiolo que precisa descobrir a área de uma circunferência para
conseguir fazer a pizza perfeita e ganhar o concurso nacional, Crie um programa C#
fazendo o uso das funções, que calcule a área de um círculo, recebendo o raio valor 30 desejado por Paulo.
*/

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {

            float area = CriaPizza(30); //Variavel para receber o valor retornado pela função "CriaPizza" com o valor do "raio" em 30 para o cálculo.
            Console.WriteLine("=================================================");
            Console.WriteLine($"Para criar a pizza perfeita,\na área deve ser de aproximadamente: {area}cm.");
            Console.WriteLine("=================================================");
        }

        static float CriaPizza(int raio)
        {
            float pi = 3.14f;
            float areaPizza = pi * (raio * raio);
            return areaPizza;
            //developed by mrsaturnino
        }


    }
}