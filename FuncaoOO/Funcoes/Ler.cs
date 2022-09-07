using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoOO.Funcoes
{
    class Ler
    {
        public static void Arquivo(int numeroArquivo)
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
                Arquivo(numeroArquivo + 1);
            }
        }
    }
}
