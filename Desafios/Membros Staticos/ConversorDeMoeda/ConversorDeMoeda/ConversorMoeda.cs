using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMoeda
{
    internal class ConversorMoeda
    {
        public static double IOF = 0.06;
        public static double ValorReal;
        public static double ValorJuros;

        public static double Valor (double cotacao, double quantidade)
        {
            ValorJuros = (cotacao * quantidade) * IOF; 
            ValorReal = (cotacao * quantidade)+ ValorJuros;
            return ValorReal;
        }



    }
}
