using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaV5
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private long dni;
        public Persona()
        {
            this.nombre = String.Empty;// esto representa un string vacio
            this.fechaDeNacimiento=new DateTime(1999, 1, 1);
            this.dni = 0;
        }
        public Persona(string nombre) : this()//llama a otro construcctor
        {
            this.nombre = nombre;
        }
        public Persona(string nombre,DateTime fecha):this(nombre)
        {
            this.fechaDeNacimiento = fecha;//MAL  ME TOMA EL DE INICIOfechaDeNacimiento;
        }
        public Persona(string nombre, DateTime fecha,long dni): this(nombre,fecha)
        {
            this.dni = dni;
        }
        /*
        public Persona(string nombre, DateTime fechaDeNacimiento, long dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }*/

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"nombre{this.nombre}");
            sb.AppendLine($"fecha de nacimiento:{this.fechaDeNacimiento.ToString()}");
            sb.AppendLine($"dni:{this.dni}");
            return sb.ToString();
        }
        public static bool operator ==(Persona p, Persona g)
        {
            if (p is not null && g is not null)
            {
                return p.nombre == g.nombre;
            }
            return false;
        }
        public static bool operator !=(Persona p, Persona g)
        {
            return !(p==g);//reutilizo la sobrecaga del operador == negandolo
        }
        public static implicit operator long(Persona p)  //implicitamente pasa de persona p a long retorno dni
        {
            return p.dni;
        }
        public static explicit operator string(Persona p)// explicitamente con casteo string paso de persona a string retorno nombre
        {
            return p.nombre;
        }
    }
}
