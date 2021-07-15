using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EjemploTDD2;

namespace EjemploTDD2.Test
{
    [TestClass]
    public class FactorialTest
    {
        [TestMethod]
        public void PruebaFactorial_0()
        {
            //Arrange
            Factorial service = new Factorial();

            //Act
            int result = service.CalcularFactorial(0);

            //Assert

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void PruebaFactorial_1()
        {
            //Arrange
            Factorial service = new Factorial();

            //Act
            int result = service.CalcularFactorial(1);

            //Assert

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void PruebaFactorial_5()
        {
            //Arrange
            Factorial service = new Factorial();

            //Act
            int result = service.CalcularFactorial(5);

            //Assert

            Assert.AreEqual(120, result);
        }
    }
}
