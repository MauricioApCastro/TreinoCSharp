using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diferenciador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d;

           a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            int diferenca = (a * b - c * d);
            Console.WriteLine("DIFERENÇA = "+diferenca);
            Console.ReadLine();
        }
    }
}
