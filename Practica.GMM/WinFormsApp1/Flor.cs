using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosConWForm
{
    public class Flor
    {
        public Flor()
        {
        }

        public string Nombre { get; set; }
        public int precio { get; set; }
        public override string ToString()
        {
            return $"Nombre{Nombre} precio{precio}";
        }
    }
}
