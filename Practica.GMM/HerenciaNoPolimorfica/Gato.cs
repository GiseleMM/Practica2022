using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaNoPolimorfica
{
    public class Gato: Animal       
    {
        public new string EmitirSonido()// oculto un miembro heredada
        {
            return "Miauuuuu";
        }
    }
}
