int contador = 0; //Começamos com o nosso contador a partir do zero.

while (contador < 20) //Leia: Enquanto a variável contador for menor que 20, faça abaixo:
{
    Console.WriteLine(contador); //vai exibir o valor do contador cada vez que a repetição acontecer
    Console.WriteLine("Rodando o while!");
    contador = contador + 1; //Será adicionado +1 a cada repetição. Chegando até 20, o console irá imprimir "Fim do While"

    //contador++; também é o mesmo que contador = contador + 1;
}
Console.WriteLine("Fim While!");