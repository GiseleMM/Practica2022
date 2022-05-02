using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoresEstaticosVsInstancia
{
    public  class Auto
    {
        private string marca;
        private string modelo;
        int cantidadDeHoras;
        static int precioPorHora;// comun a todos los autos


        static Auto()//contructor estaticos En  el Diagrama aparece con CANDADITO OJo los privados tambien aparecn con cadadito
        {
            precioPorHora = 100;
        }

        public Auto(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }
        public int GetCantidadHoras()
        {
            return this.cantidadDeHoras;
        }
        public void SetCantidadHoras(int value)
        {
            this.cantidadDeHoras = value;
        }
        public float CostoEstadia()
        {
            return (float)this.cantidadDeHoras * Auto.precioPorHora;

        }

        //llalmada Auto.SET.....
        public static void SetPrecioPorHora(int value)// Setea elvalor del precioPorHora DE TODOS LOS AUTOS xq es un atributo estatico
        {
            Auto.precioPorHora = value;
        }
        public static int GetPrecioPorHora()
        {
            return Auto.precioPorHora;
        }
        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("marca: {0}\n", this.marca);
            sb.AppendFormat(" modelo: {0}\n", this.modelo);
            sb.AppendFormat("cantidad de horas {0}\n", this.cantidadDeHoras);
            sb.AppendFormat("precio de estadia {0}\n", this.CostoEstadia());
            return sb.ToString();
        }


    }

}
