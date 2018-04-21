using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
             Em nosso programa principal temos toda a lógica de saque e verificação
             na classe Program.cs o que não é o cenário ideal. Para isso utilizaremos no
             exemplo Excecoes_tratado o tratamento devido (Try / Catch) para exemplificar 
             o cenário correto.
             */

            Console.Write("Numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Limite de Saque: ");
            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta c = new Conta(numero, titular, limite);

            Console.WriteLine();
            Console.WriteLine("Informe um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.depositar(valorDeposito);
            Console.WriteLine("Novo saldo = R$ " + c.saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("Informe um valor para o saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (c.saldo < valorSaque)
            {
                Console.WriteLine("Não há saldo suficiente! Saque cancelado. ");
            }
            else if (valorSaque > c.limiteDeSaque)
            {
                Console.WriteLine("Valor do saque é superior ao limite da conta! Saque cancelado. ");
            }
            else
            {
                c.sacar(valorSaque);
                Console.WriteLine("Novo saldo = R$ " + c.saldo.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
