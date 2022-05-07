using System;
using System.Collections;
using System.Collections.Generic;

namespace Colecciones2
{
    /* Colecciones genericas y no genericas */
    class Program
    {
        public static int ParaSort(int a, int b)
        {
            //if( a>b)
            //{
            //    return 1;
            //}
            //else
            //{
            //    if( a<b)
            //    {
            //        return -1;
            //    }
            //}
            //return 0;
            return b - a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Colecciones");

            //ARRAYLIST NO GENERICA
            ArrayList arrayList = new ArrayList();
            //.Add metodo para agrega al final
            arrayList.Add(12);
            arrayList.Add(false);
            arrayList.Add("ROSA");
            /*Admite cualquier tipo de dato*/

            //LIST GENERICA
            List<string> nombres = new List<string>();
            nombres.Add("Martes");
            nombres.Add("Clara");
            nombres.Add("Loli");
            Console.WriteLine($"nombre :{nombres[2]}");
            Console.WriteLine("recorro for");
            foreach (string item in nombres)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("recorro con for desde el fin al  principio");
            for(int i=nombres.Count-1;i>=0;i--)
            {
                Console.WriteLine(nombres[i]);
            }
            //otro metodo .Insert(indice,"elemento");
            Console.WriteLine("Insert(1,Pepe))");
            nombres.Insert(1,"PEPE");
            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }
            //.IndexOf() metodo para recuperar el indice de un elemento, la 1 ocurrencia
            Console.WriteLine("Obtengo el indice con indexof(objeto)");
            Console.WriteLine(nombres.IndexOf("PEPE"));
            //.Remove(obj)
            Console.WriteLine(".Remove(obj)");
            nombres.Remove("PEPE");
            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }


            //DICCCIONARIO
            //llave(sin repetir) y valor
            Dictionary<string, string> mascota = new Dictionary<string, string>();
            mascota.Add("Gordo", "ovejero");
            mascota.Add("Chucho", "ovejero");
            //como recorrer diccionario??
            Console.WriteLine("Diccionario recorro con KeyValuePair");
            foreach (KeyValuePair<string, string> item in mascota) 
            {
                Console.WriteLine($" mascota {item.Key} tipo: {item.Value}");
            }
            //puedo reccorrer solo la Key, o solo Value
            Console.WriteLine("puedo reccorre con la Key , por q esta indexado en base a la Key");
            Console.WriteLine($"Gordo: {mascota["Gordo"]}");
            Console.WriteLine("contains.Key o contains.Value");
            Console.WriteLine(mascota.ContainsKey("Gordo"));
            Console.WriteLine(mascota.ContainsValue("ovejero"));


            //QUEUE
            // FIFO 1 en etrar 1 en salir
            Queue<int> numeros = new Queue<int>();
            numeros.Enqueue(4);
            numeros.Enqueue(6);
            numeros.Enqueue(8);
            Console.WriteLine("Queue, agrego con .Enqueue()");
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            //esta coleccione NO esta indexada NO puedo acceder a un elemnto particular Ni por su nombre , ni su posicion
            Console.WriteLine("saco con .Dequeue");
            Console.WriteLine(numeros.Dequeue()); // saca el 1
            Console.WriteLine("saco pero N0 Elimino con .Peek()");
            Console.WriteLine(numeros.Peek() );

            Stack<char> letras = new Stack<char>();
            //LIFO ultimo en entrar 1 en salir
            letras.Push('A');
            letras.Push('B');
            letras.Push('C');
            Console.WriteLine("recorro con foreach STACK"  );
            foreach (var item in letras)
            {
                Console.WriteLine(item);// muestra el ultimo en ingresar
            }
            Console.WriteLine(".Pop()");
            Console.WriteLine($"Elimino con pop de la coleccio {letras.Pop()}");
            foreach (var item in letras)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(".Peek() no elimina ");
            Console.WriteLine($"saco pero NO elimino de la lista{ letras.Peek()}");
            foreach (var item in letras)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Ordenar Lista"  );
            List<int> listNumeros = new List<int>()
            {
                1,3,6,4,99,44,55,22
            };
            Console.WriteLine("Lista desordenada");
            foreach (var item in listNumeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Lista ordenada .Sort()");
            //orden ascendete por defecto
            listNumeros.Sort();
            foreach (var item in listNumeros)
            {
                Console.WriteLine(item);
            }
            // sort puede recibir una funcion criterio 0 ,1,-1
            listNumeros.Sort(ParaSort);
            foreach (var item in listNumeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
