/*Crie um Programa em C# que receba três números do usuário, informe na tela qual
é o MENOR deles ou exiba se eles são iguais.*/

Console.WriteLine("Insira três números a seguir. O programa informará qual deles é o menor ou se são iguais.");

Console.WriteLine("Informe o primeiro: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o terceiro: ");
int num3 = int.Parse(Console.ReadLine());

if (num1 < num2 && num1 < num3)
{
    Console.WriteLine($"O primeiro valor, '{num1}', é o menor número dos três abaixo que você digitou.");
    Console.WriteLine($"Segundo valor digitado: {num2}");
    Console.WriteLine($"Terceiro valor digitado: {num3}");
}
else if (num2 < num1 && num2 < num3)
{
    Console.WriteLine($"O segundo valor, '{num2}', é o menor número dos três abaixo que você digitou.");
    Console.WriteLine($"Primeiro valor digitado: {num1}");
    Console.WriteLine($"Terceiro valor digitado: {num3}");
}
else if (num3 < num1 && num3 < num2)
{
    Console.WriteLine($"O terceiro valor, '{num3}', é o menor número dos três abaixo que você digitou.");
    Console.WriteLine($"Primeiro valor digitado: {num1}");
    Console.WriteLine($"Segundo valor digitado: {num2}");
}
else
{
    Console.WriteLine("Os três números digitados são iguais.");
}
//developed by mrsaturnino