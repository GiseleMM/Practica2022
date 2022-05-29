using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    public class Alumno: Persona
    {
        
        List<string> materias;

        public Alumno():base()
        {
           Materias = new List<string>();
        }

        public Alumno(string nombre, int edad):this()
        {
            this.Nombre = nombre;
            this.Edad = edad;

        }
       
   

        public List<string> Materias { get => materias; set => materias = value; }

        //public Queue<string> Materias1 { get => materias; set => materias = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Nombre);
            sb.AppendLine(base.Edad.ToString());
            sb.AppendLine("materias");
            
            foreach (var item in Materias)
            {
                sb.AppendLine(item);
            }
            return sb.ToString();
        }
    }
}
