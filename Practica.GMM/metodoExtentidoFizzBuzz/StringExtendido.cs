using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodoExtentidoFizzBuzz
{
    public static class StringExtendido
    {
        public static int ContarPalabras(this string texto)
        {
            int cantidad = 0;
            if(string.IsNullOrEmpty(texto))
            {
                cantidad = -1;
            }
            else
            {
                cantidad = texto.Split(new char[] { ',', '.', '-', ' ' }).Length;
            }
            return cantidad;
        }
    }
}
