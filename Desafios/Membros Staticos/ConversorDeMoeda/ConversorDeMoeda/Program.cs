using System.Globalization;

namespace ConversorDeMoeda
{
    class Program
    {
        static void Main (string [] args)
        {
            Console.Write("Qual é a cotação do dolar?: ");
            double dolar =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quanto dolares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Console.WriteLine($"Valor a ser pago em reais {ConversorMoeda.Valor(dolar, quantidade).ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}