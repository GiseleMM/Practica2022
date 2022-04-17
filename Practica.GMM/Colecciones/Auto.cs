using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    public class Auto
    {
        private string patente;
        private string marca;

        public Auto(string patente, string marca)
        {
            this.patente = patente;
            this.marca = marca;
        }
        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"patente: {this.patente}");
            sb.AppendLine($"marca:{this.marca}");
            return sb.ToString();
         
        }
    }
}
