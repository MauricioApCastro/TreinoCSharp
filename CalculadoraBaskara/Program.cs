using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBaskara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,delta,x1,x2;

            Console.WriteLine("Digite o valor de a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de c");
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b,2.0) - 4.0 * a * c;   
            x1 = (-b + Math.Sqrt(delta))/(2.0 * a);
            x2 = (b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("Delta: " + delta);
            Console.WriteLine("x1 : " + x1);
            Console.WriteLine("x2 :" + x2);
                
            Console.ReadLine();
            
        }
    }
}
