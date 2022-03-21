using System.Globalization;
namespace AlturaMedia 
{ 
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Digite a quantidade de pessoas para o calculo.");
            int pessoas = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double [] vetor = new double[pessoas];
            for (int i = 0; i < pessoas; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            double soma = 0.00;

            for (int i = 0; i < pessoas; i++)
            {
                soma += vetor[i];
            }
            double media = soma / pessoas;
             Console.WriteLine("Media = " + media.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}