using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    abstract class Figura
    {

        public abstract double area();
        public abstract double perimetro();


        /* se Fosse trabalhar com Interface:
         
        namespace Example {
         
            interface Figura {
            
              double area();
              double perimetro();

            }
        }
         
        Assim também tiraríamos o override dos metodos area e perimetro das classes Retangulo e Triangulo, ficando:

        public double area(){
        
        return largura * altura;
        }


         */

    }
}
