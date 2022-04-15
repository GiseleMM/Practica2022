using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Sistema
    {
        /*clase estatica no se istancia
         nombre de la clase. y metodo
        vamos a ser una clase estatica q maneje al usuario
        si polgo la clase estatica en el proyecto con el main a eso
        no voy a poder acceder para otro proyecto No sirve, por eso se crea en 
        la biblioteca de clase en Logica
        cuando la  quiera usar en el program voy a ser Sistema.metod q
        corresponda
        static tiene referencia a muchas cosas q vamos a usar muchas veces ej
        validar string, comprobar ortografia, se puede llamar de forma
        independiente desdecualquier lado, no van a tener q pasar una referencia de donde esta(objeto)
        en este caso como sistema va a concentrar informacion y va a manipular la informacion
        vamos a declara a todos los usarios aca dentro de sistema
        y como es una clase estatica tiene  que tener todos y cada uno de 
        sus componentes de forma estatica por que por ser estatico se crea una vez sola,
        la 1 vez que la usa. y esta clase para poder funcionar nunca un new
        
        */
        
        //mod  tipo en ese caso Clase  identificador 
        
        //CREO EL ARRAY
        static Usuario[] usuariosRegistrados;//lista o array de  tipo usuarios
        //contructor statico por que la calse es estatica
        static Sistema()// contructotor static sistema
        {
           //INSTANCIO EL ARRAY 
            usuariosRegistrados = new Usuario[3];//instancio en array de objetos
            CargarUsuario();
        }
        private static void CargarUsuario()
        {
            //la idea del hardcodear aca es que  luego podemos usar la misma logica en por ej window forms
            //si dejas  el hacodeo en el main luego vas a tener que hacerlo otra vez en el wForms
            usuariosRegistrados[0] = new Usuario("Rocky", "sinLL");
            usuariosRegistrados[1] = new Usuario("Rocky2", "conLL");
            usuariosRegistrados[2] = new Usuario("Rocky3", "sinYY");
        }
        //compruebo  si el usuario existe o no existe en el sistema por q sistema es el q maneja los usarios
        public static bool CheckearUsuario(string nombre, string pass)
        {
            //este metodo es paar cuando el usuario te escriba el usuario y contrasenia por consola
            if(string.IsNullOrEmpty(nombre.Trim()) || string.IsNullOrEmpty(pass.Trim()))
            {
                //trim() metodo borra espacio adelante y atras
                return false;
            }
            //recorro el array para ver si esta el usuario
            for(int i=0; i<usuariosRegistrados.Length;i++)
            {
                if (usuariosRegistrados[i] != null)
                {
                    //lucas != lUCAs toUpper pasa LUCAS LUCAS
                    if (nombre.Trim().ToUpper() == usuariosRegistrados[i].GetNombre().Trim().ToUpper())
                    {
                        //si todavia no creer el metodo lon escribo , click derecho
                        //acciones rapidas Generar metodo y  me lo crea
                        return usuariosRegistrados[i].CheckPass(pass);
                    }
                }
            }
                return false;
        }

        /*crear ususrio nuevo
        public static bool CrearUsuarioNuevo(string nombre,string password)
        {
        int posicionLibre=verfificarPosicionLibre(
        if(posicionLibre!= -1
        {
        usuarioRegsitradidp[posicionLibre]=new Usuario(nombre,passior);
        return true;
        }
        else
        {
        return false;
        }
            //q  haya espacio NO se puede agrandar se usa otro tipo de herramienta
            //q no exista
            usuariosRegistrados[]=new Usuario( nombre,password)
            true si se cargo
        }*/
        public static bool CambiarPassword(string  nombre, string pass)
        {
            //el sistema le dice al usuario indicado modicar contrasena pero el  que se cambia el password es  el usuario
            for(int i=0;i<usuariosRegistrados.Length;i++)
            {
                if(usuariosRegistrados[i].GetNombre()==nombre)
                {
                    usuariosRegistrados[i].ModificarPassword(pass);
                    return true;

                }
            }
            return false;
        }
        private static int VerificarPosicionLibre()
        {

            return -1;
        }
             
             

    }
}
