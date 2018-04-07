using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Quantos funcionários deseja cadastrar? ");
            N = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Dados do " + i + "º funcionário: ");
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Funcionario f = new Funcionario(cpf, nome, salario);
                lista.Add(f);
            }

            Console.WriteLine();
            Console.WriteLine("Digite o CPF do funcinário a ter aumento: ");
            string cpfBuscado = Console.ReadLine();

            int pos = lista.FindIndex(x => x.cpf == cpfBuscado);
            if (pos == -1)
            {
                Console.WriteLine("CPF não encontrado/inexistente!");
                
            }
            else
            {
                Console.Write("Digite o percentual de aumento: ");
                double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista[pos].AumentarSalario(porc);
            }

            Console.WriteLine();


            Console.WriteLine("Listagem atualizada de funcionarios: ");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.ReadLine();

        }
    }
}
