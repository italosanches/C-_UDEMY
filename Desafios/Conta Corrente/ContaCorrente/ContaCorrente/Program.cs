using System.Globalization;

namespace ContaCorrente
{
    class Program
    {
        public static void Main (string[] args)
        {
            Conta contacorrente;

            Console.Write("Digite o numero da conta corrente: ");
            int conta = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Digite o nome do titular da conta corrente :");
            string titular =Console.ReadLine();

            

            Console.WriteLine("Havera deposito inicial na conta? S/N");
            char opcao =char.Parse(Console.ReadLine().ToUpper());

            if(opcao == 'S')
            {
                Console.Write("Digite o valor do deposito: ");
                double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                contacorrente = new Conta(conta,titular,deposito);
                
            }
            else
            {
                contacorrente = new Conta(conta,titular);
            }
            Console.WriteLine(contacorrente);
            

            Console.Write("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            contacorrente.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizado:");
            Console.WriteLine(contacorrente);

            Console.WriteLine("Digite o valor para saque ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contacorrente.Saque(quantia);
            

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