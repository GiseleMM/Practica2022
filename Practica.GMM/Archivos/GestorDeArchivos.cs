using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public static class GestorDeArchivos
    {
        static string rutaBaseEscritorio;
       static GestorDeArchivos()
        {
            GestorDeArchivos.rutaBaseEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
        public static bool Escribir(string path, string contenido, bool append)//append determina si concateno(true) o sobreescribo(false)
        {
            bool seEscribio = false;
            StreamWriter sw = null;
            try
            {
                string rutaCompleta = $"{GestorDeArchivos.rutaBaseEscritorio}\\{path}";
                sw = new StreamWriter(rutaCompleta, append);
                sw.WriteLine(contenido);//con salto de linea
                seEscribio = true;
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(sw!=null)// si es distinto de null cierro archivo
                {
                    sw.Close();
                }
            }
            return seEscribio;
        }

        public static bool Escribir(string path, string contenido)
        {
            
            bool seEscribio = false;
            try
            {
                using (StreamWriter sw = new StreamWriter($"{GestorDeArchivos.rutaBaseEscritorio}\\{path}"))// si poongo path solo lo crea en la carpeta del protyecto
                {// solo  usar using para instanciar objectos q implementen la interface IDisponsable q una vez terminados de usar se destruye solo no tengo q cerrar el archivo
                    sw.WriteLine(contenido);
                    seEscribio = true;
                }
            }catch(Exception)
            {
                throw;
            }
            return seEscribio;
        }


    }
}
