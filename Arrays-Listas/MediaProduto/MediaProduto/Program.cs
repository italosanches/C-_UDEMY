using System.Globalization;
namespace MediaProduto
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Digite a quantidade de produtos");
            int n = int.Parse(Console.ReadLine());
            Product[] produtos = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o valor do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;

                produtos[i] = new Product(nome, price);
            }
            double soma = 0.00;
            for (int i = 0; i < n; i++)
            {
                 soma += produtos[i].Price;
            }
            double media = soma / n;
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}