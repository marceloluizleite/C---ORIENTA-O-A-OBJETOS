using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Marcelo");
            lista.Add("Patrícia");
            lista.Add("Gabriel");
            lista.Add("Angela");

            lista.Remove("Angela");

            int pos = lista.FindIndex(x => x == "Marcelo");
            Console.WriteLine("A posição indicada é: " + pos);

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadLine();

        }
    }
}
