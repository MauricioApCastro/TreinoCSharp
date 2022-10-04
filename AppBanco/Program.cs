using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Conta c = new Conta(123,"Maurício", 500);

            
            Console.WriteLine("Olá,"+c.Nome+" seu saldo em conta é: "+c.Numero);
            Console.WriteLine("Limite de saque: " + c.Limite);
            Console.WriteLine("Olá, seu saldo em conta é: " + c.Numero);
            Console.ReadKey();
        }
    }
}
