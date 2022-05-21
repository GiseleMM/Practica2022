using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodoExtentidoFizzBuzz
{
    public static class IntExtendido
    {
        public static string FizzBuzz(this Int32 numero)
        {
            string salida = string.Empty;
            if(numero % 3==0)
            {
                salida += "Fizz";
            }
            if( numero % 5== 0)
            {
                salida += "Buzz";
            }
            if( string.IsNullOrEmpty(salida))
            {
                salida = numero.ToString();
            }

            return salida;
        }
    }
}
