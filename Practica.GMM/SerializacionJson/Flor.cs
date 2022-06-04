using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializacionJson
{
    [XmlInclude(typeof(Rosa))]
    public abstract class Flor
    {
        string nombre;
        string tipo;
        float altura;
        public Flor()
        {
            nombre = "Completar";
            tipo = "a completar";
            altura = 0;
        }

        protected Flor(string nombre, string tipo, float altura):this()
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.altura = altura;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public float Altura { get => altura; set => altura = value; }
    }
}
