using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoMedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            int n = int.Parse(Console.ReadLine());
            Produto[]dados= new Produto[n];
            for (int i = 0;i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                dados[i] = new Produto{ Nome = nome,Preco = preco};
                soma += dados[i].Preco;
            }
            
            double media = soma / 3;
            Console.WriteLine("Preço Médio = "+media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
