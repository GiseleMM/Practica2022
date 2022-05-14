using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPracticaPrimerParcial
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;
        

        public Paciente Paciente
        {
            get { return this.paciente; }
            
        }
        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }
        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }
        public override string ToString()
        {
            return $"{this.Fecha} se atendio a {this.Paciente}";
        }
    }
}
