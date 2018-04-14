using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosEstaticos
{
    class Util
    {
        public static double NumeroMenor(double X, double Y, double Z)
        {
            if (X < Y && Y < Z)
            {
                return X;
            }
            else if (Y < Z)
            {
                return Y;
            }
            else
            {
                return Z;
            }
        }
    }
}
