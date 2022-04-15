using System;

namespace Logica
{
    public class Usuario
    {
        //para cambiar nombre d clase En el explorador de soluciones-click derecho- cambio nombre y luego si
        private string nombre;
        private string password;

        public Usuario(string nombre, string password)
        {
           
            this.nombre = nombre;
         
          
          
            this.password = password;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public bool ComprobarPw(string password )
        {

            return password == this.password;
        }
        // le pasas el password si es igual al 
        public bool CheckPass(string pass)
        {
            return this.password == pass;
        }
        public void ModificarPassword(string pass)
        {
            this.password = pass;
        }
        /*el usuario sabe: contruirse - devolver su nombre- comprobar su contrasenia
         el usario sabe modificar su ccontrasenia
        atributo define como esel objeto
        contructor lo contruye
        metodo  permite hacer operaciones sobre el mismo usario
        */
    }
}
