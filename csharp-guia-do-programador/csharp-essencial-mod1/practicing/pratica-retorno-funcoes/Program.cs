Console.WriteLine("Insira o primeiro valor: ");
int valor1 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o segundo valor: ");
int valor2 = int.Parse(Console.ReadLine());

int FunSoma = Soma(valor1, valor2);

Console.WriteLine($"O resultado da soma é: {FunSoma}");

static int Soma(int a, int b)
{
    int resultadoSoma = a + b;
    return resultadoSoma;
}