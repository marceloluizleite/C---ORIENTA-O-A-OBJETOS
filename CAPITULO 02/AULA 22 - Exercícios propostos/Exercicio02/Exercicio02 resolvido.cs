//Program
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
            f.aumentarSalario(porcent);

            Console.ReadLine();
        }
    }
}



// Funcionario:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Funcionario
    {
        public string nome;
        public double salarioBruto, desconto;
       

        public double salarioLiquido()
        {
            return salarioBruto - desconto;
        }

        public void aumentarSalario(double porcentagem)
        {
            salarioBruto = salarioBruto + (salarioBruto * porcentagem / 100.0);
        }
    }
}

