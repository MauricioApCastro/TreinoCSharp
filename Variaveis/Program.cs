using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade?");
            int idade =int.Parse( Console.ReadLine());
            Console.WriteLine("Qual a sua altura?");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o seu sexo?");
            char sexo = char.Parse(Console.ReadLine());
            bool corretas = true;
            bool erradas = false;

            Console.WriteLine("Seu nome é " +nome);
            Console.WriteLine("Sua idade é " + idade); 
            Console.WriteLine("Sua altura é " + altura);
            Console.WriteLine("Você é do sexo " + sexo);
            Console.WriteLine("Todas as infomações estão corretas?" + corretas);
            Console.WriteLine("Todas as infomações estão erradas?" + erradas);
        }
    }
}
