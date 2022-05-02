using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibioltecaSabado23._4
{
    public class Perro : Animal
    {
        bool esGuardian;
        public Perro(string nombre) : base(nombre)
        {
        }

        public Perro(int id, string nombre, EPelaje pelaje, bool esGuardian) : base(id, nombre, pelaje)
        {
            this.esGuardian = esGuardian;
        }
        public string Ladrar
        {
            get
            {
                return "Guauuu";
            }
        }
        public override string Alimentarse()
        {
            return "comio dogi";
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("es guardian:" + this.esGuardian);
            return sb.ToString();
        }
    }
}
