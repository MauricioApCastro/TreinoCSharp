using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                List<string> listNomes = new List<string>();
                Console.WriteLine("Digite o nome da" + i + "ª pessoa");
                listNomes.Add (Console.ReadLine());
            }
               
            
            
            
        }
    }
}
