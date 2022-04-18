using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeColecciones
{
     public class Equipo//cambio de internal
    {
        private short cantidadDeJugadores;
        private List<Jugador> listaJugadores;// nos objetoos Tipos de referencia hay que instanciarlos
        private string nombre;

        //CONSTRUCTORES
        private Equipo()
        {
            listaJugadores = new List<Jugador>();// se instancie la lista de jugadores
        }

      
        public Equipo(string nombre, short cantidadDeJugadores):this()//llamo al cosntrcutor privado 
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidadDeJugadores;
        }
        
        //METODOS
        public static bool operator +(Equipo equipo1,Jugador jugador1)// es estatico le paso los elementos
        {
            // de algo estatico no puedo acceder a algo de instancia
            //puedo usar y acceder a sus atributos por q son de la misma clase
            //count es la propiedad q retorna la cantidad de jugadores de un equipo
            if(equipo1.listaJugadores.Count <equipo1.cantidadDeJugadores)
            {
                // si la cantidad de jugadores de la lista es menor a la cantidad de Jugadors del equipo
                foreach (Jugador item in equipo1.listaJugadores)
                {
                    if(item == jugador1 )// sobrecargador en la clase JUgador con el jug == jug2 si tienen el mismo dni
                    {
                        return false;
                    }

                }
                equipo1.listaJugadores.Add(jugador1);//si no lo encontro en la lista lo agrega
                return true;
            }
            return false;
        }
        public void MostrarEquipo()
        {
           
            foreach (Jugador item in listaJugadores)
            {
                if(item is not null)
                {
                    Console.WriteLine(item.MostrarDatos());
                }
            }
          
        }
        public static void AgregarJugador(Equipo equipo1, Jugador jugador1)
        {
            if (equipo1 + jugador1)
            {
                Console.WriteLine($"jugador agregar a equipo{jugador1.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"no  se pudo agregrar a equipo {jugador1.MostrarDatos()}");
            }
        }




    }

}
