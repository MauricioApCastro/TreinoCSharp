using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holerith2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Salário bruto: ");
            funcionario.SalarioBruto =double.Parse( Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Funcionario: " + funcionario);

            Console.ReadKey();
        }
    }
}
