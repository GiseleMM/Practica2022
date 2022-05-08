using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    public class Libro : Publicacion
    {
        protected int paginas;// modificador protected permite que  clases derivadas  lo vean como publicos  y las NO derivadas es como private NO pueden acceder
        public Libro(string autor, string nombre,int paginas) : base(autor, nombre)
        {
            this.paginas = paginas;
        }

        private int precio;

        public int Precio// propFull+TAB+TAB crea miembro private y su propiedad
        {
            get { return precio; }
            set { precio = value; }
        }


        public  new string MostrarDatos()//uso New para oculatar un miembro heredado (en este caso un metodo)
        {
            //return $"Clase: {this.GetType().Name} titulo {this.nombre} autor : {this.autor} paginas {this.paginas}";
            return $"{base.MostrarDatos()} paginas {this.paginas}";// llamo al  metodo base
        }
    }
}
