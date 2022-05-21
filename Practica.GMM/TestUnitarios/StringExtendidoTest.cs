using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraParaTestUnitario;
namespace TestUnitarios
{

     [TestClass]   
    public class StringExtendidoTest
    {
        [TestMethod]
        public void ContarVocales_CuandoNoTieneVocales_DeberiaRetornarCero()
        {
            //arrange
            int expected = 0;
            string text = "yk jsd";

            //act del metodo estatico
            int actual=StringExtendido.ContarVocales(text);

            // asser
            Assert.AreEqual(expected, actual);
        }




        [TestMethod]
        public void ContarVocales_CuandoTieneDosVocales_DeberiaRetornarDos()
        {
            //arrange
            int expected = 2;
            string text = "yka ajsd";

            //act del metodo estatico
            int actual = StringExtendido.ContarVocales(text);

            // asser
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarVocales_CuandoPasoUnaVocalesEnMayuscula_DeberiaRetornarUna()
        {
            //arrange
            int expected = 1;
            string text = "ykAjsd";

            //act del metodo estatico
            int actual = StringExtendido.ContarVocales(text);

            // asser
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ContarVocales_CuandoPasoUnaVocalEnMayusculaYOtraEnminuscula_DeberiaRetornarDos()
        {
            //arrange
            int expected = 2;
            string text = "ykAjasd";

            //act del metodo estatico
            int actual = StringExtendido.ContarVocales(text);

            // asser
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void ContarVocales_CuandoTextoEsNull_DeberiaRetornarMiExceotion()
        {
            //arrange
            
            string text = null;

            //act del metodo estatico
            int actual = StringExtendido.ContarVocales(text);

            //    asser
            //    Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void ContarCaracter_CuandoTextoNoPasoCaracter_DeberiaRetornarCero()
        {
            //arrange
            int expected = 0;
            string text = "gj1";
            char caracter = ';';

            //act del metodo estatico extendido
            int actual = text.ContarCaracteres(caracter);

            // asser
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarCaracter_CuandoTextoPasoUnCaracter_DeberiaRetornarUno()
        {
            //arrange
            int expected = 1;
            string text = "g;1";
            char caracter = ';';

            //act del metodo estatico extendido
            int actual = text.ContarCaracteres(caracter);

            // asser
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void ContarCaracter_CuandoTextoPasoNull_DeberiaRetornarMiexcepcion()
        {
            //arrange
            
            string text =null;
            char caracter = ';';

            //act del metodo estatico extendido
            int actual = text.ContarCaracteres(caracter);

          
        }
    }


}
