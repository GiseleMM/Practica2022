using System;
using BibioltecaSabado23._4;
using System.Collections.Generic;

namespace Sabado23._4
{
    class Program
    {

    

        static void Main(string[] args)
        {
            #region APUNTE
            /*
             * HERENCIA
             * usamos la clase base para conformar otra clase derivada
             * 
             *   
             * 
             */
            #endregion

   
            Console.WriteLine("Hello World!");
            //lo correcto seria hacer la validacion en el form
            // y tambien haber una validacion de la clase en sino si luego paso 
            //la libreria nuestra aplicacion rompe

            //Animal animal = new Animal(1, "Lolo",EPelaje.Largo);

            //Console.WriteLine(animal.Mostrar());
            //Console.WriteLine($"precio corte:{ animal.PrecioCorte}");
            Perro p1 = new Perro(1,"Gordo", EPelaje.Corto, true);
            Console.WriteLine(p1.Mostrar());
            Gato g1 = new Gato(2, "Minino", EPelaje.Mediano);
            Console.WriteLine(g1.Mostrar());
            List<Animal> listaAnimal = new List<Animal>();
            listaAnimal.Add(g1);
            listaAnimal.Add(p1);
            foreach (Animal item in listaAnimal)
            {
                //if(item is Gato)
                //{ }
                //if(item.GetType( ) ==typeof(Gato))
                //{
                //    Console.WriteLine(item.Alimentarse());

                //}
                Console.WriteLine( item.Alimentarse());

            }
            






        }
    }
}
