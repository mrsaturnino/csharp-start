/*
Guilherme é chefe do setor de T.I de sua empresa e precisa que você ajude-o a
criar um programa usando a linguagem C# que receba os chamados dos usuários
classificando e exibindo na tela o seu nível de urgência, sendo de 0-3 "BAIXO", maior
que 3 até 6 "MÉDIO", maior que 6 até 9 "ALTO", para os demais casos é considerado
"GRAVE".
*/

Console.WriteLine("================================================");
Console.WriteLine("Seja bem-vindo ao Sistema de Suporte ao Usuário");
Console.WriteLine("================================================");

Console.WriteLine("Escreva abaixo a sua solicitação: ");
string solicitacao = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Agora, classifique o nível de urgência da sua solicitação: ");
Console.WriteLine("\n0-3 Baixo \n3-6 Médio \n6-9 Alto");
int classificacao = int.Parse(Console.ReadLine());
Console.WriteLine();


if (classificacao <= 3)
{
    Console.WriteLine($"Solicitação: {solicitacao}");
    Console.WriteLine($"Nível de urgência: Baixo ({classificacao})");
}
else if (classificacao > 3 && classificacao <= 6)
{
    Console.WriteLine($"Solicitação: {solicitacao}");
    Console.WriteLine($"Nível de urgência: Médio ({classificacao})");
}
else if (classificacao > 6 && classificacao <= 9)
{
    Console.WriteLine($"Solicitação: {solicitacao}");
    Console.WriteLine($"Nível de urgência: Alto ({classificacao})");
}
else if (classificacao > 9)
{
    Console.WriteLine($"Solicitação: {solicitacao}");
    Console.WriteLine("Nível de urgência: Grave (+9)");
}
else
{
    Console.WriteLine("Digite um número válido!");
} //developed by mrsaturnino