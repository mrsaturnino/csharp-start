namespace X {

    class Program
    {
        //Com o "enum", criamos um conjunto de constantes.
        enum Cor { Azul, Preto, Vermelho, Verde, Rosa }
        
        public static void Main(string[] args)
        {

        //Ao criarmos este tipo "cor", podemos utilizá-lo dentro de suas limitações.
        
        Cor corFavorita = Cor.Azul;

        Console.WriteLine(corFavorita);

        //O enum, como o proprio nome já sugere, enumera os valores definidos. Semelhante às Arrays, o enum começa com [0] [1] ...

        //Alterando um valor, os próximos itens após ele seguirão a mesma linha.
        //enum Cor  {Azul = 10, Preto (11), Vermelho(12), Rosa(13)}

        }
    }
}






