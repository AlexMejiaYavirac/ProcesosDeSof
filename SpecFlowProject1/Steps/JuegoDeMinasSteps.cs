using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class JuegoDeMinasSteps
    {
        IWebDriver webDriver = new ChromeDriver(@"C:\Users\alexp\source\repos\SpecFlowProject1\SoftwareTerceros");

        [Given(@"que estoy en el sistema")]
        public void DadoQueEstoyEnElSistema()
        {
            webDriver.Url = "http://localhost:80/MinesWeeper";
            webDriver.Navigate();
            webDriver.FindElement(By.Name("irLogeo")).Click();
        }
        
        [When(@"registro mi nombre ""(.*)""")]
        public void CuandoRegistroMi(string nombre)
        {
            webDriver.Url = "http://localhost:80/MinesWeeper/Views/login.html";
            webDriver.Navigate();
            var element = webDriver.FindElement(By.Name("username"));
            element.SendKeys(nombre);
            var boton = webDriver.FindElement(By.Name("aceptar"));
            boton.Click();

        }
        
        [Then(@"el juego inicializa")]
        public void EntoncesElJuegoInicializa()
        {
            webDriver.Url = "http://localhost/MinesWeeper/Views/game.html";

            Assert.IsTrue(true);
        }
    }
}
