using System;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribir en archivos");
            //GestorDeArchivos.Escribir("miArchivoPrueba.txt", "odio archivo", true);// true concatena si existe
            //GestorDeArchivos.Escribir("miArchivoPrueba.txt", "odio archivo 2", false); //sobreescribe si existe

            Console.WriteLine("Escribo archivo con sobrecarga de metodo Escribir q usa using");
            GestorDeArchivos.Escribir("ArchivoDOS.txt", "using solo Idiponsable, y no hay append sobreescribe");
            Console.WriteLine("\nLectura con ReadToEnd()");
            Console.WriteLine("Contenido de archivo:");
            Console.WriteLine(GestorDeArchivos.Leer("miArchivoPrueba.txt"));
            Console.WriteLine(GestorDeArchivos.Leer("ArchivoDOS.txt"));

            Console.WriteLine("\nClase Gestor de archivos de texto con implementacion IArchivos<T>");

            GestorArchivoTexto gta = new GestorArchivoTexto();
            gta.Escribir("IArchivo.txt", "clase que implementa Interface Generica IArchivo<T>", false);
            Console.WriteLine(gta.Leer("IArchivo.txt"));


        }
    }
}
