using System;
using EjercicioDeColecciones;//refencio Biblioteca de clases

namespace ConsolaEjercicioColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JUGADOR");
            Equipo equipo = new Equipo("EquipoLomas", 12);
            Jugador jugador1= new Jugador(6666,"YONI",3,2);// instancio un jugador y le paso los parametros
            Jugador jugador2 = new Jugador(6666, "Robert", 4, 4);
            Jugador jugador3 = new Jugador(323, "Lucas", 11, 4);
            Jugador jugador4 = new Jugador(242, "Mario", 3, 6);
            Console.WriteLine( jugador1.MostrarDatos());

            //TRUCO si quiero cambiar algo en muchos lados CTROL +RRR y cambia en todoas los lugares

            //-=equipo + jugador1; - es un opeaador de desacrte no importa lo q retorne lo descarte
            Equipo.AgregarJugador(equipo, jugador1);//llamo Clase.MetdoStatico(paso objetos)
            Equipo.AgregarJugador(equipo, jugador2);
            Equipo.AgregarJugador(equipo, jugador3);
            Equipo.AgregarJugador(equipo, jugador4);
            Console.WriteLine("Equipo");
            equipo.MostrarEquipo();//de instancia ¿¿¿Como hacerlo para q lo retorne y yo lo muestre en vez de mostrarlo por el metodo????
        

        }
        //static void AgregarJugador(Equipo equipo1, Jugador jugador1)  >>>>>>>>>>>LO pase a Clase Equipo como metodo public static
        //{
        //    if (equipo1 + jugador1)
        //    {
        //        Console.WriteLine($"jugador agregar a equipo{jugador1.MostrarDatos()}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"no  se pudo agregrar a equipo {jugador1.MostrarDatos()}");
        //    }
        //}

    }
}


