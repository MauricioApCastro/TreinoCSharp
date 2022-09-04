using System;
using System.IO;

namespace Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Somar(1, 3));
            Tabuada();

        }
        public static int Somar(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public static void Tabuada()
        {
            int i = 0;
            while ( i <= 10)
            {
                Console.WriteLine("2 X " + i + "= " + (2 * i));
                i++;
            }
        }
        private static void LerArquivo(string arquivo)
        {
           
            {
                using (StreamReader arquivo = File.OpenText(file))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                       
                    }
                }
            }

            private void ProcessaLinha(object parametro)
            {
                string json = (string)parametro;
                // realiza o processamento
            }
        }

    }
}
