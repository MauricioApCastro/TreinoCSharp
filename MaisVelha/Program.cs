using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome :");
            pessoa.Nome =  Console.ReadLine();
            Console.Write("Idade :");
            pessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome :");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade :");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa.Idade > pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha :" +pessoa.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha :" + pessoa2.Nome);
            }
            Console.ReadLine();
        }
        
    }
}
