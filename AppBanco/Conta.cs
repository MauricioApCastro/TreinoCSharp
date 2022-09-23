using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    //criar atributos saldo, limite, numero
    //criar métodos Deposita, Saca, AdicionarLimite,ConsultaSaldoDisponivel
    //criar validação saque indisponível
    class Conta
    {
        public double Saldo { get; private set; }
        public double Limite { get; set; }
        public int Numero { get; set; }

        public void  Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }
        public void Saca(double valor)
        {
            if (valor > ConsultaSaldoDisponivel())
            {
                Console.WriteLine("Saldo indisponível");
            }
            this.Saldo -= valor;
        }



    }
}
