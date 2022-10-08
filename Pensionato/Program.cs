﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pensionato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospede[] hotel = new Hospede[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1) + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
                hotel[numeroQuarto] = new Hospede(nome, email);
             
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (hotel[i] != null)
                {
                    Console.WriteLine(i + ": " + hotel[i].Nome+", " + hotel[i].Email);
                }

            }
            Console.ReadKey();
        }
    }
}
