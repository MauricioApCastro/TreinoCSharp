using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);         
            Console.Write("Quantos dólares você vai comprar? ");
            double quantiaEmDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          
            double total = ConversorDeMoeda.Conversor(quantiaEmDolar,cotacao);
            Console.WriteLine("Valor a ser pago em reais = " +total.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
