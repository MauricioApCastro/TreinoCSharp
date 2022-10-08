using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculadora.Soma(5, 6);

            Console.WriteLine(s1);
            Console.ReadKey();

        }
    }
}
