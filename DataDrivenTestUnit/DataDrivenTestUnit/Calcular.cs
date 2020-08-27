using System;

namespace DataDrivenTestUnit
{
    internal class Calcular
    {
        internal int NumeroMenor(int numero1, int numero2, int numero3)
        {
            return Math.Min(Math.Min(numero1, numero2), numero3);
        }
    }
}