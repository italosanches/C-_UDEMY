using System.Globalization;
namespace Notas_Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Name = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            double notaafinal = aluno.Nota1 + aluno.Nota2 + aluno.Nota3;
            Console.WriteLine("Nota final :"+notaafinal.ToString());

            if (notaafinal >= 60 )
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                double faltantes = 60 - notaafinal;
                Console.WriteLine($"Faltaram {faltantes.ToString("F2",CultureInfo.InvariantCulture)} ponto pontos");

            }

        }
    }
}