using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolar
{
    public static class ConversorDeMoeda
    {
        public static double iof = 6;
        public static double DolarReais(double cotacao, double quantia)
        {
            double total = cotacao * quantia;
            return total + total * iof / 100;
        }
    }
}
