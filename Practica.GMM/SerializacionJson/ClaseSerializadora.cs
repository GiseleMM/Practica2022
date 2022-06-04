using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializacionJson
{
    public class ClaseSerializadora<T>
    {
        public static string rutaBase;
        public static string rutaProyecto;
     
        static ClaseSerializadora()
        {
            DirectoryInfo info = Directory.CreateDirectory("Archivos_Serializados\\");// Creo carpeta en Debug del proyecto SI PONGO ("\\Archivo\\") crea carpeta en C:\\ 

            rutaBase = info.FullName;
            rutaProyecto = AppDomain.CurrentDomain.BaseDirectory;// me paro en el proyecto
          
        }
        public static string Escribir(T objecto, string archivo)
        {

            //string rutaCompleta = rutaBase + "archivo_"+DateTime.Now.ToString("HH_mm_ss")+ ".xml";// esto sirve pero no permite identificar q archivo tengo
            string rutaCompleta = rutaBase + archivo;
            //if(!rutaCompleta.EndsWith(".xml"))
            //{
            //    throw new Exception(" nombre de archivo sin extension");
            //}  
       
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(sw, objecto);
                }
            }
            catch(Exception )
            {
                throw;
            }

            return rutaCompleta;
        }
        public static T Leer(string archivo)
        {
            T objetoDeSerializado = default(T);
            string rutaDeObjeto = string.Empty;
            string[] rutas = Directory.GetFiles(rutaBase);// esto me para en la carpeta q creer de Archivos
                                                          // serializados donde estan todas las rutas y me
                                                          // retorna un array con todas las rutas a los archivos

            if( rutas is not null)
            {
                foreach (string item in rutas)
                {
                    if(item.Contains(archivo))
                    {
                        rutaDeObjeto = item;
                        break;
                    }
                }
            }
            if(!string.IsNullOrEmpty(rutaDeObjeto))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(rutaDeObjeto))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(T));
                        objetoDeSerializado = (T)ser.Deserialize(reader);// as no puedo usar si no lo restringo a class

                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return objetoDeSerializado;

        }
        

       
       


    }
}
