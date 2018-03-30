using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TheBank
{
    class Conta
    {
        public string numeroDaConta { get; private set; }
        public string titular { get; set; }
        public double saldo { get; private set; }


        public Conta(string numeroDaConta, string titular, double saldo)
        {
            this.numeroDaConta = numeroDaConta;
            this.titular = titular;
            this.saldo = saldo;
        }

        // Usando um segundo construtor para uso de 2 parâmetros - saldo 0.0 no ELSE.
        public Conta(string numeroDaConta, string titular)
        {
            this.numeroDaConta = numeroDaConta;
            this.titular = titular;
            saldo = 0.0; // Não preciso usar o this, já que não é um parametro passado / Não obrigatório.
        }

        public void depositar(double quantia)
        {
            saldo += quantia;
        }

        public void sacar(double quantia)
        {
            saldo = saldo - quantia  - 5.0;
        }

        public override string ToString()
        {
            return "Conta: " +
                   numeroDaConta
                   + ", Titular: "
                   + titular
                   + ", Saldo: $ "
                   + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }   







    }
}
