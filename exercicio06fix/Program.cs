using System;
using System.Globalization;
using exercicio06fix;

namespace ConversorMoeda
{
    class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dolar?");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos Dolarés você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = Conversor.DolarpraReal( quantia, cotacao );

            Console.WriteLine("Valor pago em reais : " + resultado.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}