using System;
using System.Collections.Generic;

namespace SerializacionJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ClaseSerializadora<string>.rutaBase);
            //Console.WriteLine(  ClaseSerializadora<string>.rutaProyecto);
            //Console.WriteLine(ClaseSerializadora<string>.Escribir("Hola Mundo"));
            //Console.WriteLine(ClaseSerializadora<bool>.Escribir(true));

            //Console.WriteLine(ClaseSerializadora<Flor>.Escribir(new Rosa("Rosa","Trepadora",2.5F),"rosa.xml"));
            List<Flor> listaFlores = new List<Flor>()
            {
                new Rosa("Amarilla","Reina",1.0F),
                new Rosa("Roja","Terciopelo",1.5F)

            };
            Console.WriteLine(ClaseSerializadora<List<Flor>>.Escribir(listaFlores, "listaDeFlores.xml"));


            List<Flor> listaDeserializada = null;
            listaDeserializada = ClaseSerializadora<List<Flor>>.Leer("listaDeFlores.xml");// no flor sino lista
            foreach (var item in listaDeserializada)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
