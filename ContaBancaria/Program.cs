using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.Write("Entre com o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?: ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's')
            {
                Console.Write("Entre o valora do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                c = new Conta(conta, nome, depositoInicial);
            }
            else
            {
                c = new Conta(conta, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposita(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.WriteLine("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

