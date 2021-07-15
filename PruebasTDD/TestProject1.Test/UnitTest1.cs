using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjemploTDD1;
namespace TestProject1.Test
{
    [TestClass]
    public class UnitTest1
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
    }
}
