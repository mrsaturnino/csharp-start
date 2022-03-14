namespace aulaEscopo 
{ 
    class Program //Nesse caso, a classe "Program" é o nosso escopo global.
    {
        static string meuNome = "Andre"; //Estas variáveis podem ser acessadas por qualquer função dentro do escopo da classe "Program".
        static string meuSobrenome = "Saturnino";
        
        //Quando declaramos uma variável no escopo global, ela só poderá ser acessada por outras funções caso seja do mesmo tipo (static, nesse caso).

        static void Main(string[] args) 
        {
            Console.WriteLine(meuNome); //Acessando a var do escopo global.
            
            FuncaoTeste(); //Chamando a função abaixo que também está acessando uma var do escopo global.
            
            string testeVar = "Hello"; //Tente acessar esta variável a partir de outra função. (ênfase no "tente").
        }

        static void FuncaoTeste()
        {
            Console.WriteLine(meuSobrenome); //Acessando a var do escopo global.

            //Console.WriteLine(testeVar);
        }
    }
}