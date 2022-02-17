/*
Crie um programa em C# que utilize uma Função chamada “ PrecoFinal ” que
ajuste em 25% a mais do valor inicial dos produtos:
● Chocolate: 30
● Refrigerante: 50
● Bolo: 45
● Sorvete: 60
● Pão: 15
exiba o resultado na tela.
*/

//Sim, eu fiz algumas modificações porque esses preços do exercício são absurdos.

namespace Venda 
{
    class Program
    {

        static void Main(string[] args)
        {

        Console.WriteLine("======================");
        Console.WriteLine("Produtos a Venda:");
        Console.WriteLine("======================");
        Console.WriteLine("Chocolate: R$5,00");
        Console.WriteLine("Refrigerante: R$6,00");
        Console.WriteLine("Bolo: R$20,00");
        Console.WriteLine("Sorvete: R$5,00");
        Console.WriteLine("Biscoito: R$2,00");
        Console.WriteLine("======================");

        PrecoFinal("Chocolate =", 5.0);
        PrecoFinal("Refrigerante =", 6.0);
        PrecoFinal("Bolo =", 20.0);
        PrecoFinal("Sorvete =", 5.0);
        PrecoFinal("Biscoito =", 2.0);

        }
        
        static void PrecoFinal(string produto, double valor)
        {
            double valorFinal = valor + (valor * 1/4); //curiosidade: multiplicar por 0,25 é o mesmo que dividir por 4.
            Console.WriteLine($"O valor reajustado do {produto} com a taxa é: {valorFinal}");
            //developed by mrsaturnino
        }
    }
}