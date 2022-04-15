using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaV5
{
    public class Sobrecarga
    {
        public static int Sumar(int operando1, int operando2)
        {
            return operando1 + operando2;
        }
        public static int Sumar(int operando1,int operando2,int operando3)
        {
            return (operando1 + operando2 + operando3);
        }
        public static string Concatenar( string cadena1, string cadena2)
        {
            //return cadena1 +cadena2;
            return $"{cadena1} {cadena2}";
        }
        public static string Concatenar(string cadena1, string cadena2,int numero)
        {
            return $"{cadena1} {cadena2} {numero}";
            
        }
        public static string Mostrar(string  nombre,string apellido, int edad=0)
        {// de este modo si no  ingresa el usario una edad se usa el valor del parametro
            return $"nombre {nombre} apellido { apellido} edad {edad}";

        }
        // se puede reutilizar codigo de las sobrecarga entre elllas por ejemplo puedo suamar de 2
        // parametros en la de 3
    }
}
