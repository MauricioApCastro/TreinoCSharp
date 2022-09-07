using calculo;
using Calculo;
using FuncaoOO.Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA  = 3;
       

        public static void Criar()
        {
            while (true)
            {
                string mensagem = "Olá  Usuário, Bem vindo ao programa" +
                                   "\n" +
                                   "\n" +
                                   "   Utilizando programação funcional" +
                                   "\n" +
                                   "\n" +
                                   "\n" +
                                   "       Digite uma das opções abaixo:" +
                                   "\n         0 - Sair do programa " +
                                   "\n         1 - Para Ler Arquivos" +
                                   "\n         2 - Para executar a tabuada" +
                                   "\n         3 - Calcular media de alunos";

                Console.WriteLine(mensagem);
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == SAIDA_PROGRAMA)
                {
                    break;
                }
               
                else if (opcao == LER_ARQUIVOS)
                {
                    Ler.Arquivo(1);
                    Console.WriteLine("\n=================================================\n");
                }


                else if (opcao == TABUADA)
                {
                    Tabuada.Calcular();
                    Console.WriteLine("\n=================================================\n");
                }
                else if (opcao == CALCULO_MEDIA)
                {
                    Media.Aluno();
                    Console.WriteLine("\n=================================================\n");
                }           
            }
        }

    }
}
