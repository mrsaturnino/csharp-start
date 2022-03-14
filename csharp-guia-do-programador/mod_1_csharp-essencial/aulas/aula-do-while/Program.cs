//While e Do while são muito parecidos. Quase que gêmeos.

int contador = 0; 
while (contador < 20) 
{
    Console.WriteLine(contador); 
    Console.WriteLine("Rodando o while!");
    contador = contador + 1; 
}
Console.WriteLine("Final While!");
Console.WriteLine();

int contador2 = 0;
do
{
    Console.WriteLine(contador2);
    Console.WriteLine("Rodando o Do While!");
    contador2++;

}while(contador2 < 20); 
//Uma diferença entre o "while" e o "do while" é que este inicia pelo menos uma vez o seu comando mesmo que a condição seja falsa.
Console.WriteLine("Final Do While!");
