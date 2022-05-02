using System;

namespace Sobrecargas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sobrecargas metodos" );
            Console.WriteLine(Validadora.ValidarRango(3, 10));
            Console.WriteLine(Validadora.ValidarRango(3, 2));
            Console.WriteLine(Validadora.ValidarRango(3, 10,3));
            Console.WriteLine(Validadora.ValidarRango(3,10,4));

            Console.WriteLine("Sobrecargas Constructores");
            Tiempo t1 = new Tiempo(4);
            Tiempo t2 = new Tiempo(4, 3, 50);
            Console.WriteLine(t1.MostrarTiempo());
            Console.WriteLine(t2.MostrarTiempo());

            //Console.WriteLine(t1 == t2);//Los objetos el ==compara direcciones dememoria
            Console.WriteLine("Sobrecarga de Operadores");
            Tiempo t3 = new Tiempo(4, 3, 50);
            Console.WriteLine(t3.MostrarTiempo());
            Console.WriteLine(t2.MostrarTiempo());
            Console.WriteLine(t3 == t2);// sobrecarge == y !=
            Console.WriteLine(Object.ReferenceEquals(t2, t3)); // veo referencia

            Console.WriteLine("sobrecarga de Conversion");
            Tiempo t4 = new Tiempo(1);
            Console.WriteLine(t4.MostrarTiempo());
            int segundos = t4;// comvierto obj tiempo en int implicitamente NO necesite casting
            Console.WriteLine(segundos);
            Tiempo t5 = (Tiempo)"10:20:00";// conv explicita de string a tiempo
            Console.WriteLine(t5.MostrarTiempo());


        }
    }
}
