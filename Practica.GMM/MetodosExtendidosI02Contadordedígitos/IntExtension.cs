using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtendidosI02Contadordedígitos
{
    public static class IntExtension// voy a crear un metodo extendido por eso la clase y metodo debe ser estatico
    {
        public static int ContarCantidadDeDigitos(this long numero )// Int64 es lo mismo q long
        {
            //bool esNegativo = false;
            string numeroString = numero.ToString();
            //for (int i = 0; i < numeroString.Length; i++)
            //{
            //    if( i==0 && numeroString[i]== '-')
            //    {
            //        esNegativo = true;
            //    }
            //}
            //if( esNegativo)
            //{
            //    return numeroString.Length - 1;
            //}
            //return numeroString.Length;
            numeroString = numeroString.Replace("-", "");
            return numeroString.Length;
        }
    }
}
