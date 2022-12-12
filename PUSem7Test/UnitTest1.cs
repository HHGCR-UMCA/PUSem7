using Microsoft.VisualStudio.TestTools.UnitTesting;
using PUSem7;

namespace PUSem7Test
{
    [TestClass]
    public class UnitTest1
    {

        [DataRow(4, 4, 8)]
        [DataRow(4, 5, 9)]
        [DataRow(5, 5, 10)]
        [TestMethod]
        public void Suma_RetornaValor(int a, int b, int esperado)
        {
            ////Arrange
            //int a = 4;
            //int b = 4;
            //int esperado = 8;

            //Act
            int actual = clsCalculadora.suma(a, b);


            //resultado
            Assert.AreEqual(actual, esperado);

        }

        [DataRow(4, 4, 0)]
        [DataRow(4, 0, 4)]
        [DataRow(20, 5, 15)]
        [TestMethod]
        public void Resta_RetornaValor(int a, int b, int esperado)
        {
            ////Arrange
            //int a = 4;
            //int b = 4;
            //int esperado = 0;

            //Act
            int actual = clsCalculadora.resta(a, b);


            //resultado
            Assert.AreEqual(actual, esperado);

        }

        [DataRow(4, 4, 16)]
        [DataRow(4, 0, 0)]
        [DataRow(20, 5, 100)]
        [TestMethod]
        public void Multiplica_RetornaValor(int a, int b, int esperado)
        {
            int actual = clsCalculadora.multi(a, b);


            //resultado
            Assert.AreEqual(actual, esperado);

        }

        [DataRow(4, 0, -1)]
        [DataRow(24, 6, 4)]
        [DataRow(20, 5, 4)]
        [TestMethod]
        public void Divide_RetornaValor(int a, int b, int esperado)
        {
            int actual = clsCalculadora.div(a, b);


            //resultado
            Assert.AreEqual(actual, esperado);

        }
    }
        
}
