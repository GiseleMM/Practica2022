using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacion
{
    [XmlInclude(typeof(Alumno)), XmlInclude(typeof(Profesor))]
    public  class Persona
    {
        protected string nombre;
        protected int edad;

        public Persona():this(string.Empty,0)
        {
           
        }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

    }
    
}
