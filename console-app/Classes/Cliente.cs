using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app.Classes
{
    //criação da classe
    public class Cliente
    {
        /// <summary>
        /// construtor da classe
        /// </summary>
        /// <param name="telefone">telefone inteiro</param>
        public Cliente(int telefone)
        {
            this.Telefone = telefone.ToString();
        }
        /// <summary>
        ///construtor da classe
        /// </summary>
        /// <param name="_nome">Para obrigar a preencher o nome</param>

        public Cliente(string _nome)
        {
            this.Nome = _nome;
        }

        /// <summary>
        /// construtor sem parâmetros
        /// </summary>
        public Cliente()
        {

        }

       
       //definição de atributos
        public string Nome;
        public string Telefone;
        public string CPF;

        public void Gravar()
        {

        }
        //método de instância
        
        private static string caminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }
        

            //método estático
            public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            if (File.Exists(caminhoBaseClientes()))
                using (StreamReader arquivo = File.OpenText(caminhoBaseClientes()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        //ignora a primeira linha
                        i++;
                        if (i == 0) continue;
                        var clienteArquivo = linha.Split(';');
                        var cliente = new Cliente();
                        cliente.Nome = clienteArquivo[0];
                        cliente.Telefone = clienteArquivo[1];
                        cliente.CPF = clienteArquivo[2];

                        clientes.Add(cliente);
                    }
                }
           
            return clientes;
        }
        
    }
}
