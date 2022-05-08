using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    public class Publicacion
    {
        public string autor;
        public string nombre;

        public Publicacion(string autor, string nombre)
        {
            this.autor = autor;
            this.nombre = nombre;
        }

        public string MostrarDatos()
        {
            return $"Clase: {this.GetType().Name} titulo {this.nombre} autor : {this.autor}";
        }
    }
}
