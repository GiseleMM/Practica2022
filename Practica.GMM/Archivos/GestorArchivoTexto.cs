using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Archivos
{
    public class GestorArchivoTexto : IArchivos<string>
    {
        static string rutaBase = string.Empty;
        static GestorArchivoTexto()
        {
            rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
        public bool Escribir(string ruta, string dato, bool append)
        {
            bool seEscribio = false;
            try
            {
                using (StreamWriter escrito = new StreamWriter($"{GestorArchivoTexto.rutaBase}\\{ruta}"))
                {
                    escrito.WriteLine(dato, append);
                    seEscribio = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return seEscribio;
        }

        public string Leer(string ruta)
        {
            string leido = string.Empty;
            try
            {
                using (StreamReader lectura = new StreamReader($"{GestorArchivoTexto.rutaBase}\\{ruta}"))
                {
                    leido=lectura.ReadToEnd();
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
            return leido;
        }
    }
}
