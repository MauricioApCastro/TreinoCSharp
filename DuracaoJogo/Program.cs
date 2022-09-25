using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuracaoJogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int duracao;
            string[] numeros = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(numeros[0]);
            int horaFinal = int.Parse(numeros[1]);

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            Console.ReadLine();
        }

    }
}

