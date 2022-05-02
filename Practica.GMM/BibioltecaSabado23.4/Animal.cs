using System;
using System.Text;
namespace BibioltecaSabado23._4
{



    public enum EPelaje
    {
        Corto = 120,
        Mediano = 332,
        Largo = 777,

    }
    public abstract class Animal
    {

        int id;
        string nombre;
        EPelaje pelaje;

        public Animal(string nombre)
        {
            this.nombre = nombre;
        }
        public Animal(int id, string nombre, EPelaje pelaje) : this(nombre)
        {
            this.Id = id;
            this.pelaje = pelaje;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"id:{this.id }");
            sb.AppendLine($"nombre: {this.nombre}");
            sb.AppendLine($"pelaje: {this.pelaje.ToString()}");
            //sb.AppendLine($"raza: {this.Raza}");
            return sb.ToString();
        }

        //propiedad
        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                if(value!=-1)
                {
                    this.id = value;
                }
            }
        }
        /*public string Raza
        {
            get { return "PERRO"; }
        }*/

        public int PrecioCorte
        {
            get
            {
                //casteo enumerado a int e devuleve la parte entera del enumerado
                return (int)pelaje;
                //return pelaje.ToString();
            }
        }
        public abstract string Alimentarse();
        
    }
}
