using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraParaTestUnitario
{
    public static class StringExtendido
    {
        public static int ContarVocales(string palabra)
        {
            //int contador = 0;

            

                char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
                //    foreach (char item in palabra.ToLower())
                //    {
                //        if (vocales.Contains(item))
                //        {
                //            contador++;
                //        }

                //    }
                //}

                //          return contador;

                return ContarCaracteres(palabra, vocales);
         
           
        }

        public static int ContarCaracteres(this string palabra, char caracter) // metodo extendido
        {
            //int contador = 0;
            //if (palabra is not null)
            //{

            //    foreach (char item in palabra)
            //    {
            //        if(item == caracter)
            //        {
            //            contador++;
            //        }

            //    }
            //}

            //return contador;

            return ContarCaracteres(palabra, new char[] { caracter });
        }

        private static int ContarCaracteres(string palabra, char[] caracter)
        {
            int contador = 0;
            if (palabra is not null && caracter  is not null)
            {
                palabra=palabra.ToLower();

                foreach (char item in palabra)
                {
                    if (caracter.Contains(item))
                    {
                        contador++;
                    }

                }
            }
            else
            {
                throw new MiExcepcion();
            }

            return contador;
        }

    }
}
