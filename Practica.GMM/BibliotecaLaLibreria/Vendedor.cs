using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLaLibreria
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;


        private Vendedor()
        {
            ventas = new List<Publicacion>();
        }
        public Vendedor(string nombre):this()
        {
            this.nombre = nombre;
        }
        public string ObtenerInformeDeVentas(Vendedor vendedor)
        {
            float acumuladorImporte = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE {vendedor.nombre}");
            sb.AppendLine("------------------------");
            sb.AppendLine($"PUBLICACION : {vendedor.ventas.Count}");
            sb.AppendLine("--------------------------");
            foreach (Publicacion item in vendedor.ventas)
            {
                sb.Append($"{item.ObtenerInformacion()}");
                acumuladorImporte = +item.Importe;
            }
            sb.AppendLine($"Ganancias Total: $ {acumuladorImporte.ToString()}");
            return sb.ToString();
        }
        public static bool operator +(Vendedor vendedor, Publicacion publicacion)
        {
            bool agregado = false;
            if(publicacion.HayStock)
            {
                vendedor.ventas.Add(publicacion);
                int stock = publicacion.Stock;
                publicacion.Stock = stock-1;
                agregado = true;
            }
            return agregado;
        }



    }
}
