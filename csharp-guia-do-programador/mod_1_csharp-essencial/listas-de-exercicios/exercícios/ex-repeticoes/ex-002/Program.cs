/*
Crie um programa C# usando as estruturas de repetição que contabilize a
velocidade de um carro de fórmula 1, sem ultrapassar o limite de 200 Km/h permitido
na pista, exiba uma mensagem no final informando que chegou no limite.
*/

namespace ExercicioRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int velocimetro = 0; velocimetro < 200; velocimetro++)
            {
                Console.WriteLine($"O carro está a {velocimetro}Km/h!");
            }

            Console.WriteLine("O carro atingiu a velocidade máxima!!!");

        } //developed by mrsaturnino
    }
}