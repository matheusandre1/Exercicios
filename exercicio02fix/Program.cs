using System;
using System.Globalization;
using exercicio02fix;

class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario();

        Console.WriteLine("Nome do Funcionário: ");
        funcionario.Nome = Console.ReadLine();
        Console.WriteLine("Salário Bruto: ");
        funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Imposto: ");
        funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine("Funcionário: " + funcionario);

        Console.WriteLine();
        Console.WriteLine("o Aumento Do Salário sera de quantos em porcentagem ?");
        double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        funcionario.aumentoSalario(porcentagem);

        Console.WriteLine("Dados atualizados do Funcionário " + funcionario.Nome);
        Console.WriteLine(funcionario);
    }
}


