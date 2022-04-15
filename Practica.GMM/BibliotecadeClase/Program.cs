using System;
using Logica;

namespace BibliotecadeClase
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Sistema.CheckearUsuario("Rocky", "sinLL"))
            {
                /*
                 como una abm
                1 logearse
                2 cambiar contraseña
                3salir
                switc(opcion)
                1: cambio banders para poder ingresar ala opcion 2  de cambiar contrasenia
                2 :si no cambio bandera no modifico contraseña

                */
            
                Console.WriteLine("Logeado");

            }
            else
            {
                Console.WriteLine("INVALIDO");

            }
        }
    }
}
