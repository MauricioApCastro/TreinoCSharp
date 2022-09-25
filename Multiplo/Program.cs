using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string[] numeros = Console.ReadLine().Split(' ');
            int num1 = int.Parse(numeros[0]);
            int num2 = int.Parse(numeros[1]);

            if ((num1 % num2 == 0)||(num2 % num1 == 0))
            {
                Console.WriteLine("São Múltiplos");
            }
            else
            {
                Console.WriteLine("Não São Múltiplos");
            }

            Console.ReadLine();

        }
    }
}
