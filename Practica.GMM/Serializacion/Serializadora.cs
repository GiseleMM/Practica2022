using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion
{
    public class Serializadora
    {
        static string rutaBase;

        static Serializadora()
        {
            //creo directorio
            DirectoryInfo infor = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Archivos_serializados\\");

            //rutaBase = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Archivos_Serializados\\";
            // asrhivos serializado es una carpeta NO la tengo la creo
            rutaBase = infor.FullName;
        }

        public static  void Serializar_streamWriter(string nombreArchivo, Persona a)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter($"{Serializadora.rutaBase}{nombreArchivo}"))
                {
                    // para serializar usamos la claseXML   usig system.Xml.Serializaciom
                    XmlSerializer xml = new XmlSerializer(typeof(Persona));// creamos  una instancia  con el typo  del objeto q vamos a serializar
                                                                          // con metodo de instancia Serialize va a recibir el archivo y el alumno
                    xml.Serialize(sw, a);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en Clase {nameof(Serializadora)} metodo Serializar_stremWriter con parametros {nombreArchivo} ");
                Console.WriteLine(ex.Message);
            }

        }
        public static void Serializar_XmlTextWriter(string nombreArchivo,Persona a)
        {
            try
            {
                using (XmlTextWriter stream = new XmlTextWriter($"{Serializadora.rutaBase}{nombreArchivo}", Encoding.UTF8))// paso la ruta + codificacion utf8
                {
                    stream.Formatting = Formatting.Indented;//enumerado que indica la forma q se muestra >(Indentado )
                    
                    // para serializar usamos la claseXML   usig system.Xml.Serializaciom
                    XmlSerializer xml = new XmlSerializer(typeof(Persona));// creamos  una instancia  con el typo  del objeto q vamos a serializar
                                                                          // con metodo de instancia Serialize va a recibir el archivo y el alumno
                    xml.Serialize(stream, a);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en Clase {nameof(Serializadora)} metodo Serializar_XmlTextWriter con parametros {nombreArchivo} y ");
                Console.WriteLine(ex.Message);
            }

        }

        //DESERIALIZACION  con streamReader y con xmlTextReader 
        // se crea una una instacia del  xmlSerializar le indicamos el tipo
        // luego retornamos el objeto no un string dentrob de nuestro metodo vamos a tener q crear nuestro objeto
        // de tipo Alumno que va a contener el objeto q va a ser Deserealizado , al cual nosotros tenemos que castearlo  para el typo
        public static Persona Deserializar_StreamReader(string nombreArchivo)
        {
            Persona a = null;
            try
            {
                using (StreamReader sr = new StreamReader($"{Serializadora.rutaBase}{nombreArchivo}"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Persona));
                    a = xml.Deserialize(sr)as Persona;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Metodo deserializar_streamReader con paramentro");
                Console.Write(nombreArchivo);
                Console.WriteLine(e.Message);
            }
            return a;
        }
        // Importante si las propedades difieren de los nombres de las  propiedades del dato q quiero deserializar es  posible que no lo encuentre si el archivo ya produjo antes de la modif  
        public static Persona Deserializar_XmlTextReader(string nombreArchivo)
        {
            Persona a = null;
            try
            {
                using (XmlTextReader xmlReader = new XmlTextReader($"{Serializadora.rutaBase}{nombreArchivo}"))// SIN el Encoding
                {

                    XmlSerializer xml = new XmlSerializer(typeof(Persona));// loque va a convertir
                    a = xml.Deserialize(xmlReader) as Persona;// con esto paso del archivo.xml a objeto y con as casteo y obtengo alumno

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Metodo deserializar_xmlTextReader con paramentro");
                Console.Write(nombreArchivo);
                Console.WriteLine(e.Message);
            }
            return a;
        }


    }
}
