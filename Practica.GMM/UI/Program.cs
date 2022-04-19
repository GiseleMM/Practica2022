using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        /*clase7: Los formularios son objetos
 * El metodo ShowDialog muestra un formulario de forma modal pero no  tenemos permitido accder
 * El metodo showDialog retorna un valor de tipo Dialog Result(enumeracion)
 * a otras ventanas hasta que salga de la ventana modal
 * Las Fomularios SON OBJETOS HAY que instanciarlos
 * el 1 formulari de Windows Forms se intancia en la clase program, es lo 1 q aparece en pantalla
 * el modificador partial permite separar la declaracion  de iina misma clase en 2 o mas archivos, en
 * el caso de los formularios  el diseño de  la logica. el compilador lo toma como uno solo.
 * el archivo donde me genera el .dll  esta en Bin debug
 * puedo agregar parametros de entarda al constructor de la clase formulario.
 * 
 * Consejo paraTP, Parciales:
 *  Concentrarse en la logica antes del diseño de formulario. muchos de los compoentes lo vammos
 *  a tener q buscar cada uno
 *  
 *  TEXTBoX hay uuna propiedad q te deja solo ingresar numeros
 *  pero mejor usar tryParse
 *  MATH.Round(6428.3535,5)redondea con 5 lugares despues de la coma
 */


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}
