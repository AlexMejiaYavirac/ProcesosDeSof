using Factorial.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using TechTalk.SpecFlow;

namespace Factorial.BDD.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        
        Factoriall factorial = new Factoriall();
        int numero;
        int resultado;

        [Given(@"that a one number (.*)")]
        public void GivenThatAOneNumber(int number)
        {
            this.numero = number;
            
        }
        
        [When(@"the algorimenth to realize the operation")]
        public void WhenTheAlgorimenthToRealizeTheOperation()
        {
           resultado = factorial.factorial(numero);
        }
        
        [Then(@"the result is equal (.*)")]
        public void ThenTheResultIsEqual(int result)
        {
            Assert.AreEqual(result, resultado);
        }
    }
}
