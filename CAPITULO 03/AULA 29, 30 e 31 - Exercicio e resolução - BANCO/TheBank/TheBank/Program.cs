using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta x;
                       

            Console.WriteLine("Digite o número da conta: ");
            string numeroDaConta = Console.ReadLine();

            Console.WriteLine("Digite o nome do titular: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Haverá deposito inicial? (S/N): ");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'S' || ch == 's')
            {
                Console.WriteLine("Digite o valor do deposito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x = new Conta(numeroDaConta, titular, valorInicial);
            }
            else
            {
                x = new Conta(numeroDaConta, titular, 0.0);
            }

            Console.WriteLine();
            Console.WriteLine("Conta criada!");
            Console.WriteLine(x);

            Console.WriteLine();
            Console.WriteLine("Digite um valor para o depósito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.depositar(dep);

            Console.WriteLine();
            Console.WriteLine("Conta atualizada!");
            Console.WriteLine(x);

            Console.WriteLine();
            Console.WriteLine("Digite um valor para saque: ");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.sacar(saq);

            Console.WriteLine();
            Console.WriteLine("Conta atualizada!");
            Console.WriteLine(x);
                        
            Console.ReadLine();

          
        }
    }
}
