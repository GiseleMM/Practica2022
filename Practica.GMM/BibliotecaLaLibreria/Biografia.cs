using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLaLibreria
{
    public class Biografia: Publicacion
    {
        public Biografia(string nombre):base(nombre)
        {

        }
        public Biografia(string nombre,int stock): base(nombre, stock)
        {

        }
        public Biografia(string nombre, int stock, float valor):base(nombre,stock,valor)
        {

        }


        


        protected override bool EsColor
        {
            get
            {
                return false;
            }
        }
        public override bool HayStock
        {
            get
            {
                bool hay = false;
                if(this.stock>0)
                {
                    hay = true;
                }
                return hay;
            }
        }
        public static explicit operator Biografia(string nombre)
        {
            Biografia b = null;
            if (string.IsNullOrEmpty(nombre))
            {
                b = new Biografia(nombre);
            }
            return b;
      

        }
    }
  
}
