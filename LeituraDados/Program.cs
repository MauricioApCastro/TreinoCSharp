using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,idade;
            char ch,sexo;
            double n2,altura;
            string nome;

            n1 = int.Parse(Console.ReadLine());
            ch = char.Parse( Console.ReadLine());
            //leitura com o ponto
            n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            string[]dados = Console.ReadLine().Split(' ');
            nome = dados[0];
            sexo = char.Parse(dados[1]);
            idade = int.Parse(dados[2]);
            altura = double.Parse(dados[3],CultureInfo.InvariantCulture);

            Console.WriteLine(n1);
            Console.WriteLine(ch);
            //escrita com o ponto
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"{nome}  {sexo}  {idade}  {altura.ToString("F2",CultureInfo.InvariantCulture)} ");
            Console.ReadLine();

        }
    }
}
