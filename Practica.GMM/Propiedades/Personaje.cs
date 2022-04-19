using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    public class Personaje
    {
        int id;
        string nombre;
        int poder;
        bool esMagico;

        public Personaje(int id, string nombre, int poder, bool esMagico)
        {
            this.id = id;
            this.nombre = nombre;
            this.poder = poder;
            this.esMagico = esMagico;
        }
        //PROPIEDAD
        public string Nombre// pq string xq  es el tipo de dato q va a manejar esa propiedad
        {
            get 
            {
                return this.nombre;
            }
        }

        public int Poder 
        {
            set
            {
                this.poder = value; 
            }
        }
        public string MostrarPersonaje()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"id:{this.id}");
            sb.AppendLine($"nombre:{this.nombre}");
            sb.AppendLine($"poder:{this.poder}");
            sb.AppendLine($"es magico:{this.esMagico}");
            return sb.ToString();
        }
    }
}
