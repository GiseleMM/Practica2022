using System;

namespace Sabado7Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            string[] arrayPalabras = new string[4] { "pepe",null,"lali","dos"};
            try
            {
                Console.WriteLine(Program.DevolverPalabra(arrayPalabras, "ani"));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("jjjj Excepcion");
            }
            Console.WriteLine("aplicacion cerrando");



        }



        private static string DevolverPalabra(string[] array, string buscar)
        {
            string palabra = string.Empty;
            for (int i = 0; i < 5; i++)
            {
              
                    if (array[i]== buscar)
                    {
                        palabra = array[i];
                    }
            
               

            }
            return palabra;
        }
    }
}
