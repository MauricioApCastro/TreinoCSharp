using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());
            //instancia da lista
            List<Funcionario>list = new List<Funcionario>();    
            

            for (int i =1; i <= n; i++)
            {               
                Console.WriteLine("Funcionário #"+i);
                Console.Write("Id: ");
                int codigo= int.Parse( Console.ReadLine());
                Console.Write("Nome: ");
                 string nome =Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                //adicionar dados a lista
                list.Add(new Funcionario(codigo, nome, salario));
                Console.WriteLine();
            }
            Console.Write("Digite o código do funcionário que receberá aumento: ");
            int buscaId = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //busca o id informado na lista
            Funcionario f = list.Find(x => x.Id == buscaId);
            if(f != null)
            {
                Console.WriteLine("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                f.aumentoSalario(porcentagem);

            }
            else
            {
                Console.WriteLine("Esse código não existe");
            }
            Console.WriteLine();
            Console.WriteLine("Atualização de lista de funcionário:");
            //mostra a lista completa e atualizada
            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }





            Console.ReadLine();
           
        }
    }
}
