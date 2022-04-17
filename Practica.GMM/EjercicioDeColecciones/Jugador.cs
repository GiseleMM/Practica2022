using System;
using System.Text;
namespace EjercicioDeColecciones
{
    public class Jugador
    {
        //ATRIBUTOS
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioDeGoles;
        private int totalGoles;

        //CONSTRUCTORES
        private Jugador()
        {
            this.dni = 0;
            this.nombre = "Sin nombre";
            this.partidosJugados = 0;
            this.promedioDeGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles):this(dni,nombre)
        {
            this.partidosJugados = partidosJugados;         
            this.totalGoles = totalGoles;
        }

        //METODOS
        public float GetPromedioGoles()// calculo el promedio de goles
        {
            if (this.partidosJugados == 0)
            {
                return -1;
            }
            else
            {
                return this.promedioDeGoles = (float)totalGoles / partidosJugados;
            }
         
         
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();//IMPORTANTE PARA USAR STRINGBULIDER AGRAGAR using System.Text
            sb.AppendLine($"dni :{this.dni}");
            sb.AppendLine($"nombre :{this.nombre}");
            sb.AppendLine($"partidos jugados :{this.partidosJugados}");
            sb.AppendLine($"promedio de Gol :{GetPromedioGoles()}");//llamo a metodo GeTPromediogoles
            sb.AppendLine($"total de goles:{this.totalGoles}");
            return sb.ToString();
        }
        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            if(jugador1 is not null && jugador2 is not null)
            {
                return jugador1.dni == jugador2.dni;
                    
            }
            return false;
        }
        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }

    }
}
