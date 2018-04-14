using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Retangulo : Figura 
    {
        public double largura { get; set; }
        public double altura { get; set; }

        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public override double area()
        {
            return largura * altura;
        }

        public override double perimetro()
        {
            return 2 * (largura + altura);
        }
    }
}
