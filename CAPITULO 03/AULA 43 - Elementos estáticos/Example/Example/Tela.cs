using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Tela
    {
        public static Retangulo lerRetangulo()
        {
            Console.Write("Largura: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return new Retangulo(largura, altura);
        }

        public static Triangulo lerTriangulo()
        {
            Console.Write("Lado A: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado B: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado C: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return new Triangulo(a, b, c);
        }
    }
}
