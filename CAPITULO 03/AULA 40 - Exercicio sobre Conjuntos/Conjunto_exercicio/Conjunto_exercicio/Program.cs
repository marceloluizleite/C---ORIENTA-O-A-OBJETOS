using System;
using System.Collections.Generic;

namespace Conjunto_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.WriteLine("Quantos alunos possuem o curso A? ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código dos alunos do curso A: ");
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.WriteLine("Quantos alunos possuem o curso B? ");
            N = int.Parse(Console.ReadLine());                            
            Console.WriteLine("Digite o código dos alunos do curso B: ");
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }

            Console.WriteLine("Quantos alunos possuem o curso C? ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código dos alunos do curso C: ");
            for (int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }

            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);

            Console.WriteLine("Total de alunos: " + Novo.Count);
            Console.ReadLine();
        }
    }
}
