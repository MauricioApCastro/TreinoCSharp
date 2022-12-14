using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Conta
    {
        //atributos
        //encapsulamento
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        //construtor com 2 argumentos
        public Conta(int numero, string titular)
        {
            Numero = numero;          
            Titular = titular;          
        }

        //construtor de 3 argumentos
        public Conta(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        //métodos
        public void Deposita(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta "+Numero+", Titular : "+Titular+", Saldo: $"+Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
