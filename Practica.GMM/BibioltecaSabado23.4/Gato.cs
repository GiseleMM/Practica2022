using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibioltecaSabado23._4
{
    public class Gato : Animal
    {
        public Gato(string nombre) : base(nombre)
        {
        }

        public Gato(int id, string nombre, EPelaje pelaje) : base(id, nombre, pelaje)
        {
        }

        public string Maullar
        {
            get
            {
                return "Miauuu";
            }
        }
        public override string Alimentarse()
        {
            return "comio pez";
        }
    }
}
