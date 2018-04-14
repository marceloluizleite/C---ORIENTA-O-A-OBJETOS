using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, Z, resultado;

            X = double.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());
            Z = double.Parse(Console.ReadLine());

            resultado = Util.NumeroMenor(X, Y, Z);

            Console.WriteLine("O MENOR NÚMERO É: " + resultado);

            Console.ReadLine();
        }
    }
}
