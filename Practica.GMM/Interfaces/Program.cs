using System;
using System.Collections.Generic;
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces");
            List<IMensaje> listaDelTipoIMensaje = new List<IMensaje>();
            /* creo una lista donde puedo agregar todas las clases q implemmentan la interzace IMensaje
             */
            Carta carta = new Carta();
            Cuervo cuervo = new Cuervo();
            IMensaje carta2 = new Carta();//ESTO NO se puede  new IMensaje();
            /*carta2 es del tipo Imensaje pero la isntancio con Carta*/

            listaDelTipoIMensaje.Add(carta2);//agrego a lista todas las clases q usan la interfaz 
            listaDelTipoIMensaje.Add(cuervo);
            listaDelTipoIMensaje.Add(carta);

            Console.WriteLine(carta2.EnviarMensaje());// forma implicita sin casteo
            Console.WriteLine(carta2.Costo=5);
            Console.WriteLine(((IMensaje)cuervo).EnviarMensaje());//cuervo. y no aparece nada x q en cuervo lo impplimentamos como Expliciat debo castear
            Console.WriteLine(((IEncriptado)cuervo).EnviarMensaje());// cuervo tiene las dos Intefaces de forma implicta
            Console.WriteLine(cuervo.Costo);

            //recorro la lista
            int i = 0;
            foreach (IMensaje item in listaDelTipoIMensaje)
            {

                Console.WriteLine("item.GetType(): {0} ", item.GetType());//con esto obtengo  Interface Nombre si quiero solo el nombre de la clase item.GetType().Name
                if( item is IEncriptado)
                {
                    Console.WriteLine("lista  item indice {0} es  del tipo IEncripado",i);
                    Console.WriteLine(((IEncriptado)item).EnviarMensaje());
                  
                }
                i++;
            }


            
        }
    }
}
