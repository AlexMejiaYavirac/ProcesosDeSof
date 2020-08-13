using System;

namespace Factorial.Logica
{
    public class Factoriall
    {


        public int factorial(int numero)
        {
            int resultado = 1;
            if (numero < 1)
            {
                resultado = 1;
            }
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    resultado = resultado * i;
                }
            }
            return resultado;
        }

    }
}
