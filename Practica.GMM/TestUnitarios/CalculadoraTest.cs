using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculadoraParaTestUnitario;
namespace TestUnitarios
{
    [TestClass]// atributo q le indican al compilador q esta clase es una clase de prueba
    public class CalculadoraTest// la clase de tst se llame igual a la clase a probar
    {
        [TestMethod]// atributo q le indica al compilador q esto q va a escribir es un metodo de prueba
        public void Dividir_CuandoElDivissorEsCEro_DeberiaRetornarDoubleMinValue()// siempre publico y no debe retornar nada
        {
            //arrange: preparar el caso de prueba
            double divisor = 0;
            Calculadora calculadora = new Calculadora();
            double resulatadoEsperado = double.MinValue;

            //act: invocar el metodo a probar
            double resultado = calculadora.Dividir(3, divisor);

            //assert:verifico q el resulatdo sea el esperado
            Assert.AreEqual(resulatadoEsperado, resultado);
            //assert tiene muchos metodos estaticos
        }
        [TestMethod]// atributo q le indica al compilador q esto q va a escribir es un metodo de prueba
        public void Dividir_CuandoElDivissorNoEsCero_DeberiaRetornarResulatado()// siempre publico y no debe retornar nada
        {
            //arrange: preparar el caso de prueba
            double divisor = 3;
            Calculadora calculadora = new Calculadora();
            double resulatadoEsperado = 1;

            //act: invocar el metodo a probar
            double resultado = calculadora.Dividir(3, divisor);

            //assert:verifico q el resulatdo sea el esperado
            Assert.AreEqual(resulatadoEsperado, resultado);
            //assert tiene muchos metodos estaticos
        }
        //No es correcto instanciar solo una vez los valores de las varibles en el arrange y usrarlos en todas las pruebas por que un fallo
        //   no es propio de esa prueba, las pruebas tienen que estar aisladas y no depender de la ejecucion de otras pruebas o verse lo menos
        // afectadas por ejecuciones de anteriores. UNO debe volver a instanciar en cada prueba No es correcto   solo usar una variables para todo el testing
        // la  buena practica es que sean los mas independientes  posibles
    }
}
