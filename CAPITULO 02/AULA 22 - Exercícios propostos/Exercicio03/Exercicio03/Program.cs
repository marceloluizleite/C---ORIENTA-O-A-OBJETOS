using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            

            Console.WriteLine("Informe seu nome: ");
            a.nome = Console.ReadLine();

            Console.WriteLine("Informe a primeira nota:");
            a.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a segunda nota: ");
            a.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a terceira nota: ");
            a.nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final é: " + a.Media().ToString("F2", CultureInfo.InvariantCulture));

            if (a.Aprovado())
            {
                Console.WriteLine("Aprovado!!");
            }
            else
            {
                Console.WriteLine("Reprovado!!");
            }

            Console.WriteLine("Faltaram: " + a.FaltouQuanto().ToString("F2", CultureInfo.InvariantCulture) + " pontos");
            
            Console.ReadLine();
        
        }
    }
}
