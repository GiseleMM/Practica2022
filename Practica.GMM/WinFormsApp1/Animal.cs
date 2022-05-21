using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosConWForm
{
    public class Animal
    {
        public string Nombre { get; set; }
        public float Peso { get; set; }
        public Animal()
        {
        }
        public override string ToString()
        {
            return (Nombre + Peso).ToString(); 
        }
    }
}
