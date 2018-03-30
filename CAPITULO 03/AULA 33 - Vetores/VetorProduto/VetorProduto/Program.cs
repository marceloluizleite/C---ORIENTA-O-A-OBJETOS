using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N Produtos.
             Armazene os N produtos em um vetor. Em seguida, mostrar o preço médio dos produtos.             
             
             */

            Produto[] vet;
            double soma, media;
            int N;

            N = int.Parse(Console.ReadLine());
            vet = new Produto[N];

            for (int i = 0; i < N; i++)
            {
                String nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto(nome, preco);
            }

            soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + vet[i].preco;
            }

            media = soma / 3;

            Console.WriteLine("PREÇO MÉDIO = R$ " + media.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
