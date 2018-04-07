using System;
using System.Globalization;

namespace ExercicioListas
{
    class Funcionario
    {
        public string cpf { get; private set; }
        public string nome { get; private set; }
        public double salario { get; private set; }
        
        public Funcionario(string cpf, string nome, double salario)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.salario = salario;
        }
        
        public void AumentarSalario(double porcentagem)
        {
            salario = porcentagem * salario / 100.0 + salario;
        }

        public override string ToString()
        {
            return cpf
                + ", "
                + nome
                + ", "
                + salario.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
