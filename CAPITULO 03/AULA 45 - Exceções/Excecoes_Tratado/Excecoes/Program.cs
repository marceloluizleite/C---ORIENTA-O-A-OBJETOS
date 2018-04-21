﻿using System;
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

            try
            {
                c.sacar(valorSaque);
                Console.WriteLine("Novo saldo = R$ " + c.saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (OperacaoException e)
            {
                Console.WriteLine(e.Message);
            }
          
            Console.ReadLine();
        }
    }
}
