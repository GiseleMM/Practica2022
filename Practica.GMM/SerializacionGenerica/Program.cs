using System;
using System.Collections.Generic;
using System.Text;

namespace SerializacionGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serializacion Generica");

            Fenomeno f = new Fenomeno("Lucas", 33);
            Sequia s = new Sequia("Rosa", 40, 30);
            Inundacion i = new Inundacion("KATrina", 7999, 8888);
            List<Fenomeno> fenomenos = new List<Fenomeno>();
            fenomenos.Add(f);
            fenomenos.Add(s);
            fenomenos.Add(i);

            string ruta;
            List<string> rutas = new List<string>();
            int j = 0;
            foreach (var item in fenomenos)
            {

                ruta = Serializadora<Fenomeno>.Serializadora_StreamWriter($"fenomeno{j}.xml", item);
                j++;
                Console.WriteLine(ruta);
                rutas.Add(ruta);

            }


            //string ruta=Serializadora<Fenomeno>.Serializadora_StreamWriter("fenomeno.xml", f);

            //ruta = Serializadora<Fenomeno>.Serializadora_StreamWriter("Sequia.xml", s);

            //if (ruta is not null)
            //{
            //    Console.WriteLine(ruta);

            //}

            fenomenos.Clear();// si no lo agrego 2 veces
            foreach (var item in rutas)
            {
                fenomenos.Add( Serializadora<Fenomeno>.DeSerializar_StreamReader(item));

            }
            Program.Mostrar(fenomenos);



        }
        static void Mostrar(List<Fenomeno> lista)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Fenomeno item in lista)
            {
                sb.AppendLine("fenomeno");
                sb.AppendLine(item.Nombre);
                sb.AppendLine(item.Anio.ToString());
                sb.AppendLine("-----");
            }
            Console.WriteLine(sb.ToString());
          
        }

    }
}
