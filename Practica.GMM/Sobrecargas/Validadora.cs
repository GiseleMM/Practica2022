using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
    public class Validadora
    {
        public static bool ValidarRango(int valor, int max)
        {
            bool es = false;
            if (valor <= max)
            {
                es = true;
            }
            return es;
        }
        public static bool ValidarRango(int valor,  int max,int min)
        {
            bool es = false;
            if((Validadora.ValidarRango(valor,max) && valor>=min))
            {
                es = true;
            }
            return es;
        }
    }
}
