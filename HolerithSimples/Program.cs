using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolerithSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario;
            int qtdeHorasTrabalhada;
            double valorHoraTrabalho, salario;

            numeroFuncionario = int.Parse( Console.ReadLine());
            qtdeHorasTrabalhada = int.Parse(Console.ReadLine());
            valorHoraTrabalho = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salario = qtdeHorasTrabalhada * valorHoraTrabalho;

            Console.WriteLine("NUMBER = "+numeroFuncionario);
            Console.WriteLine("SALARY = U$ "+salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
