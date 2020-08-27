using System;

namespace Mocks
{
    public class Mayor
    {
        private int numero1;
        private int numero2;

        public Mayor(int numero1, int numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }



        internal int resultadoMayor(ICalcular warehouse)
        {
            if (numero1 < numero2)
            {
                return numero2;
            }
            else
            {
                return numero1;
            }
        }

        internal int resultadoAreaResctangulo(ICalcular calcular)
        {
            return numero1 * numero2;
        }

        internal int resultadoAreaTriangulo(ICalcular calcular)
        {
            return numero1 * numero2 / 2;
        }

        internal double resultadoIva(ICalcular calcular)
        {
            return Math.Round((numero1 + numero2) * 0.12 , 1); 
                }

        internal int resultadoResta(ICalcular calcular)
        {
            return numero1 - numero2; 
        }
    }
}