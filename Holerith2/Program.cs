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
            Funcionario f= new Funcionario();
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Funcionário: "+f);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário:" );
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(aumento);
            Console.WriteLine();

            Console.Write("Dados atualizados: "+f);
            Console.ReadKey();
        }
    }
}
