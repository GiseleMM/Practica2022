using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Carta : IMensaje
    {
        private float costo;
        public float Costo 
        {
            get
            { return this.Costo; }
            set
            { this.costo = value; }
                 
        }

        public string EnviarMensaje()
        {
            return "Forma implicita sin casteo";
        }
    }
}
