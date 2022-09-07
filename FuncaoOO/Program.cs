using calculo;
using System;
using System.Collections.Generic;
using System.IO;
using Tela;

namespace FuncaoOO
{
    class Program
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
       

        static void Main(string[] args)
        {
            Menu.Criar();
            
        }
       


      
        
        
            public static void LerArquivo(int numeroArquivo)
            {
                string arquivoComCaminho = @"C:\Users\MAC\Desktop\Arquivos\arq" + numeroArquivo + ".txt";
                if (File.Exists(arquivoComCaminho))
                    using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                    {
                        string linha;
                        while ((linha = arquivo.ReadLine()) != null)
                        {
                            Console.WriteLine(linha);
                        }
                    }
                string arquivoComCaminho2 = @"C:\Users\MAC\Desktop\Arquivos\arq" + (numeroArquivo + 1) + ".txt";
                if ((File.Exists(arquivoComCaminho2)))
                {
                    Console.WriteLine("================");
                    LerArquivo(numeroArquivo + 1);
                }
            }

        
    }
}







