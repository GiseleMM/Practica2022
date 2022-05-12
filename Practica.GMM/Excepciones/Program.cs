using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exceptions ");

            try
            {
                string[] arrayDeNombres = new String[3] { "pepe", null, "sonia" };
                string rtaString = DevolverPalabra(arrayDeNombres, "sonia");
                Console.WriteLine("No se ejecuta si salta la exception y NO la maneja la funcion\n");
                Console.WriteLine($" puse try catch en la funcion y El metodo Devolverpalabra retorna correctamente {rtaString}\n");


            }
            catch(Exception e)// capturo el error que no manejjo la funcion Devolver palabra
            {
                Console.WriteLine("-----------------------Propiedad mensaje---------------------\n");
                Console.WriteLine(e.Message);
                Console.WriteLine("---------------------- Propiedad Source----------------------\n");
                Console.WriteLine(e.Source);
                Console.WriteLine("----------------------Metodo e.GetTYpe()----------------------\n");
                Console.WriteLine(e.GetType());
                Console.WriteLine("----------------------Propiedad StackTrace--------------------\n");
                Console.WriteLine( e.StackTrace );
            }
            Console.WriteLine("\n Debajo del catch");


        }

        private static string DevolverPalabra(string[] array, string palabraABuscar)
        {
            foreach (string item in array)
            {
                try
                {
                    if (palabraABuscar.ToLower() == item.ToLower())//NO manejo la excepcion busca en el main si hay un catch que la controle
                    {// si no pongo .toLower no salta el error por que el foreach permite null pero Yo no puedo devolver null
                        return item;
                    }
                }catch(Exception e)
                {
                    Console.WriteLine($"Manejo en  la funcion el error : {e.Message}  tipo:  {e.GetType()} STack:{e.StackTrace} ");
                }

              
            }

            return "no esta";
        }
    }
}
