using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Propiedades");

            Personaje pj01 = new Personaje(1, "El ogro", 33, true);// creo objeto
            Personaje pj02 = new Personaje(2, "burro", 11, false);
            Personaje pj03 = new Personaje(3, "princesa", 100, true);
            //TRUCO: CTROL +T escribe el nombre de la clase y me lleva al codigo de  esa clase

            //uso de Propiedad get
            Console.WriteLine(pj01.Nombre);// sin llaves instancia.Propiedad
            pj01.Poder = 15; // escribo el codigo acciones rapidad generar propiedad y listo
            Console.WriteLine(pj01.MostrarPersonaje());

            Batalla superCombateFinal = new Batalla();
            superCombateFinal.AgregarPersonaje(pj01);
            superCombateFinal.AgregarPersonaje(pj02);


            // quiero acceder a la posicion 0 de la lista pero SuperCombate NO es una lista 
            // si no una clase que contiene una lista QUENO  es PUBLICA si la pongo public
            // piedo el encapsulamiento
            // tampoco podemos hacer que devuelva TODO la lista por que podrias modificarla
            //Personaje nuevoPj = superCombateFinal[0]; ESTO NO FUNCIONA falta una propiedad indexada
            // PROPIEDAD INDEXADA con una propiedad yo pueda accedr a un elemnto de la 
            // lista que tiene adentro de la clase (en este caso de la clase batalla)
            // vamos  a ir a batalla y vamos a generar una propiedad indexada
            Personaje pDeLista = superCombateFinal[0];
            Console.WriteLine(pDeLista.MostrarPersonaje());
            Personaje pDeLista02 = superCombateFinal["burro"];
                
            Console.WriteLine(pDeLista02.MostrarPersonaje());
            // si creo otra batalla puedo usar la  propiedad 
            // por que usamos this[int indice] al definir la propiedad
            //llAMADA seria batalla2[indice o string];

            // USO DEL SET del INDEXADOR
            superCombateFinal[0] = pj03;//     SET piso con el perosnaje la posicion  TIENE QUE EXISTIR EL INDICE 
            Personaje pdeLista03 = superCombateFinal[0];//    GET
            Console.WriteLine(pdeLista03.MostrarPersonaje());


        }
    }
}
