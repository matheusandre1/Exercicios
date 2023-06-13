using System;
using ConsoleApp1;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do Produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + produto);
            Console.WriteLine();

            Console.Write("Digite o numero de produtos a ser adicionado: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados " + produto);

            Console.Write("Digite o numero de Produtos a ser Removido: ");
            quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidade);
            Console.WriteLine("Dados Atualizados: " + produto);


        }
    }
}