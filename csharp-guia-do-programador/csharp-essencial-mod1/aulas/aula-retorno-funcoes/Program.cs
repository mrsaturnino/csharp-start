//imagine " static void Main(){} " abaixo.
//porque na verdade é.
//* * * comece a ler lá debaixo. * * *


int FunSoma = Soma(5, 2); 
//Os valores '5' e '2' foram passados para os parâmetros 'a' e 'b', que serão utilizados pela função.

//A variável "FunSoma" receberá todos os valores processados dentro da função "Soma" e os armazenará dentro de si.

Console.WriteLine(FunSoma);
//Por fim, os valores da função sendo armazenados dentro da variável "FunSoma" são exibidos.



//COMECE A LER O CODIGO A PARTIR DAQUI:

static int Soma(int a, int b) //Esta é uma função criada para processar e retornar o resultado de uma soma de dois valores inteiros.
{
    int resultadoSoma = a + b; //Esta variável, que pertence apenas à esta função, armazenará o resultado da soma.
    return resultadoSoma; //A variável será retornada ao fim da leitura da função.
}