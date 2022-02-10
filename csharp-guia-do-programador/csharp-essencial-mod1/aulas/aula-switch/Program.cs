//O switch funciona praticamente da mesma maneira que as condicionais if, if else e else.

string corFavorita = "Verde"; //Criando uma variável para utilizar nas condições do switch.

switch(corFavorita){ //Abrimos o switch com a variável corFavorita guardando o valor "Verde".
    
    case "Vermelho": //Caso este valor guardado na variável seja "Vermelho", será apresentado no console a seguinte frase:
        Console.WriteLine("Sua cor favorita é vermelho!"); //frase
    break;

    case "Azul":
        Console.WriteLine("Sua cor favorita é azul!");
    break; //O break finaliza o caso após apresentar os comandos acima dele.

    case "Verde":
        Console.WriteLine("Sua cor favorita é verde!");
    break;
    default: //Funciona como o "else". Caso nenhuma das condições acima sejam atingidas, será esta a ser lida pelo console.
        Console.WriteLine("Não sei qual é a sua cor favorita.");
    break;
}
