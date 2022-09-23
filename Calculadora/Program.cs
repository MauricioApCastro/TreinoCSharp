using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double preco1, preco2, total,codigo1, quantidade1, codigo2, quantidade2; 

            string[] dados1 = Console.ReadLine().Split(' ');
            codigo1 = double.Parse(dados1[0]); quantidade1 = double.Parse(dados1[1]);preco1 = double.Parse(dados1[2]);
            string[] dados2 = Console.ReadLine().Split(' ');
            codigo2 = double.Parse(dados2[0]); quantidade2 = double.Parse(dados2[1]); preco2 = double.Parse(dados2[2]);

            total = ((quantidade1 * preco1) + (quantidade2 * preco2))/100;

            Console.WriteLine(String.Format("Valor a pagar: {0:C}", total));
            Console.ReadKey();

        }
    }
}
