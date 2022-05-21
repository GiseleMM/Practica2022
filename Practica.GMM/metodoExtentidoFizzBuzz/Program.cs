using System;

namespace metodoExtentidoFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metodos  extendidos");
            //IMPORTATE SI ESTA EN UNA BIBLIOTECA TENGO QUE AGREGAR USING Y EL NAMESPACE
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(i.FizzBuzz());

            }
            string prueba = "Hola,Mundo";
            Console.WriteLine("cantidad de palabra: " +prueba.ContarPalabras());
        }
    }
}
