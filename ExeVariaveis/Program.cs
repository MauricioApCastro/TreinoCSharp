using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritótio";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos");
            Console.WriteLine($"Computador, cujo preço é $ {preco1:F2} ");
            Console.WriteLine($"Mesa de escritório, cujo preço é $ {preco2:F2}\n\n");
            Console.WriteLine($"Registro: 30 anos de idade, código {codigo} e gênero: {genero}\n\n");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado(três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: {0} ",medida.ToString("F3",CultureInfo.InvariantCulture));


            Console.ReadKey();
        }
    }
}
