using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprovacaoAluno
{
    class Aluno
    {
        public string Nome;
        public double Nota;


        public void SomaNota(double nota)
        {
            Nota += nota;          
        }
        

        public void Avaliador()
        {
            if(Nota >= 60.00)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60.00 - Nota) + " PONTOS");
            }
        }

       

    }
}
