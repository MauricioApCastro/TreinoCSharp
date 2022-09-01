using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        { int count = 0;
            List<string> a = new List<string>();
            while( count <= 5)
            {
                Console.WriteLine("Digite um nome");
                a.Add(Console.ReadLine());
                count++;
            }
            foreach(string nome in a)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
