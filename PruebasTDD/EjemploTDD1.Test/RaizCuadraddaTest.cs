using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EjemploTDD1;

namespace EjemploTDD1.Test
{
    [TestClass]
    public class RaizCuadraddaTest
    {
        [TestMethod]
        public void RaizCuadrada_0()
        {

            //Arrange: Crear el entorno de Trabajo
            RaizCuadrada service = new RaizCuadrada();

            //Act: Operacion
            double result = service.CalcularRaizCuadrada(0);

            //Asset: Verificar la condicion o el criterio de aceptacion de la prueba
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void RaizCuadrada_4()
        {
            //Arrange: Crear el entorno de Trabajo
            RaizCuadrada service = new RaizCuadrada();

            //Act: Operacion
            double result = service.CalcularRaizCuadrada(4);

            //Asset: Verificar la condicion o el criterio de aceptacion de la prueba
            Assert.AreEqual(2, result);
        }
    }
}
