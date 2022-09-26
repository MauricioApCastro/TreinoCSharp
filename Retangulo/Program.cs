using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Entre a largura e a altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("AREA = "+retangulo.Area().ToString(("F2"), CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = "+retangulo.Perimetro().ToString(("F2"), CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = "+retangulo.Diagonal().ToString(("F2"), CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
