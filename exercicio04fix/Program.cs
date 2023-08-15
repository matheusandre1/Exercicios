using System;
using System.Globalization;
using exercicio04fix;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calcular = new Calculadora();
            Console.WriteLine("Entre com o Valor do raio:  ");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double cirfunferencia = calcular.Circunferencia(raio);
            double volume = calcular.Volume(raio);

            Console.WriteLine("Circunferência : " + cirfunferencia.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume : " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Circunferência : " + calcular.pi.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
