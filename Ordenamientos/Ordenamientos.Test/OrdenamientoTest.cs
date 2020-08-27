using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ordenamientos
{
    [TestClass]
    public class OrdenamientoTest
    {
        [TestMethod]
        public void shellShort()
        {
            // Triple A => Arrange, act, assert
            var numero1 = 2;
            var numero2 = 8;
            var numero3 = 5;
            var numero4 = 25;
            var numero5 = 10;
            var numero6 = 80;
            var numero7 = 20;
            var numero8 = 9;
            var numero9 = 60;

            var esperado1 =  2;
            var esperado2=  5;
            var esperado3 =  8;
            var esperado4 =  9;
            var esperado5=  10;
            var esperado6 =  20;
            var esperado7 =  25;
            var esperado8=  60;
            var esperado9 =  80;

        OrdenamientoShell ordenamientoshell = new OrdenamientoShell();
        int [] esperados = ordenamientoshell.ShellShort(numero1,numero2,numero3,numero4,numero5,numero6,numero7,numero8,numero9);


        Assert.AreEqual(esperado1,esperados[0]);
        Assert.AreEqual(esperado2,esperados[1]);
        Assert.AreEqual(esperado3,esperados[2]);
        Assert.AreEqual(esperado4,esperados[3]);
        Assert.AreEqual(esperado5,esperados[4]);
        Assert.AreEqual(esperado6,esperados[5]);
        Assert.AreEqual(esperado7,esperados[6]);
        Assert.AreEqual(esperado8,esperados[7]);
        Assert.AreEqual(esperado9,esperados[8]);
        

            
        }


         [TestMethod]
        public void bubbleSort()
        {
            // Triple A => Arrange, act, assert
            var numero1 = 2;
            var numero2 = 8;
            var numero3 = 5;
            var numero4 = 25;
            var numero5 = 10;
            var numero6 = 80;
            var numero7 = 20;
            var numero8 = 9;
            var numero9 = 60;

            var esperado1 =  2;
            var esperado2=  5;
            var esperado3 =  8;
            var esperado4 =  9;
            var esperado5=  10;
            var esperado6 =  20;
            var esperado7 =  25;
            var esperado8=  60;
            var esperado9 =  80;

        OrdenamientoShell ordenamientoshell = new OrdenamientoShell();
        int [] esperados = ordenamientoshell.bubbleSort(numero1,numero2,numero3,numero4,numero5,numero6,numero7,numero8,numero9);

         Assert.AreEqual(esperado1,esperados[0]);
        Assert.AreEqual(esperado2,esperados[1]);
        Assert.AreEqual(esperado3,esperados[2]);
        Assert.AreEqual(esperado4,esperados[3]);
        Assert.AreEqual(esperado5,esperados[4]);
        Assert.AreEqual(esperado6,esperados[5]);
        Assert.AreEqual(esperado7,esperados[6]);
        Assert.AreEqual(esperado8,esperados[7]);
        Assert.AreEqual(esperado9,esperados[8]);

            
        }


        [TestMethod]
        public void quickSort()
        {
            // Triple A => Arrange, act, assert
            var numero1 = 2;
            var numero2 = 8;
            var numero3 = 5;
       

            var esperado1 =  2;
            var esperado2=  5;
            var esperado3 =  8;
     

        OrdenamientoShell ordenamientoshell = new OrdenamientoShell();
       
        int [] esperados = ordenamientoshell.quickSort(numero1,numero2,numero3);

        Assert.AreEqual(esperado1,esperados[0]);
        Assert.AreEqual(esperado2,esperados[1]);
        Assert.AreEqual(esperado3,esperados[2]);
      
            
        }


         [TestMethod]
        public void heapSort()
        {
            // Triple A => Arrange, act, assert
            var numero1 = 50;
            var numero2 = 20;
            var numero3 = 5;

            var esperado1 =  5;
            var esperado2=  20;
            var esperado3 =  50;

        OrdenamientoShell ordenamientoshell = new OrdenamientoShell();
        int [] esperados = ordenamientoshell.heapSort(numero1,numero2,numero3);

        Assert.AreEqual(esperado1,esperados[0]);
        Assert.AreEqual(esperado2,esperados[1]);
        Assert.AreEqual(esperado3,esperados[2]);

            
        }
    
    
    }
}
