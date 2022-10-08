using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Calculadora
    {
        //funçao que automatiza a quantidade de parametros
        public static int Soma(params int[] numbers)
        {
            int soma = 0;
            for (int i = 0;i < numbers.Length; i++)
            {
                soma += numbers[i];
            }
            return Soma();
            
        } 
    }
}
