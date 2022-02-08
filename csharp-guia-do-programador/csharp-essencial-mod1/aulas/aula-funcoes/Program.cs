//imagine que a chamada da função MultiDois, abaixo, esteja dentro da: static void Main(); {}
//porquê está.

MultiDois(10);


static void MultiDois(int num)
{
    int calc = (num * 2);
    Console.WriteLine(calc);
}

//Basicamente, na chamada da função "MultiDois", o valor que for colocado dentro do parênteses, será passado ao parâmetro "num" dela, multiplicado por 2 e exibido na tela.