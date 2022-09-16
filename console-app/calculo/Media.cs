using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo
{
    class Media
    {
        private static void Aluno()
        {

            Console.WriteLine("Digite o nome do aluno:");
            var nomeAluno = Console.ReadLine();
            Console.WriteLine("Digite as 3 notas do aluno " + nomeAluno);
            List<int> notas = new List<int> { };
            int totalNotas = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Digite a nota numero " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);

            }
            int mediaNotas = (totalNotas / 3);

            Console.WriteLine("A média do aluno " + nomeAluno + " é: " + mediaNotas);
            Console.WriteLine("Suas notas são:\n");
            foreach (int  nota in notas)
            {
                Console.WriteLine("Nota: " + nota + "\n");
           
            }
            
                
        }
    }
}
