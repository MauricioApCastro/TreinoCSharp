using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoDeErros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            

            try
            {
                Console.WriteLine("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Sua idade é " + idade + " anos");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Houve um erro, por favor informe uma idade válida, erro:"+ex.Message);
               
            }
           

            Console.WriteLine("Tratamento de Erro!");
            Console.ReadKey();
            
        }
    }
}
