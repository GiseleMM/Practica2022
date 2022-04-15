using System;

namespace SobrecargaV5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOBRECARGA");
 
           //---------------------------SOBRECARGAR DE METODOS-----------------------------------

           // sobrecarga es por que estamoa fuera de la clase y tiene metodos estaticos
            Console.WriteLine($"{ Sobrecarga.Sumar(1, 2)}"  );
            Console.WriteLine($"{ Sobrecarga.Sumar(1, 2,6)}");
            Console.WriteLine($"{Sobrecarga.Concatenar("HOla","mundo")}");
            Console.WriteLine($"{Sobrecarga.Concatenar("HOla", "mundo",4)}");
            Console.WriteLine($"{Sobrecarga.Mostrar("Gisele", "Medina")}");
            //parametro opcianal al final y darle valor 
            Console.WriteLine($"{Sobrecarga.Mostrar("Gisele", "Medina",33)}");

            //-------------------------SOBRECARGA DE CONTRUCTORES--------------
            Persona pers1 = new Persona();
            Persona pers2 = new Persona("Jonathan", new DateTime(1991, 10, 11), 333333333);
            Console.WriteLine(  pers1.Mostrar());
            Console.WriteLine(  pers2.Mostrar());

            Persona pers3 = new Persona("Rosa");
            Console.WriteLine(pers3.Mostrar());
            Persona pers4 = new Persona("Nestor", new DateTime(2000, 2, 3));
            Console.WriteLine(pers4.Mostrar());

            //--------------------------SOBRECARGA DE OPERARDORES----------------
            Console.WriteLine(pers4==pers3);//el operador == no retorna si tienen lo mismo parametros
                                            //el operador == por defecto  el valor interno de los  atributos
                                            // lo que valida es las  instancias,ai estan en la mmisma direccion de memoria
            Persona pers5 = pers4; //no la creo  solo asigno referencia
            Console.WriteLine(pers4==pers5);
            Console.WriteLine(pers3 != pers2);

            Aula aula = new Aula();//creo objeto aula
            aula=aula+ pers1;

            //------------------------SOBRECARGA DE CONVERSION-------------------------
            long dni = pers2;
            Console.WriteLine($"dni:{dni}");
            Console.WriteLine($"nombre: {(string)pers2}");
            


  

        }
    }
}
