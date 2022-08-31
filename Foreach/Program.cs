using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
           string []nome = {"mauricio","danilo","Silvia"};
            foreach (string leitura in nome)
            {
                Console.WriteLine(leitura);
            }
        }
        
    }
}   
