using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();

            Console.Write("Quantas figuras você irá digitar? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Figura " + i+ " - triangulo ou retângulo (t/r)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'r')
                {
                    Figura f = Tela.lerRetangulo();
                    lista.Add(f);
                }
                else
                {
                    Figura f = Tela.lerTriangulo();
                    lista.Add(f);
                }

            }

            Console.WriteLine();
            Console.WriteLine("Area das figuras: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Figura " + (i+1) + ": " + lista[i].area().ToString("F1",CultureInfo.InvariantCulture));
            }

            /*
             
             Algo interessante neste exercício é que trabalhamos com POLIMOROFISMO de forma natural, pois o objeto
             se comportou de forma diferente pois foram instanciados de forma diferente. Estamos falando do objeto
             FIGURA que ora era TRIANGULO, ora RETANGULO, de acordo com a necessidade do usúario. 
             
             */

            Console.ReadLine();
        }
    }
}
