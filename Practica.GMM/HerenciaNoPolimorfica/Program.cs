using System;

namespace HerenciaNoPolimorfica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herencia no polimorfica");
            Animal animal = new Animal();
            Animal perro = new Perro();
            Animal gato = new Gato();
            Console.WriteLine(animal.EmitirSonido());// se llama al tipo de referencia(en este caso todos son animal) que contiene la isntancia no importa de que tipo es la isntancia
            Console.WriteLine(perro.EmitirSonido());// todos muestran "roar"
            Console.WriteLine(gato.EmitirSonido());


            Gato gato1 = new Gato();
            Perro perro1 = new Perro();
            Console.WriteLine(gato1.EmitirSonido());// Esto ssi muestra la implememntacion de gato por que el tipo de refencia en GATo
            Console.WriteLine(perro1.EmitirSonido());
            //se usa cuando se necesita ocultar una implementacion de la clase base para q no rompa por que en una clase derivada NO puede usar el metodo  por q es obsoleto o rompe todo
        }
    }
}
