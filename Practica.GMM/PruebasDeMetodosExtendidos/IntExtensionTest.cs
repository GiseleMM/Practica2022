using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetodosExtendidosI02Contadordedígitos;
namespace PruebasDeMetodosExtendidos
{
    [TestClass]
    public class IntExtensionTest
    {
        [TestMethod]
        public void ContarCantidadDeDigitos_CuandoLePasemosUno_DeberiaRetornarUno()
        {
            //arrenge 
            long numero = 1;
            int expected = 1;

            //Act
            int actual = numero.ContarCantidadDeDigitos();
            //IntExtension.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void ContarCantidadDeDigitos_CuandoLePasemosCien_DeberiaRetornarTres()
        {
            //arrenge 
            long numero = 100;
            int expected = 3;

            //Act
            int actual = numero.ContarCantidadDeDigitos();
            //IntExtension.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ContarCantidadDeDigitos_CuandoLePasemosDiezNegativo_DeberiaRetornarDos()
        {
            //arrenge 
            long numero = -10;
            int expected = 2;

            //Act
            int actual = numero.ContarCantidadDeDigitos();
            //IntExtension.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
