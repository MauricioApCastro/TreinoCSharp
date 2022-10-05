using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovacaoAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            for (int i = 0; i < 3; i ++) 
            {
                double nota = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                aluno.SomaNota(nota);
            
            }

            Console.WriteLine("NOTA FINAL ="+aluno.Nota.ToString("F2",CultureInfo.InvariantCulture));
            
            aluno.Avaliador();
            Console.ReadLine();
            
        }
    }
}
