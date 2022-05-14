using System;
using System.Text;

namespace BibliotecaPracticaPrimerParcial
{
    public abstract class Persona
    {
        protected string apellido;
        protected string nombre;
        protected string barrio;
        protected DateTime fecha;

        public Persona(string apellido, string nombre, DateTime fecha)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.fecha = fecha;
        }
        protected Persona(string apellido, string nombre, string barrio, DateTime fecha)
            :this(apellido,nombre, fecha)//reutilizo es constructor de arriba
        {
            this.barrio = barrio;
           
        }
        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(-this.fecha.Ticks).Year - 1;
            }
        }
        public string NombreCompleto
        {
            get 
            {
                return string.Format($"{this.apellido}, {this.nombre}");
            }
        }
        public static string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();

            if (p is not null)
            {
                sb.AppendLine(p.ToString());// x q  toSTringg() retorna nombre completo   sb.AppendLine(p.NombreCompleto);
                sb.AppendLine(p.barrio);
                sb.AppendLine(p.Edad.ToString());
                sb.AppendLine(p.FichaExtra());// Persona es abstracta NO va a tener obj instanciados  la ficha extra va a ser de los objetos derivados por polimosrfimo

            }
            return sb.ToString();
        }
        public override string ToString()//invalido el toString()
        {
            return this.NombreCompleto;
        }

        internal abstract string FichaExtra();// sin implementar metodo abstract


    }
}
