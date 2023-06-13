using System;
using System.Globalization;
using exercicio01fix;



class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo();

        Console.WriteLine("Digite as entradas de Altura e Largura");
        retangulo.Altura= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Area = " + retangulo.Area().ToString(CultureInfo.InvariantCulture));
        Console.WriteLine("Perimetro = " + retangulo.Perimetro().ToString(CultureInfo.InvariantCulture));
        Console.WriteLine("Diagonal = " + retangulo.Diagonal().ToString(CultureInfo.InvariantCulture));
    }
}

