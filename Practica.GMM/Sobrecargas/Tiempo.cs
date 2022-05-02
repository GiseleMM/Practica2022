using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecargas
{
    public class Tiempo
    {
        public int hora;
        public int minuto;
        public int segundo;

      

        public Tiempo(int hora, int minuto)
        {
            this.hora = hora;
            this.minuto = minuto;
        }

        public Tiempo(int hora, int minuto, int segundo): this(hora,minuto)
        {
            //this.hora = hora;
            //this.minuto = minuto;
            this.segundo = segundo;
        }
        public Tiempo(int hora):  this(hora,0)// harcodeo el el segundo parametro
        {


        }

        public string MostrarTiempo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"hora: {this.hora} minutos: {this.minuto} segundos :{this.segundo}");
            return sb.ToString();
            
        }

        // sobrecarga de  operadores
        public static bool operator==(Tiempo t1, Tiempo t2)
        {
            bool sonIguales = false;
            if( t1.hora== t2.hora && t1.minuto== t2.minuto && t1.segundo == t2.segundo)
            {
                sonIguales = true;
            }
            return sonIguales;
        }
        public static bool operator !=(Tiempo t1, Tiempo t2)
        {
            return !(t1 == t2);
        }
        // sobrecarga de conversion
        /// <summary>
        /// Conversion implicit de tiempo a segundos
        /// </summary>
        /// <param name="t"></param>
        public static implicit operator int (Tiempo t)
        {
            return ((((t.hora*60)+t.minuto)* 60)+t.segundo);
        }
        public static explicit operator Tiempo (string stringTiempo)
        {
            string[] tString = stringTiempo.Split(":");
            // lo guarda como un array de string y en el constructor lo recibo como int tengo que castear

            Tiempo t = new Tiempo(int.Parse(tString[0]), int.Parse(tString[1]),int.Parse(tString[2]));
            return t;
        
        }










        //PARA ELIMINAR SERRUCHO
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
