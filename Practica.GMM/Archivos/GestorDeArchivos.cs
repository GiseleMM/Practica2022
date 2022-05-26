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
                sw.WriteLine(contenido);
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


    }
}
