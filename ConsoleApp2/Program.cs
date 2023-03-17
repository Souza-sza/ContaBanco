using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Dados de entrada iniciais */
            ContaBancaria conta;

            Console.WriteLine("Dados da conta");
            Console.Write("Numero da conta: ");
            int numeroconta = int.Parse(Console.ReadLine());

            Console.Write("Titular da conta: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Deseja fazer um deposito (S/N)?");
            char deposi = char.Parse(Console.ReadLine());
             if(deposi == 's' || deposi == 'S') 
            {
                Console.WriteLine("Qual o valor do Deposito ?");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroconta, nome, depositoInicial) ;
               
            }
            else
            {
                conta = new ContaBancaria(numeroconta, nome) ;
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.WriteLine("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine(conta);
        }

       
    }
}