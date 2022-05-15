using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraParaTestUnitario
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion()
        {
        }

        public MiExcepcion(string message) : base("*****Excepcion para probas test unitarios****")
        {
        }

        public MiExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }

       
    }
}
