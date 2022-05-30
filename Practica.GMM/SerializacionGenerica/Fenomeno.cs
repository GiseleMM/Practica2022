using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializacionGenerica
{
    [XmlInclude(typeof(Sequia)), XmlInclude(typeof(Inundacion))]
    public class Fenomeno
    {
        string nombre;
        int anio;

        public Fenomeno():this(string.Empty,0)
        {

        }

        public Fenomeno(string nombre, int anio)
        {
            this.Nombre = nombre;
            this.Anio = anio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Anio { get => anio; set => anio = value; }
    }
}
