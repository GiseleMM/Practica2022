using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionGenerica
{
    public class Inundacion : Fenomeno
    {
        int milimetros;
        public Inundacion():this(string.Empty,0,0)
        {

        }
        public Inundacion(string nombre, int anio,int milimetros) : base(nombre, anio)
        {
            this.Milimetros = milimetros;
        }

        public int Milimetros { get => milimetros; set => milimetros = value; }
    }
}
