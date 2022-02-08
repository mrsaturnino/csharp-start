/*Crie um Programa em C# que, receba três números do usuário, informe na tela qual
é o MAIOR deles ou exiba se eles são iguais.*/

Console.WriteLine("Insira três números a seguir, e o programa irá informar qual deles é o maior ou se são iguais.");

Console.WriteLine("Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"O primeiro número digitado, '{num1}', é o maior número dos outros três digitados, informados abaixo.");
    Console.WriteLine($"Segundo número digitado: {num2}");
    Console.WriteLine($"Terceiro número digitado: {num3}");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine($"O segundo número digitado, '{num2}', é o maior número dos outros três digitados, informados abaixo.");
    Console.WriteLine($"Primeiro número digitado: {num1}");
    Console.WriteLine($"Terceiro número digitado: {num3}");
}
else if (num3 > num1 && num3 > num2)
{
    Console.WriteLine($"O terceiro número digitado, '{num3}', é o maior número dos outros três digitados, informados abaixo.");
    Console.WriteLine($"Primeiro número digitado: {num1}");
    Console.WriteLine($"Segundo número digitado: {num2}");
}
else
{
    Console.WriteLine("Os três números digitados são iguais.");
}
//developed by mrsaturnino