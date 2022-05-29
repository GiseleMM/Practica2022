using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    public class Profesor : Persona
    {
        string legajo;


        public Profesor()
        {
            legajo = string.Empty;
        }

        public Profesor(string nombre, int edad, string legajo) : base(nombre, edad)
        {
            this.Legajo = legajo;
        }

        public string Legajo { get => legajo; set => legajo = value; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Nombre);
            sb.AppendLine(base.Edad.ToString());
            sb.AppendLine(legajo);
            return sb.ToString();
        }
    }
}
