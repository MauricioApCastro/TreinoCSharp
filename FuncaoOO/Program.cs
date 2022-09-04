using System;

namespace FuncaoOO
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int escolha = 0;
           
            switch (escolha)
            {
                case 0:
                    mensagem();
                    int valor = int.Parse(Console.ReadLine());
                    break;
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
            }

        }

        public static void mensagem()
        {
            Console.WriteLine ("Digite uma das opções abaixo:" +
                     "\n     0 - Sair do Programa" +
                     "\n     1 - Para ler arquivos" +
                     "\n     2 - Para executar a tabuada" +
                     "\n     3 - Calcular média de alunos");
        }
    }
}


    


    

