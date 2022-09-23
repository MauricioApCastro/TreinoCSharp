using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaCirculo
{
    internal class Program
    {
        const double PI = 3.14159;
        static void Main(string[] args)
        {
            double raio = double.Parse( Console.ReadLine());
            double area = PI * (raio * raio);
            Console.WriteLine(String.Format("{0:00.0000}", area));
            Console.ReadKey();
        }
    }
}
