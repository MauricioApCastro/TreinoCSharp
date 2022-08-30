using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("       Escolha um opção      ");
            Console.WriteLine("       1- entrar             ");
            Console.WriteLine("       2- próxima tela       ");
            Console.WriteLine("       3- tela anterior      ");
            Console.WriteLine("       4- sair               ");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Você escolheu opção 1");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu opção 2");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu opção 3");
                    break;
                case 4:
                    Console.WriteLine("Você escolheu opção 4");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
