using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaNoPolimorfica
{
    public class Perro: Animal
    {
        public new string EmitirSonido()
        {
            return "WOAF WOAF";
        }
    }
}
