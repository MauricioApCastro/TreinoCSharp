using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio

{
    class Ler
    {
        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivo"];
            }
        public static void Arquivo(int numeroArquivo)
        {
          
            string arquivoComCaminho = caminhoArquivo ()+ "arq" + numeroArquivo + ".txt";
            if (File.Exists(arquivoComCaminho))
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            string arquivoComCaminho2 = caminhoArquivo() + "arq"  + (numeroArquivo + 1) + ".txt";
            if ((File.Exists(arquivoComCaminho2)))
            {
                Console.WriteLine("================");  
                Arquivo(numeroArquivo + 1);
            }
        }
    }
}
