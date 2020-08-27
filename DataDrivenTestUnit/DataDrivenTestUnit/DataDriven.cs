using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataDrivenTestUnit
{
    [TestClass]
    public class DataDriven
    {
        //Perimitimos el acceso  a los datos
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource(@"Microsoft.VisualStudio.TestTools.DataSource.CSV",
             "|DataDirectory|\\DataInformation.csv", "DataInformation.csv", DataAccessMethod.Random)]
        public void ObtenerElNumeroMenorDeTresValores()
        {
            //Tiple AAA Arrange - Act- Assert
            //Arrange 
            var numero1 = Int32.Parse(TestContext.DataRow["numero1"].ToString());
            var numero2 = Int32.Parse(TestContext.DataRow["numero2"].ToString());
            var numero3 = Int32.Parse(TestContext.DataRow["numero3"].ToString());
            var esperado = Int32.Parse(TestContext.DataRow["resultado"].ToString());

            //Act
            var calcular = new Calcular();
            var actual = calcular.NumeroMenor(numero1, numero2,numero3);
            
            //Assert 
            Assert.AreEqual(esperado, actual);
        }
    }
}
