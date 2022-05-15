using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraParaTestUnitario
{
    public class Calculadora
    {
        public double Dividir(double dividendo,double divisor)
        {
            double resultado;
           
            if( divisor==0)
            {
                resultado = double.MinValue;
            }
            else
            {
                resultado = dividendo / divisor;
            }
           
            return resultado;
        }
    }
}
