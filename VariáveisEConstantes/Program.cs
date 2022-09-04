using System;

namespace VariáveisEConstantes
{
    class Program
    {
        public const int SAIDA_PROGRAMA = 1;
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("Digite 1 para sair do programa");
                int numero = int.Parse(Console.ReadLine());
                if (SAIDA_PROGRAMA == numero)
                {
                    break;
                }
            }
        }
    }
}
