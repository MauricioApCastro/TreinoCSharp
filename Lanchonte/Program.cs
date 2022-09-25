using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo, qtde;
            double valor = 0,total;

            string[] menu = Console.ReadLine().Split(' ');
            codigo = int.Parse(menu[0]);
            qtde = int.Parse(menu[1]);

            if (codigo == 1)
            {
                valor = 4.00;
            }
            else if (codigo == 2)
            {
                valor = 4.50;
            }
            else if (codigo == 3)
            {
                valor = 5.00;
            }
            else if (codigo == 4)
            {
                valor = 2.00;
            }
            else if (codigo == 5)
            {
                valor = 1.50;
            }
            total = valor * qtde;
            Console.WriteLine("Total: R$" + total.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }

        
    }
}
