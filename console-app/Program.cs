using calculo;
using console_app.Classes;
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
            // Menu.Criar();
            //retorna clientes
          var clientes = Cliente.LerClientes();

           var cliente = new Cliente("mauricio");
            cliente.Nome = "Mauricio";
            cliente.Telefone = "96610-6339";
            cliente.CPF = "170.792.438-40";
            cliente.Gravar();


            var cliente2 = new Cliente();
            cliente2.Nome = "Silvia";
            cliente2.Telefone = "99999-6639";
            cliente2.CPF = "123.454.789";
            cliente2.Gravar();
             var l = new List<string>();

        }
        
    }
}







