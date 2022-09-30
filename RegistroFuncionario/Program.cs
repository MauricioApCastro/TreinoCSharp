using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos funcionários serão registrados?");
            int n = int.Parse(Console.ReadLine());
            Funcionario[] vect = new Funcionario[n];

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Funcionário " + i);
                Console.Write("Código: ");
                double codigo = double.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Digite o código do funcionário que terá reajuste de salário: ");
            int p =int.Parse( Console.ReadLine());


        }
    }
}
