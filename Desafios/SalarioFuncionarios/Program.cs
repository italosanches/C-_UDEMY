using System.Globalization;
namespace SalarioFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios voce ira registrar?");
            int n = int.Parse(Console.ReadLine());
            List<Funcionario> listaFuncionario = new List<Funcionario>();
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                num++;
                Console.WriteLine($"Funcionario #{num}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listaFuncionario.Add(new Funcionario(id, name, salary));

            }
            Console.Write("Entre com o ID do funcionario que ira receber aumento: ");
            int idAumento = int.Parse(Console.ReadLine());

            Funcionario funcionario = listaFuncionario.Find(x => x.ID == idAumento);


            if (funcionario != null)
            {
                Console.Write("Digite a porcentagem de aumento: ");
                funcionario.increaseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            }
            else
            {
                Console.WriteLine("ID não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada");

            foreach (Funcionario item in listaFuncionario)
                Console.WriteLine(item);

            Console.WriteLine("Deseja remover algum funcionario da lista? S/N");
            char opcao = char.Parse(Console.ReadLine().ToUpper());
            if (opcao == 'S')
            {
                Console.Write("Digite o ID de quem deseja remover: ");
                int idRemocao = int.Parse(Console.ReadLine());
                funcionario = listaFuncionario.Find(x => x.ID == idRemocao);
                if (funcionario != null)
                {
                    listaFuncionario.RemoveAll(x => x.ID == idRemocao);
                }

            };

            Console.WriteLine();
            Console.WriteLine("Lista atualizada");

            foreach (Funcionario item in listaFuncionario)
                Console.WriteLine(item);

        }
    }
}