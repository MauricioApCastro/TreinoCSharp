using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorJurosDesconto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("informe o valor: ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("informe a porcentagem: ");
            double porcentagem = double.Parse(Console.ReadLine());
            double desconto = valor - (valor * (porcentagem / 100));
            double juros = valor + (valor * (porcentagem / 100));

            Console.WriteLine("R$"+valor + " com R$"+ porcentagem+ " de desconto é R$"+desconto);
            Console.WriteLine("R$"+valor + " com R$" + porcentagem + " de desconto é R$" + juros);
            Console.ReadLine();

        }
    }
}
