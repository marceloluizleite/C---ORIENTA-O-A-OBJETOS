using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
               Fazer um programa para ler um número inteiro N e a altura de N pessoas. 
               Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
               pessoas.
            */

            double[] vet;
            double soma, media;
            int N;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = soma + vet[i];
            }

            media = soma / N;

            Console.WriteLine("ALTURA MÉDIA = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
