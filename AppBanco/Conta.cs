using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    class Conta
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Limite { get; set; }

        public Conta(int numero, string nome, double limite)
        {
            Numero = numero;
            Nome = nome;
            Limite = limite;  
        }

        
    }


    

}
