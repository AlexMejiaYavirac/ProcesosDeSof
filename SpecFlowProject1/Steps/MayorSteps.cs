using Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;


namespace SpecFlowProject1.Steps
{
    [Binding]
    public class MayorSteps
    {

        Calculator calculator = new Calculator();
        int resultado;
        int number1;
        int number2; 


        [Given(@"one  number is (.*)")]
        public void GivenOneNumberIs(int numero1)
        {
            this.number1 = numero1;
        }
        
        [Given(@"two number is (.*)")]
        public void GivenTwoNumberIs(int numero2)
        {
            this.number2 = numero2;
        }
        
        [When(@"the two numbers compared")]
        public void WhenTheTwoNumbersCompared()
        {
            resultado = calculator.Mayor(number1, number2);
        }
        
        [Then(@"the greater is (.*)")]
        public void ThenTheGreaterIs(int result)
        {
            Assert.AreEqual(resultado, result);
        }
    }
}
