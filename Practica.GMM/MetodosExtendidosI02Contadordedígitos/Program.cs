using System;

namespace MetodosExtendidosI02Contadordedígitos
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrse un numero");
                string input = Console.ReadLine();
                if(Int64.TryParse(input,out Int64 numero))
                {
                    int contador=numero.ContarCantidadDeDigitos();//metodo de extension
                    Console.WriteLine("Numero  de {0,10} Digitos",contador);
                }
                else
                {
                    Console.WriteLine("valor ingresado invalido");
                }
            }
        }
    }
}
