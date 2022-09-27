using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar?");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           double totalDolar = ConversorDeMoeda.DolarReais(cotacao, quantia);


            Console.WriteLine("Valor a ser pago em reais = " + totalDolar.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}
