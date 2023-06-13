using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03fix
{
    internal class Aluno
    {
        public  string Nome { get; set; }
        public double nota1, nota2, nota3;

        public double NotaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaqueFalta()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.00 - NotaFinal();
            }
        }

    }
}
