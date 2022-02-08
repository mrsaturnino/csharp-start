string name;
char gen;
int age;
double height;
//Aqui eu criei todas as variáveis que irei utilizar durante o questionário.

Console.Write("Insert your name: ");
name = Console.ReadLine();
//Variavel "name" irá receber através do método ".ReadLine" o nome digitado pelo usuário.

Console.Write("Your gender is (M/F): ");
gen = char.Parse(Console.ReadLine());
//Por padrão, o ".ReadLine" recebe apenas strings. A função ".Parse" altera o tipo do valor que este ReadLine irá receber.

Console.WriteLine($"Hello, {name}!"); //Aqui utilizei interpolação de strings, em vez de concatenar, para melhor visualização do código.

//Como seria com a concatenação: ("Hello, "+ name + "!")

Console.WriteLine("Now, insert your age: ");
age = int.Parse(Console.ReadLine());

Console.WriteLine("To complete this form, insert your height: ");
height = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Your name: {name}");
Console.WriteLine($"Your age: {age}");
Console.WriteLine($"Your height: {height.ToString("F2")}");
Console.WriteLine();

    if (age > 18 && gen == 'F')
    {
        Console.WriteLine($"You're a WOMAN, your name is {name}, your height its {height} and you have {age} years.");
    }

    else if (age < 18 && gen == 'F')
    {
        Console.WriteLine($"You're a GIRL, your name is {name}, your height its {height} and you have {age} years.");
    }

    else if (age > 18 && gen == 'M')
    {
        Console.WriteLine($"You're a MAN, your name is {name}, your height its {height} and you have {age} years.");
    }

    else if (age < 18 && gen == 'M')
    {
        Console.WriteLine($"You're a BOY, your name is {name}, your height its {height} and you have {age} years.");
    }