using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06fix
{
     class Conversor
    {
        public static double iof = 6.0;

        public static double DolarpraReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total  * (iof / 100.0); 
        }
    }
}
