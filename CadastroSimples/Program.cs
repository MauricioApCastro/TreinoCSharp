using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura(mesma linha)");
            string[] dados = Console.ReadLine().Split(' ');
            string sobrenome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse((dados[2]), CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(produto);
            Console.WriteLine(dados[0]);
            Console.WriteLine(dados[1]);
            Console.WriteLine(dados[2]);
            
            
            Console.ReadLine();
        }
    }
}
