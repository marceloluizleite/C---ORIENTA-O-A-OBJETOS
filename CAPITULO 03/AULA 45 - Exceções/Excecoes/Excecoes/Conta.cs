using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    class Conta
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public double saldo { get; set; }
        public double limiteDeSaque { get; set; }

        public Conta(int numero, string titular, double limiteDeSaque)
        {
            this.numero = numero;
            this.titular = titular;
            this.limiteDeSaque = limiteDeSaque;
            this.saldo = 0.0;
        }

        public void depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public void sacar(double valor)
        {
            saldo = saldo - valor;
        }
    }
}
