using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Cuervo: IEncriptado,IMensaje
    {
        float costo;
        string IMensaje.EnviarMensaje()//EXPLICITO NO ACEPTA PUBLIC
        {
            return " explicito  de IMensaje desde cuervo";
        }
        string IEncriptado.EnviarMensaje()
        {
            return "Expplicito de IEncriptado desde cuervo";
        }
        public float Costo  // si no la pongo public tengo que poner float IMensaje.Costo{get jjjj sejjjj}
        {
            get
            {
                return 33;
            }
            set
            {
                this.costo = value;
            }
        }

        
    }
}
