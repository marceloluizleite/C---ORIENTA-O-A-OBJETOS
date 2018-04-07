using System;
using System.Globalization;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Fornecedor f;
            Produto p;

            f = new Fornecedor("Samsung", "lojas@gmail.com", "(11)2141-0243");

            p = new Produto("TV", 1500.00, f);

            Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
