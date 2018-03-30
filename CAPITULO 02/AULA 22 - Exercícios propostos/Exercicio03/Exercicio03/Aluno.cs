namespace Exercicio03
{
    class Aluno
    {
        public string nome;
        public double media,aprovado,nota1,nota2,nota3;


        public double Media()
        {
            return media = (nota1 + nota2 + nota3) / 3;
            
        }

        public bool Aprovado()
        {
            if (Media() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double FaltouQuanto()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - Media();
            }
        }

       
    }
}
