using System.Globalization;
namespace EstoqueProduto
{
    class Pedido
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com os ddos do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque:");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produto produto = new Produto(nome, preco, quantidade);
            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {produto}");
            Console.WriteLine();
            Console.Write("Digite a quantidade que entrara em estoque:");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);
            Console.WriteLine("_________________________");
            Console.WriteLine("Dados atualizados do produto: " + produto);
            Console.WriteLine("__________________________");
            Console.WriteLine("Digite a quantidade que saira de estoque");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);
            Console.WriteLine("____________________________");
            Console.WriteLine("Dados atualizados com a saida: " + produto);
        }
    }
}