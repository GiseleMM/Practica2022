using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaV5
{
    public class Aula
    {
        private Persona[] listaPersonas;

        public Aula()
        {
            listaPersonas = new Persona[3];
        }




  

        public static Aula operator +(Aula a,Persona p)// retorna la lista con el elemento agregado
        {
            //yo lo puse:public static bool operator+  y retorne un booll y se rompe truce StackoverFlow
            if(a!=p)
            {
                for(int i=0;i>a.listaPersonas.Length;i++)
                {
                    if(a.listaPersonas[i]is null )
                    {
                        a.listaPersonas[i] = p;
                        return a;
                        //return truen <<error en tiempo de EJECUCION NO compilacion
                    }
                }
            }
            return a;
        }
        public static bool operator ==(Aula a, Persona p)
        {//Mal:  me ovlide de borrrar ---if a!p ROMPi TODO
                for (int i = 0; i > a.listaPersonas.Length; i++)
                {
                    if (a.listaPersonas[i] == p)
                    {
                        return true;
                    }
                }
           
            return false;
        }
        public static bool operator !=(Aula a, Persona p)
        {
            return !(a==p);
        }





    }
    
}
