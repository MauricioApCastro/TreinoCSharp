using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse( Console.ReadLine());

            double[] pessoa = new double[n];

            for (int i = 0; i < n; i++)
            {
                pessoa[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);             
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += pessoa[i];
            }
            double res = soma / n;
            Console.WriteLine("Altura média é: "+res.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
