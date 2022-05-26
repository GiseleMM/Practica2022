using System;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribir en archivos");
            GestorDeArchivos.Escribir("miArchivoPrueba.txt", "odio archivo", true);// true concatena si existe
            //GestorDeArchivos.Escribir("miArchivoPrueba.txt", "odio archivo 2", false); //sobreescribe si existe
        }
    }
}
