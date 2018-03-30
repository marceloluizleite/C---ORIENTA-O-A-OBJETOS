using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03Refatorado
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            a.aluno = Console.ReadLine();

            a.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a.Aprovado())
            {
                Console.WriteLine(a.aluno + ", VOCÊ FOI APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine(a.aluno + ", Faltaram: " + a.QuantoFaltou().ToString("F2", CultureInfo.InvariantCulture)
                    + " pontos.");
            }

            Console.ReadLine();
        }
    }
}
