using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionGenerica
{
    public class Sequia: Fenomeno
    {
        int duracion;
        public Sequia():this(string.Empty,0,0)
        {
        }

        public Sequia(string nombre, int anio,int duracion):base(nombre,anio)
        {
            this.Duracion = duracion;

        }

        public int Duracion { get => duracion; set => duracion = value; }
    }
}
