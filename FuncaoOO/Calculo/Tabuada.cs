using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Tabuada
    {
        public static void Calcular()
        {
            Console.WriteLine("Qual tabuada você deseja? ");
            int n = int.Parse(Console.ReadLine());

            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine("2 X " + i + "= " + (n * i));
                i++;
            }
        }
    }
}
