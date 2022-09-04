using System;
using System.IO;

namespace Função_Recursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            LerArquivo(1);
        }

        public static void LerArquivo(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\Users\MAC\Desktop\Arquivos\arq"+numeroArquivo+".txt";
            if(File.Exists(arquivoComCaminho))
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
    