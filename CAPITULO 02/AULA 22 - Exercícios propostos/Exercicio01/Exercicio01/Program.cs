using System;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             ENUNCIADO:
             Fazer um programa para ler os valores da largura e altura de um 
             retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e 
             diagonal. Usar uma classe Retangulo para implementar.
             
             */


            Retangulo Ret = new Retangulo();

            

            Console.WriteLine("Informe o valor para a largura: ");
            Ret.largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor para altura");
            Ret.altura = double.Parse(Console.ReadLine());

            Console.WriteLine("A área é de: " + Ret.area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("O perímetro é de: " + Ret.perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A diagonal é de: " + Ret.diagonal().ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();
        }
    }
}
