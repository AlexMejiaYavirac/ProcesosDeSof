using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;
using static Mocks.ICalcular;

namespace Mocks
{
    /// <summary>
    /// Summary description for JustMockTest
    /// </summary>
    [TestClass]
    public class JustMockTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod()
        {
            //Arrange 
            var warehouse = Mock.Create<Iwarehouse>();
            var order = new Order("Camera", 2);

            bool called = false;
            Mock.Arrange(() => warehouse.HasInventory("Camera", 2)).DoInstead(() => called = true);

            //Act 
            order.Fill(warehouse);

            //Assert 
            Assert.IsTrue(called);
        }

        //Ejemplo numero 1
        //Compracion de dos numeros

        [TestMethod]
        public void NumeroMayor()
        {
            //Arrange 
            var calcular = Mock.Create<ICalcular>();
            var mayor = new Mayor(5, 2);
            int esperado = 5;

            Mock.Arrange(() => calcular.obtenerMayor(5, 2)).Returns(esperado);

            //Act 
           int actual =  mayor.resultadoMayor(calcular);

            //Assert 
            Assert.AreEqual(esperado,actual);
        }


        //Ejemplo numero 2
        //Area de rectángulo  

        [TestMethod]
        public void Comparaciond()
        {
            //Arrange 
            var calcular = Mock.Create<ICalcular>();
            var mayor = new Mayor(20, 10);
            int esperado = 200;

            Mock.Arrange(() => calcular.obtenerAreaRectangulo(20, 10)).Returns(esperado);

            //Act 
            int actual = mayor.resultadoAreaResctangulo(calcular);

            //Assert 
            Assert.AreEqual(esperado, actual);
        }



        //Ejemplo numero 3
        //Area de triangulo   

        [TestMethod]
        public void AreaTriangulo()
        {
            //Arrange 
            var calcular = Mock.Create<ICalcular>();
            var mayor = new Mayor(20, 10);
            int esperado = 100;

            Mock.Arrange(() => calcular.obtenerAreaTriangulo(20, 10)).Returns(esperado);

            //Act 
            int actual = mayor.resultadoAreaTriangulo(calcular);

            //Assert 
            Assert.AreEqual(esperado, actual);
        }



        //Ejemplo numero 4
        //Iva precio total (12%)    

        [TestMethod]
        public void Iva()
        {
            //Arrange 
            var calcular = Mock.Create<ICalcular>();
            var mayor = new Mayor(20,25);
            double esperado = 5.4;

            Mock.Arrange(() => calcular.obtenerIva(20, 25)).Returns(esperado);

            //Act 
            double actual = mayor.resultadoIva(calcular);

            //Assert 
            Assert.AreEqual(esperado, actual);
        }


        //Ejemplo numero 5
        //resta de dos numeros 
        [TestMethod]
        public void CalculoResta()
        {
            //Arrange 
            var calcular = Mock.Create<ICalcular>();
            var mayor = new Mayor(9, 16);
            int esperado = -7;

            Mock.Arrange(() => calcular.obtenerResta(9, 16)).Returns(esperado);

            //Act 
            int actual = mayor.resultadoResta(calcular);

            //Assert 
            Assert.AreEqual(esperado, actual);
        }

    }
}
