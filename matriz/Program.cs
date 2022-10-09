using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //numero de linha e colunas
            int num = int.Parse(Console.ReadLine());
            //cria a matriz
            int l, c;
            l = c = num;
            int[,] mat = new int[l, c];
            //popula a matriz
            //percorre a linha
            for (int i = 0; i < l; i++)
            {
                //le os dados que irão pra matriz
                string[] valores = Console.ReadLine().Split(' ');
                //percorre as colunas
                for (int j = 0; j < l; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine("Diagonal principal");

            //mostra a diagonal principal
            for (int i = 0; i < num; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();
            //mostra quantos numeros são negativos
            int count = 0;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Numeros negativos: " + count);

            Console.ReadKey();



        }
    }
}
