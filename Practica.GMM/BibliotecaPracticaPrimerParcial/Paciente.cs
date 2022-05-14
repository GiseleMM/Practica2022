using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPracticaPrimerParcial
{
    public class Paciente : Persona
    {
        private Diagnostico diagnostico;
        public Diagnostico Diagnostico
        {
            get
            { return this.diagnostico;
            }
            set
            {
                this.diagnostico = value;

            }
        }



        public Paciente(string apellido, string nombre, string barrio, DateTime fecha) : base(apellido, nombre, barrio, fecha)
        {
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"reside en {this.barrio} ");
            sb.AppendLine($"diagnostico :{ this.Diagnostico}");
            return sb.ToString();
        }
    }
}
