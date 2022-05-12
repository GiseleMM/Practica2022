using System;
using System.Collections.Generic;
namespace Herencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herencia");

            Publicacion p = new Publicacion("TTTTT", "yyyyy");
            Console.WriteLine(p.MostrarDatos());
            Libro l = new Libro("dsds", "hija",5);
            Console.WriteLine(l.MostrarDatos());

            Imprimir(p);
            Imprimir(l);// muestra al metodo de publicacion xq lo  estoy casteando a publicacion cuando lo paso  

            // puode guardar  en una  lista pero colocando la clase mas generica
            List<Publicacion> listaPublicaciones = new List<Publicacion>();
            listaPublicaciones.Add(p);
            listaPublicaciones.Add(l);
            foreach (Publicacion item in listaPublicaciones)
            {
                Program.Imprimir(item);
            }


            //Guardo en un puntero(referencia) de  publiccion una istancia de LIBRO
            Publicacion p2 = new Libro("boosj", "hhah", 7);
            Console.WriteLine(p2.MostrarDatos());// LLAMA al Meto MOstrarDATOS de PUBLICACION me dice el getType que es un libro pero aun asi llam al met de publicacion xq el compilador es el q llama al metodo
            Console.WriteLine(((Libro)p2).MostrarDatos());// lo CASTEO a la instancia original,  
            
        }


        static void Imprimir(Publicacion p)
        {
            if (p is Libro) // en tiempo de ejecucion determino de que tipo es
            {// para que llame  al metodo de libro que no es el mismo de la publicacion
                Console.WriteLine(((Libro)p).MostrarDatos()); // casteo xq el  compilador no sabe que adentro hay guardadda una instancia de Libro
            }
            else
            {
                Console.WriteLine(p.MostrarDatos());
            }
        }
    }
}
