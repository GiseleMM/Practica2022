using System;
using System.Text;

namespace BibliotecaLaLibreria
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;



        protected abstract bool EsColor { get; }
       
        public virtual bool HayStock
        {
            get
            {
                bool hay = false;
                if( this.stock>0 && this.importe>0)
                {
                    hay = true;
                }
                return hay;
            }
        }
        public float Importe
        {
            get
            {
                return 0;
            }
        }
        public int Stock
        {
            get
            {
                return 0;
            }
            set
            {
                if( value>0)
                {
                    this.stock = value;
                }
              
            }
        }



        public Publicacion(string nombre)
        {
            this.nombre = nombre;

        }
        public Publicacion(string nombre, int stock):this(nombre)
        {
            this.stock = stock;

        }

        protected Publicacion(string nombre, int stock, float importe):this(nombre,stock)
        {
            this.importe = importe;
        }



        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" Nombre: {this.nombre.ToUpper()}");
            sb.AppendLine($"stock: {this.stock.ToString()}");
            if(this.EsColor)
            {
                sb.AppendLine($" Es color: SI");
            }
            else
            {
                sb.AppendLine($"Es color : NO");
            }
            sb.AppendLine($"Valor: $ {this.importe}");
            

            return sb.ToString(); 
        }
        public override string ToString()
        {
           
            return this.nombre;
        }

    }
}
