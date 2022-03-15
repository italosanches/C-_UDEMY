using Desafio01;
using System.Globalization;

Salario funcionario1,funcionario2,calculadora;
funcionario1 =  new Salario();
funcionario2 = new Salario();
calculadora = new Salario();
float media;

Console.WriteLine("Digite o nome do primeiro funcionario");
funcionario1.nome =(Console.ReadLine());
Console.WriteLine("Digite o salario do primeiro funcionario");
funcionario1.salario = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
float salario1 = funcionario1.salario;

Console.WriteLine("___________");
Console.WriteLine("Digite o nome do segundo funcionario");
funcionario2.nome = (Console.ReadLine());
Console.WriteLine("Digite o salario do segundo funcionario");
funcionario2.salario = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
float salario2 = funcionario2.salario;

Console.WriteLine("_________________");
Console.WriteLine($"Dados do primeiro funcionario \n" +
    $"Nome: {funcionario1.nome} \n" +
    $"Salario: {funcionario1.salario.ToString("F2", CultureInfo.InvariantCulture)}");

Console.WriteLine("_________________");
media =calculadora.CalculoMedia(salario1,salario2);
Console.WriteLine($"Dados do segundo funcionario \n" +
    $"Nome: {funcionario2.nome} \n" +
    $"Salario: {funcionario2.salario.ToString("F2", CultureInfo.InvariantCulture)}");

    Console.WriteLine($"Media salarial {media.ToString("F2",CultureInfo.InvariantCulture)}" );


//Pessoa pessoa1, pessoa2;

//pessoa1 = new Pessoa();
//pessoa2 = new Pessoa();

//Console.WriteLine("Digite o nome da primeira pessoa");
//pessoa1.Nome = Console.ReadLine();
//Console.WriteLine("Digite a idade da primeira pessoa");
//pessoa1.Idade =int.Parse (Console.ReadLine());


//Console.WriteLine("Digite o nome da segunda pessoa");
//pessoa2.Nome = Console.ReadLine();
//Console.WriteLine("Digite a idade da segunda pessoa");
//pessoa2.Idade = int.Parse(Console.ReadLine());

//Console.WriteLine($"Dados da primeira pessoa \n " +
//    $"Nome : {pessoa1.Nome}\n" +
//    $"Idade : {pessoa1.Idade}");
//Console.WriteLine("____________________");
//Console.WriteLine($"Dados da segunda pessoa \n " +
//    $"Nome : {pessoa2.Nome}\n" +
//    $"Idade : {pessoa2.Idade}");