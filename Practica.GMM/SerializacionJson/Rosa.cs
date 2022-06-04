using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionJson
{
    public class Rosa : Flor
    {
        DateTime time;
        public Rosa()
        {
           
        }

        public Rosa(string nombre, string tipo, float altura) : base(nombre, tipo, altura)
        {
            time = DateTime.Now.Date;
        }

        public DateTime Time { get => time; set => time = value; }
        public override string ToString()
        {
            return $"{this.Nombre} - {this.Tipo} - {this.Time.ToString()}";
        }
    }
}
