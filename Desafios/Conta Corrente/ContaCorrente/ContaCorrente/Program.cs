using System.Globalization;

namespace ContaCorrente
{
    class Program
    {
        public static void Main (string[] args)
        {
            

            Console.Write("Digite o numero da conta corrente: ");
            int conta = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Digite o nome do titular da conta corrente :");
            string titular =Console.ReadLine();

            Conta contacorrente = new Conta(conta, titular);

            Console.WriteLine("Havera deposito inicial na conta? S/N");
            string opcao =Console.ReadLine().ToUpper();

            if(opcao == "S")
            {
                Console.Write("Digite o valor do deposito: ");
                double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                contacorrente.Deposito(deposito);
            }
            Console.WriteLine(contacorrente);
            

            Console.Write("Entre um valor para deposito: ");
            double primeiroDeposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            contacorrente.Deposito(primeiroDeposito);
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine(contacorrente);

            Console.WriteLine("Digite o valor para saque ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contacorrente.Saque(valorSaque);
            

            if(contacorrente.VerificaSaldo())
            {
                Console.WriteLine("Saque autorizado, dados da conta atualizado: ");
                Console.WriteLine(contacorrente);
            }
            else
            {
                Console.WriteLine("Saque bloqueado o seu saldo ficaria negativo. Saldo: " + contacorrente.Saldo);
            }
        }
}
}