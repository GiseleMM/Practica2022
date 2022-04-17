using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {

            //            -------------------------------COLECCIONES------------------------------------------------------
            //Las colecciones son objetos especializados en almacenar, organizar y administrar gran cantidad de datos.
            //Características tamaño dinámico, implementación IEnumerables, copiar su contenido a un array(base 0), indexación base cero
            //Matrices.


 /*ARRAYS*/
            int[] numeros;
            numeros = new int[4];

            numeros[0] = 1;
            numeros[1] = 33;
            numeros[2] = 12;
            numeros[3] = 91;
            /*recorrer el array*/
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"indice: {i} valor: { numeros[i]}");
            }
            /*recorro con el foreach */
            foreach (int item in numeros)
            {
                //recorro  sin importar el indice
                // puedo recorrer objetos
                Console.WriteLine(item);
            }

            Auto[] autos = new Auto[3];//creo la lista de autos
            autos[0] = new Auto("2323", "dsada");// creo cada objeto auto
            autos[1] = new Auto("6666", "SSade");
            autos[2] = new Auto("8555", "owdu");// si pongo[7] rompe el foreach




            foreach (Auto item in autos) // cambiar el var de tab por defecto
            {//recorro pero si no hay nada comoes un tipo de refrencia
                // tiene  null y si llamamos algun metodo rompe
                if (item is not null)
                {
                    Console.WriteLine(item.MostrarAuto());
                }
            }

 /*MATRICES*/
            int[,] matriz = new int[3, 2] { { 1, 2 }, { 2, 4 }, { 2, 5 } };
            foreach (int item in matriz)
            {
                Console.WriteLine(item);//esto muestra todos los elementos
            }
 /*ARRAY DE ARRAY */
            // array donde cada elemento es un array
            int[][] matricesMultidimensionales = new int[3][];//array de 3 filas
            matricesMultidimensionales[0] = new int[] { 1, 3 };
            matricesMultidimensionales[1] = new int[] { 5, 43, 2, 4 };
            matricesMultidimensionales[2] = new int[] { 7, 2 };
            //puedo acceder a un elemnto indicando indice
            Console.WriteLine(matricesMultidimensionales[0][0]);


 /*COLECCIONES GENERICAS y NO GENERICAS*/
            //las NO genericas no cientas con seguridad de tipo
            //las genericas todos los elementos de la coleccion tienen el mismo tipo de datos
            
            
            /*         LIstas           */
            List<string> nombres = new List<string>(); // entre<> el tipo de los elemnetos de la colleccion
            //todas las colleciones son objetos y hay q instansiarlos en base cero
           
            //AGREGAR
            nombres.Add("lautaro");// cree una nueva  posicion en la lista con  metodo Add
            nombres.Add("Leonel");
            nombres.Add("lali");
            nombres[1] = "Rosa";// puedo sobreescribir con el indices que cree con Add pero si intento ingresar nombres[10]="hiid" NO Funciona por que ese indice no existe

            foreach (string item in nombres)
            {
                Console.WriteLine( item );
            }

            //REMOVER
            Console.WriteLine("-----lista.Remove(string)-----");// borra el 1 string
            nombres.Remove("Rosa");
            foreach (string item in nombres)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----removeAt(indice)-----"  );
            nombres.RemoveAt(1);//remuevo indice especificado
            foreach (string item in nombres)
            {
                Console.WriteLine(item);
            }

 /*COLECCIONES CONCURRESNTES e INMUTABLES*/
            //concurrencia proporcionans operacionees eficientes y seguras para acceder a los elemntos 
            // de la coleccion desde varios hilos de ejecucion
            // con concurrente nos referismos con 2 cosas q estan sucediendo al mismo tiempo
            // inmutables no pueden ser  modificadas, la  misma cantidad ni ningun elemento nuevo


        }


    }
}
