using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificadorNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            num  =  int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO-NEGATIVO");
            }
            Console.ReadLine();
        }
    }
}
