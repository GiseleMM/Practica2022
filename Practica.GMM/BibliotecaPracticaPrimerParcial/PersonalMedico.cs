using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPracticaPrimerParcial
{
    public class PersonalMedico : Persona
    {

        private List<Consulta> consultas;
        private bool esResidente;
        public PersonalMedico(string apellido, string nombre, DateTime fecha, bool esResidente) : base(apellido, nombre, fecha)
        {
            this.esResidente = esResidente;
            this.consultas = new List<Consulta>();//creo lista e inicializo
        }



        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Finalizo residencia:{0}{1}", this.esResidente ? "No" : "si",Environment.NewLine);
            sb.Append("Atenciones------------------------");
            foreach (Consulta item in this.consultas)
            {
                sb.AppendLine(Persona.FichaPersonal(item.Paciente));
            }

            return sb.ToString();
        }
        public static Consulta operator +(PersonalMedico doctor , Paciente paciente)
        {
            Consulta c = null;
            if( doctor is not null && paciente is not null)
            {
                c = new Consulta(DateTime.Now, paciente);
                doctor.consultas.Add(c);
                //return c;
            }
            //throw new Exception("Puedo lanzar una excepcion  para no retornar consulta  null y caundo uso el + catch");
            return c;
        }
    }
}
