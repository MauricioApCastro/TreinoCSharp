using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            do
            {
                Console.WriteLine(numero);
                numero++;
            }
            while (numero <= 5);
        }
    }
}
