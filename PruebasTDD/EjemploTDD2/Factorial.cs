using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploTDD2
{
    public class Factorial
    {
        public int CalcularFactorial (int num)
        {

            int resultado = 1;
           if(num == 0)
            {
                return 1;
            }
            for (int i = 1; i<=num; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
