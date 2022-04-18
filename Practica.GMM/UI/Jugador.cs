using System.Text;

namespace UI
{
    public class Jugador
    {
        private static int ultimoId;

        private string nombre;
        private string posicion;
        private int dni;
        private int goles;
        private int id;// si yo quiero el id de un jugador lo logico q tenga solo una propiedad Get NO set 
        // pq el id es algo q no deberiamos poder modificar
        
        // EL METODO GETTERSde solo lectura del atributo
        public string GetNommbre()
        {
            return this.nombre;
        }
        //PROPIEDADES-------------------------------------
        public string Nombre//PROPIEDADES NO colocar ()
        {
            // entra en COMO es el objeto NO es una accion por eso propiedad
            get { return this.nombre; }// si fuera una contraseña lo logico es q NO puedan leerla solo settearla
            // llamada string nombre= unJugador.Nombre;
            set
            {
                //escribir un campo
                //value es una palabra reservada que hace que reciba el text q le mandas
                // llamada unJugador.Nombre= "nombre q se copia en value";
                if (!string.IsNullOrEmpty(value))
                {
                    this.nombre = value;
                }
                else
                {
                    this.nombre = "sin nombre";
                }
            }
        }
        

        //si tuvieramos private bool estaHabilitado de atributo
        //public string estaHabilitado//no es un metodo no es una ACCION estoy consultado estados, el estado de  un objeto
        //{
        //    get
        //    {
        //        if (this.estaHabilitado)
        //        {
        //            return "Habilitado";
        //        }
        //        else
        //        {
        //            return "NO habilitado";
        //        }

        //    }
        //}


        public Jugador(string nombre, string posicion)
        {
            this.nombre = nombre;
            this.posicion = posicion;
        }

        public Jugador(string nombre, string posicion, int dni, int goles) : this(nombre, posicion)
        {
            this.dni = dni;
            this.goles = goles;
        }
        public string MostrarJUgador()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"nombre: {this.nombre}");
            sb.AppendLine($"apellido: {this.posicion}");
            sb.AppendLine($"dni: {this.dni}");
            sb.AppendLine($"direccion: {this.goles}");

            return sb.ToString();


        }
    }
}
