/*
Alguns engenheiros precisam construir uma praça em um terreno que tem
formato Triangular, porém precisam saber qual a área exata desse terreno, Crie um
programa em C# com uma função que calcule a área de um triângulo, recebendo
uma base de 250 e uma altura de 350 como parâmetros.
*/

namespace Terreno
{   
    class Program
    {
        static void Main(string[] args)
        {
           int recebeArea = AreaTerreno(250, 350); /*Variável que recebe os valores retornados pela função, 
           com os valores passados aos parâmetros "base" e "altura".*/
           Console.WriteLine("=====================================");
           Console.WriteLine($"A área exata do terreno é de\n aproximadamente: {recebeArea} m².");
           Console.WriteLine("=====================================");

        }

        static int AreaTerreno(int Base, int Altura)
        {
            int calcArea = (Base * Altura) / 2;
            return calcArea;
        } //developed by mrsaturnino
    }
}