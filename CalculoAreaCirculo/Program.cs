using System;
using System.Collections.Generic;
using System.Globalization;
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
            //F4 controla a quantidade de casas decimais
            //CultureInfo.InvariantCulture ignora idioma utilizado
            Console.WriteLine(area.ToString("F4",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
