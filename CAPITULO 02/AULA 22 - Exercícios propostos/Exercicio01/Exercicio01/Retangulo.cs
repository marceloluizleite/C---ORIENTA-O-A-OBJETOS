using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    class Retangulo
    {
        public double largura, altura;

        public double area()
        {
            return largura * altura;
        }

        public double perimetro()
        {
            return 2.0 * (largura + altura);
        }

        public double diagonal()
        {
            return Math.Sqrt(largura * largura + altura * altura);
        }

    }
}
