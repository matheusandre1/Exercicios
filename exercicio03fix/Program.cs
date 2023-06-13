using System;
using System.Globalization;
using exercicio03fix;

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();

        Console.WriteLine("Nome do Aluno: ");
        aluno1.Nome = Console.ReadLine();
        Console.WriteLine("Digite as Três notas do Aluno...");
        aluno1.nota1 = double.Parse(Console.ReadLine());
        aluno1.nota2 = double.Parse(Console.ReadLine());
        aluno1.nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Nota Final = " + aluno1.NotaFinal().ToString(),CultureInfo.InvariantCulture);

        if (aluno1.Aprovado())
        {
            Console.WriteLine("Aprovado!!");
        }
        else
        {
            Console.WriteLine("Reprovado!!");
            Console.WriteLine("Faltou " + aluno1.NotaqueFalta().ToString("F2",CultureInfo.InvariantCulture) + "Pontos");
        }



    }
}