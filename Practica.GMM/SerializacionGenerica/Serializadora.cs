using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializacionGenerica
{
    public class Serializadora<T> where T : class, new ()
    {
        static string rutaBase;

        static Serializadora()
        {
            //creo directorio
            DirectoryInfo infor = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Archivos_serializadoGenericos\\");

           
            rutaBase = infor.FullName;
        }


        public static string Serializadora_StreamWriter(string nombreArchivo, T objeto)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter ($"{Serializadora<T>.rutaBase}{nombreArchivo}"))// abro archivo para escritura
                {
                    XmlSerializer xmlserializer = new XmlSerializer(typeof(T));// creo instancia de clase xmlserializer a la q le  paso el tipo de dato a conv
                    xmlserializer.Serialize(sw, objeto);
                   

                }
            }
            catch (Exception)
            {

                throw;
            }
            
            return rutaBase+nombreArchivo;
        }
        public static T DeSerializar_StreamReader(string rutaCompleta)
        {
            T objecto = default(T);
            try
            {
                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    objecto = xmlSerializer.Deserialize(sr) as T;// Si no pongo resctriccion que sea class  no lo toma por mas  de q tenga el new()
                }
            }
            catch (Exception)
            {

                throw;
            }
            return objecto;

        }

    }
}
