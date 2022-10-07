using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco2
{
    class ContaBanco
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBanco(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBanco(int numero, string titular, double depositoInicial)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }

        public void Sacar(double quantia)
        {
            Saldo -= quantia + 5.0;
        }



        public override string ToString()
        {
            return "Conta " + Numero + ", Titular:" + Titular + ", Saldo:" + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
