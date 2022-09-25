using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.Write("Dados do produto: "+ p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");         
            int qte = int.Parse(Console.ReadLine());          
            p.AdicionarProdutos(qte);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: "+p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            int remover = int.Parse(Console.ReadLine());
            p.RemoverProdutos(remover);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);





            Console.ReadLine();
        }
    }
}
