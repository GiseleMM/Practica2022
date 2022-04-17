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
            //las NO genericas no cuentas con seguridad de tipo
            //las genericas todos los elementos de la coleccion tienen el mismo tipo de datos
            
            
            /*         LIstas           */
            List<string> nombres = new List<string>(); // entre<> el tipo de los elemnetos de la colleccion
            //todas las colleciones son objetos y hay q instanciarlos en base cero
           // son de tipeado fuerte

            //AGREGAR
            nombres.Add("Lautaro");// cree una nueva  posicion en la lista con  metodo Add
            nombres.Add("Leonel");
            nombres.Add("Lali");
            nombres.Add("Zeki");
            nombres.Add("Roman");
            nombres[1] = "Rosa";// puedo sobreescribir con el indices que cree con Add pero si intento ingresar nombres[10]="hiid" NO Funciona por que ese indice no existe

            foreach (string item in nombres)
            {
                Console.WriteLine( item );
            }

            //REMOVER
            Console.WriteLine("-----lista.Remove(string)-----");// borra el 1 string
            nombres.Remove("Rosa");// si esta elmismo nombre borra el primero
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
            Console.WriteLine("--------------lista de tipo Auto---------");
            List<Auto> garage = new List<Auto>(); // defino e istancio lista de  clase AUTO
            Auto auto1 = new Auto("4224", "Marca1");
            Auto auto2 = new Auto("4223", "Marca2");
            garage.Add(auto1);
            garage.Add(auto2);
            foreach (Auto item in garage)
            {
                Console.WriteLine(item.MostrarAuto());
            }
            Console.WriteLine("--------------remove-----------------------");
            garage.Remove(auto1);
            foreach (Auto item in garage)
            {
                Console.WriteLine(item.MostrarAuto());
            }
            Console.WriteLine("--------nombredeColeccion.Count cantidad de elementos de coleccion-------"  );
            Console.WriteLine(garage.Count);//>>>SIN ()
            Console.WriteLine("-------------metodo sort--------------------");
            foreach (string item in nombres)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("nombres.sort()");
            nombres.Sort();
            foreach (string item in nombres)
            {
                Console.WriteLine(item);
            }
            List<int> listaNumeros = new List<int>();
            listaNumeros.Add(1);
            listaNumeros.Add(100);
            listaNumeros.Add(0);
            listaNumeros.Add(3);
            foreach (int item in listaNumeros)
            {
                Console.WriteLine(item);
            }

         
            Console.WriteLine("--------sort(nombre del metodo criterio)----");
            listaNumeros.Sort(Compararcion);// le estas pasando una refrencia del metodo no el metodo en si
            foreach (int item in listaNumeros)
            {
                Console.WriteLine(item);
            }
        

            /*            Directorio <tKey,tvalue>           */
            // en un diccionario no pueden haber dos claves iguales

            //DECLARACION 
            Dictionary<string, int> agenda = new Dictionary<string, int>();
            //nombre  y un telefono, no se puede repetir la clave 
            agenda.Add("Tomas", 23323);//no puedo repetir clave(en este caso Tomas) si valor si repetis te lo rompe en tEjecucion
            agenda.Add("Esteban", 33555);
            agenda.Add("Jorge", 8888);
            Console.WriteLine("Recorro DICCIONARIO con foreach KeyValuePair<clave,valor>");
            foreach (KeyValuePair<string, int> item in agenda) 
            {
                Console.WriteLine($"Nombre:{ item.Key} Numero: {item.Value}");
            }
            Console.WriteLine("recorro solo valores");
            foreach (var item in agenda.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("recorro solo claves");
            foreach (var item in agenda.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("puedo buscar  claves diccionario.ContainsKey(Clave)");
            int banderaEstaTomas = 0;
            foreach (var item in agenda.Keys)
            {
                if(agenda.ContainsKey("Tomas") && banderaEstaTomas==0 )
                {
                    Console.WriteLine("Tomas esta agendao");
                    banderaEstaTomas = 1;
                }
                Console.WriteLine(item);
            }
            Console.WriteLine("puedo buscar  valores diccionario.ContainsValue(Valor)");
            int banderaEstaValor = 0;
            foreach (var item in agenda.Keys)
            {
                if (agenda.ContainsValue(8888) && banderaEstaValor == 0)
                {
                    Console.WriteLine(" esta valor 8888 en la agenda");
                    banderaEstaValor = 1;
                }
                Console.WriteLine(item);
            }
            Console.WriteLine("diccionario.TryGetValur(clave,out int value) retorna el valor de la llave en parametro out");
            if(agenda.TryGetValue("Tomas",out int value))
            {
                Console.WriteLine(value);
            }

            /*             Colas Queue<T>             */
            // el  primero  que entra es el 1 q sale , No estan indexadas y NO se pueden ordenar

            //DECLARACION 
            Queue<Auto> colaAutos = new Queue<Auto>();

            //AGREGAR ELEMENTOS
            colaAutos.Enqueue(auto1);
            colaAutos.Enqueue(auto2);

            //MOSTRAR
            Console.WriteLine("Muestro elementos de Queue");
            foreach (var item in colaAutos)
            {
                Console.WriteLine(item.MostrarAuto());
            }
            //VER 1°
            Console.WriteLine("veo el 1° elemento de la cola con el metodo Peek()");
            Console.WriteLine(colaAutos.Peek().MostrarAuto());// lo muestro NO lo elimnina
            //ELIMINAR 1°
            Console.WriteLine("elimino el 1° elemento de la Queue con metodo cola.Dequeue()");
            Console.WriteLine(colaAutos.Dequeue().MostrarAuto());// lo elimnina

            /*           Stack o PIla                    */
            // pila,  el ultimo q entro es el primero q sale
            //DECLARACION
            Stack<int> pilaNumeros = new Stack<int>();
            //AGREGAR
            pilaNumeros.Push(33);
            pilaNumeros.Push(44);
            pilaNumeros.Push(-4);
            //MOSTRAR
            Console.WriteLine("Muestro pila desde el ultimo al primero");
            foreach (var item in pilaNumeros)
            {
                Console.WriteLine( item );
            }
            //VER El Ultimo ELEMENTO 
            Console.WriteLine($"pilaNumeros.Peek() {pilaNumeros.Peek()}");
            //ELIMINAR EL ULTIMO ELEMENTO
            Console.WriteLine($" pilaNuemros.Pop(){pilaNumeros.Pop()}");
            //METODO CONTAINS()
            if(pilaNumeros.Contains(44))
            {
                //                                     IMPORTANTE 
                // compara por el tipo de valor que tenga adentro, los tipos por referencia conpara referencia
                // los tipos de valor compara por valor
                Console.WriteLine("Esta 44 en la lista pilaNumeros.Contains(valor)");
            }

            /*COLECCIONES CONCURRESNTES e INMUTABLES*/
            //concurrencia proporcionans operacionees eficientes y seguras para acceder a los elemntos 
            // de la coleccion desde varios hilos de ejecucion
            // con concurrente nos referismos con 2 cosas q estan sucediendo al mismo tiempo
            // inmutables no pueden ser  modificadas, la  misma cantidad ni ningun elemento nuevo

        }//----------------------------------FIN DEL MAIN-------------------------------------------------------------
        //funcion criterio para ordenar (((((AFUERA DEL MAIN)))))
        public static int Compararcion(int a, int b)// siempre devuelve un entero pq es lo q va a decir como  ordenar 0,1 o-1
        {
            // pero lo  que puede cambiar es los parametros, que tiene q ser del mismo tipo de la lista, si es auto  , string etc
            // (Auto a, Auto b)
            //retunr a.marca - b.marca;recibo dos autos y los comparo por marca 
            //si es un string.Compare()
            return a - b;// de menor a mayor 
                         //return b-a de mayor a menor
        }


    }
}
