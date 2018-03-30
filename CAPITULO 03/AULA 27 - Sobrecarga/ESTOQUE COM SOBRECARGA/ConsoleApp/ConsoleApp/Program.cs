using System;
using System.Globalization;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde;
            Produto P;
            
            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          
            P = new Produto(nome, preco);

            Console.WriteLine("Dados do produto: " + P);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que entraram no estoque: ");
            qtde = int.Parse(Console.ReadLine());
            P.realizarEntrada(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que saíram do estoque: ");
            qtde = int.Parse(Console.ReadLine());
            P.realizaSaidaEstoque(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P);

            Console.ReadLine();
        }
    }
}
