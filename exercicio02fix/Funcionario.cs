using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02fix
{
    internal class Funcionario
    {
        public string Nome { get; set; }

        public double SalarioBruto { get; set; }

        public double Imposto { get; set; }


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void aumentoSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto + porcentagem / 100);
        }

        public override string ToString()
        {
            return Nome + ", R$ " + SalarioBruto.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
