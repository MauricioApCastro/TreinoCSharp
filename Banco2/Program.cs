using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBanco c;

            Console.Write("Entre o número da conta:");
            int conta = int.Parse( Console.ReadLine());
            Console.Write("Entre o titular da conta:");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's')
            {
                Console.WriteLine("Entre o valora de deposito inicial");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBanco(conta, titular, depositoInicial);

                Console.WriteLine();
                Console.WriteLine("Dados da Conta:");
                Console.WriteLine(c);
            }
            else
            {
                c = new ContaBanco(conta, titular);
            }

                Console.WriteLine();
                Console.WriteLine("Entre um valor para depósito:");
                double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);              
                c.Depositar(quantia);
                Console.WriteLine(c);

                Console.WriteLine();
                Console.WriteLine("Entre um valor para saque:");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Sacar(saque);
                Console.WriteLine(c);


            

            
            Console.ReadKey();
        }
    }
}
