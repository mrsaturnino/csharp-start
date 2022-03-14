/*
A diretora de uma escola precisa de um programa C# que exiba uma mensagem de
boas vindas para os 10 alunos novos, utilizando a estrutura Foreach exiba a mesma
mensagem para todos os alunos novos.
*/

string[] alunos = {"Pedro", "Ana", "Charles", "Carlos", "Patrícia", "André", "Vanessa", "Isabela", "Leticia", "Raphaella"};

foreach (string aluno in alunos) //Leia: Para cada aluno dentro da array "Alunos" faça:
{
    Console.WriteLine($"Boas vindas, {aluno}!");
} //developed by mrsaturnino