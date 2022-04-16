using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLogearse
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string direccion;

        public Alumno(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Alumno(string nombre, string apellido, int dni, string direccion): this(nombre,apellido)
        {
            this.dni = dni;
            this.direccion = direccion;
        }
        public string MostrarAlumno()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"nombre: {this.nombre}");
            sb.AppendLine($"apellido: {this.apellido}");
            sb.AppendLine($"dni: {this.dni}");
            sb.AppendLine($"direccion: {this.direccion}");

            return sb.ToString();


        }
        public int GetDNI()// esto me permite devolver un dato q esta dentro del alumno
        {
            return this.dni;
        }
    }
}
