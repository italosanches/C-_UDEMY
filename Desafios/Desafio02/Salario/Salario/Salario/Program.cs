using System.Globalization;
namespace Salario
{
    public class Program
    {
        static void Main (string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome=Console.ReadLine();
            Console.Write("Salario bruto: ");
            funcionario.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("____________________________");
            Console.WriteLine($"Funcionario: {funcionario}");
            Console.Write("Digite a porcetagem para aumentar o salario:");
            double imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(imposto);
            Console.WriteLine($"Dados atualizados: {funcionario}");
        }
    }
}