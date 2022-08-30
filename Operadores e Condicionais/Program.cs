using System;

namespace Operadores_e_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um número");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("O número é par");

            }
            else
            {
                Console.WriteLine("O número é impar");
            }
        }
    }
}
