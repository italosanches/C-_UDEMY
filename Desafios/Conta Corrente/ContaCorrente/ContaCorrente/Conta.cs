using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaCorrente
{
    internal class Conta
    {
        private string _titular;
        public int ContaCorrente { get; private set; }
        public double Saldo { get; private set; }


        public Conta(int conta, string titular)
        {
            ContaCorrente = conta;
            _titular = titular;

        }
        public Conta(int conta, string titular, double depositoInicial) : this(conta, titular)
        {

            Deposito(depositoInicial);
        }

        public string Titular
        {
            get { return _titular; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _titular = value;
                }
            }
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -=saque + 5.00;

        }

        public bool VerificaSaldo()
        {
            if (Saldo >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public override string ToString()
        {
            return "Conta: " + ContaCorrente + "  Titular: " + _titular + "  Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
