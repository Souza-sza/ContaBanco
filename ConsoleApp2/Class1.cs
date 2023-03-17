using System.Globalization;
using System.Net.NetworkInformation;

using System;
namespace Course
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }   

        public ContaBancaria (int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public ContaBancaria(int numeroConta,string titular,double depositoinicial) : this( numeroConta,titular)
        {
            Deposito(depositoinicial);
        }
        
        public void Deposito(double quantia)
        {
             Saldo = Saldo + quantia;
        }

        public void Saque(double saque)
        {
            Saldo = Saldo - saque - 5;
        }

        public override string ToString()
        {
            return "Numero da conta "+ NumeroConta
                + " Titular da conta " + Titular + 
                " Saldo R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}