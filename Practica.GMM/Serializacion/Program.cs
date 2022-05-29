using System;
using System.Collections.Generic;

namespace Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SERIALIZACIOM");
            // estado del objeto  la foto en un determinado momento
            // Serializar:transformar al objeto en un determinado formato o secuencia de bytes
            // dos:  Xml  y Json
            // XML reqisitos : constructor public sin parametros y atributos publicos o expuestos en solo  lectura
            // diseñado para transferir dato, case sensitive ,  usa etiquetas
            // vamos a aser uso de la clase XmlSerializar ,tenemos q crear un obj al cual le pasomo
            //el typo de objeto del cual estamos trabajando con typeof(objetoaserializar)


            //Alumno a = new Alumno("Gisele", 33);
            // List<string> m = a.Materias;
            //  m.Add("boca");
            //  m.Add("banfield");


            //Console.WriteLine(a.ToString());
            //Serializadora.Serializar_streamWriter("alumno.xml", a);
            //Serializadora.Serializar_XmlTextWriter("alumno2.xml", a);

            //Alumno b= Serializadora.Deserializar_StreamReader("alumno2.xml");
            //Console.WriteLine(b.ToString());
            //Alumno c = Serializadora.Deserializar_XmlTextReader("alumno.xml");
            //Console.WriteLine(c.ToString());


            //Persona alumno = new Alumno("Lucas", 4);
            //List<string> m = ((Alumno)alumno).Materias;
            //m.Add("veo veo");
            //m.Add("q vez");
            //Serializadora.Serializar_streamWriter("alumnoConHerencia.xml", alumno);
            //Persona p = new Profesor("Mario", 44, "ggggg");
            //Serializadora.Serializar_streamWriter("ProfeConHerencia.xml", p);


            Profesor p2 = Serializadora.Deserializar_StreamReader("ProfeConHerencia.xml") as Profesor; 
            if(p2 is not null)
            {
                Console.WriteLine(p2.ToString());
            }
            Alumno a3 = Serializadora.Deserializar_StreamReader("alumnoConHerencia.xml") as Alumno;// alumno.xml no lo desSerialize  por que modique la clase con Herencia y no  lo toma
            if(a3 is not null)
            {
                Console.WriteLine(a3.ToString());
            }
            Alumno a4 = Serializadora.Deserializar_StreamReader("alumno.xml") as Alumno;// alumno.xml  lo pude deserializar por que lo volvi a serializar con las modificaciones q hice a la clase
            {
                Console.WriteLine(a4.ToString());
            }
        }
    }
}
