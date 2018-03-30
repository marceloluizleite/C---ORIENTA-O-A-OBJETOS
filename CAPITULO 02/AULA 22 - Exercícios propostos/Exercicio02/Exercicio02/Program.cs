using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario f = new Funcionario();
            double porcent;
            //porcent = 0;

            Console.WriteLine("Informe o nome do funcionário: ");
            f.nome = Console.ReadLine();

            Console.WriteLine("Informe o salário bruto do funcionário: ");
            f.salarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor de desconto: ");
            f.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("O funcionário se chama: " + f.nome + 
            " e seu salário líquido é de: " + f.salarioLiquido().ToString("F2",CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.aumentarSalario(porcent);
            Console.WriteLine();
            Console.WriteLine("Novo salário é: " + f.salarioBruto);

         

            Console.ReadLine();
        }
    }
}
