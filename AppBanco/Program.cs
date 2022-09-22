using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //no metodo deposita criar 3 depositos 1500,2500,4500 
            //no metodo adicionarLimite 1500
            //no método saca 7000
            //mostra o saldo de 3000
            //mostrar o limite de 1500
            //fazer a validação de saque indisponível
          
            Conta conta = new Conta();

            conta.Limite = 1500;

            conta.Deposita(1500);
            conta.Deposita(2500);
            conta.Deposita(4500);

            conta.Saca(15000);

            Console.WriteLine("Seu saldo é " + conta.ConsultaSaldoDisponivel());
            Console.WriteLine("Seu limite é " + conta.Limite);
            Console.ReadKey();

        }
    }
}
