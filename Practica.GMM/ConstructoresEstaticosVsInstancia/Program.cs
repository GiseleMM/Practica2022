using System;

namespace ConstructoresEstaticosVsInstancia
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto("jajs", "888");
            Auto a2 = new("zzzzz", "7777");
          
            Console.WriteLine("Precio por hora "+ Auto.GetPrecioPorHora());
            a1.SetCantidadHoras(3);
            Console.WriteLine(a1.MostrarAuto());
            Auto.SetPrecioPorHora(1000);
            Console.WriteLine("Precio por hora " + Auto.GetPrecioPorHora());
          
            Console.WriteLine(a1.MostrarAuto());
            a2.SetCantidadHoras(5);
            Console.WriteLine(a2.MostrarAuto());
        }
    }
}
