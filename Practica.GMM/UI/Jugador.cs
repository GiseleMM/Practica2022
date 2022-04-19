using System.Text;

namespace UI
{

    public enum EPosiciones
    {
        Arquero,// puedo  darle un valor numerico  arquero=12 y el proximo tendra valor 13 si no lo modifico
        Defensor,
        Mediocampista,
        Delatero

    }
    public class Jugador
    {
    


        private string nombre;        //boton derecho, acciones rapidas,ENCAPSULAR campo nombre y suar propiedades y me lo genera
                                     // private string posicion;vamos a hacerlo enumerado y agregar q solo ingrese numeros en el form
        private EPosiciones posicion;
        private int dni;
        private int goles;
        private int id;// si yo quiero el id de un jugador lo logico q tenga solo una propiedad Get NO set 
                       // pq el id es algo q no deberiamos poder modificar   
        private static int ultimoId;// este ultimo id NO pertence al jugador q se va a creer 
        // pertenece al molde a la clase, vamos a ser un constructor estatico del jugador
        // que es el constructor que se ejecuta 1 sola vez la 1 vez q se  hace referencia
        // y que solo puedo manejar adentro atributos estaticos
        //NO SE PUEDE ultimoID=1; aca en la declaracion SOLO las CONSTANTES  seria const int UlTIMOID=1;Pero no se puede modificar

        public Jugador()
        {
            ultimoId = 1;
        }

        // EL METODO GETTERSde solo lectura del atributo, en realidad es una forma de devolver el estado
        // de un objeto cuando para eso  hay PROPIEDADES
        public string GetNommbre()
        {
            return this.nombre;
        }
        //PROPIEDADES-------------------------------------
        public string Nombre//PROPIEDADES NO colocar ()
        {
            // si pones GET Y SET es lo mismo que tener el atributo Publico
            // entra en COMO? es el objeto NO es una accion por eso propiedad
            get // retorno el valor, que devuelvo
            { 
                return this.nombre; 
            }
            // si fuera una contraseña lo logico es q NO puedan leerla(get) solo settearla
            // LLAMADA del propiedadGET: string nombre= unJugador.Nombre;
            set// pisar el valor
            {
                //escribir un campo
                //value es una palabra reservada que hace que reciba el text q le mandas
                // LLAMADA DE propiedadSET: unJugador.Nombre= "nombre q se copia en value";
                if (!string.IsNullOrEmpty(value))// valido que sea un nombre valido para luego usarlo
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


        public Jugador(string nombre, EPosiciones posicion)
        {
            // cada vez que un jugador pase a contruirse se va a construir con el ultimo id
            // y antes de salir lo incrementa para que el siguiente jugador no tenga el mismo
            this.id = ultimoId;// cargo el ultimo id
            this.nombre = nombre;
            this.posicion = posicion;
            ultimoId++;// aumento en uno el id
        }

        public Jugador(string nombre, EPosiciones posicion, int dni, int goles) : this(nombre, posicion)
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
