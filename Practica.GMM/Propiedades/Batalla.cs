using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    public class Batalla
    {
        List<Personaje> listaPersonajes;

        //PROPIEDAD INDEXADA------------------------------
        public Personaje this[int indice]// a este objeto battalla no le vamos a poner un nombre
        {
            //podriamos hacerlo con id pasar el id y buscar el id en la lista y retornar ese elemento
            // tendriamos que hacer que NO ingrese un indice NO valido
            //DENTRO DEL GET NO se puede AFUERA    
            get
            {
                if (indice > -1 && indice < listaPersonajes.Count)
                {
                    return listaPersonajes[indice];
                }
                return null;

            }

            set// para seter un indice
            {
                //en la lista de personaje en le indice pasodo voy a settear un valor
                listaPersonajes[indice] = value;
            }
        }
        //public para accederlo de otro lado
        // el tipo de dato que quiero devolver
        //this por que a cualquier cosa de tipo batalla le voy a poder pasar un indice numerico o de nombre
        // estoy enviando una informacion a la propiedad para que haga algo en base 
        // de lo que yo le estoy pasando
        public Personaje this[string auxNombre]
        {
            get
            {
                foreach (Personaje item in listaPersonajes)
                {
                    if(auxNombre== item.Nombre)
                    {
                        return item;

                    }
                }
                return null;// si no lo encontre en la lista
            }
        }
        //public List<Personaje> ListaPersonajes
        //{
        //    get 
        //    { 
        //        return this.listaPersonajes; 
        //    }
        //}
        //LLAMADA MAIN: List<Personaje> personajes = superCambte.ListaPersonaje;
        // si DEVUELVO TODO no es muy seguro

        public Batalla()//ctroTabTab y crea clase
        {
            listaPersonajes = new List<Personaje>();    
        }
        public void AgregarPersonaje(Personaje aux)
        {
            listaPersonajes.Add(aux);
        }
    }
}
