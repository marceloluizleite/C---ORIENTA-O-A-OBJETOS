using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03Refatorado
{
    class Aluno
    {
        public string aluno;
        public double nota1, nota2, nota3;

        public double NotaFinal()
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double QuantoFaltou()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}
