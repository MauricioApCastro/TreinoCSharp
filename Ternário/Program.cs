using System;

namespace Ternário
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um número");
            int num = int.Parse(Console.ReadLine());
            string numero = (num % 2 == 0 ? "é par":"é impar");
            Console.WriteLine(numero);
        }
    }
}
