using System;
using System.Collections.Generic;

namespace Ordenamientos
{
    internal class OrdenamientoShell
    {
        internal int[] ShellShort(int numero1, int numero2, int numero3, int numero4, int numero5, int numero6, int numero7, int numero8, int numero9)
        {


            var resultado = new[] { numero1, numero2, numero3, numero4, numero5, numero6, numero7, numero8, numero9 };

            /*Metodo de ordenamiento ShellShort=> Consiste en comparar los elementos con saltos de mayor tamano,
             pero con incrementos decrecientes, asi los elementos quedaran ordenados mas rapidamente*/

            int sizeArray = resultado.Length;//tama;o del array
            int inter = sizeArray / 2; // dividimos el array a la mitad y asi obtenemos el intervalo de salto 
            int temp;

            while (inter > 0) // miestras el salto o intervao de sakto sea mayor a 0
            {
                for (int i = 0; i + inter < sizeArray; i++)
                {
                    int j = i + inter;
                    temp = resultado[j];

                    while (j - inter >= 0 && temp < resultado[j - inter])
                    {
                        resultado[j] = resultado[j - inter];
                        j = j - inter;
                    }

                    resultado[j] = temp;
                }

                inter = inter / 2;
            }




            return resultado;



        }

        internal int[] bubbleSort(int numero1, int numero2, int numero3, int numero4, int numero5, int numero6, int numero7, int numero8, int numero9)
        {

            var resultado = new[] { numero1, numero2, numero3, numero4, numero5, numero6, numero7, numero8, numero9 };
            int pivote = 0;

            for (int i = 0; i < resultado.Length; i++)
            {
                for (int j = 0; j < resultado.Length - 1; j++)
                {
                    if (resultado[j] > resultado[j + 1])
                    {
                        pivote = resultado[j + 1];
                        resultado[j + 1] = resultado[j];
                        resultado[j] = pivote;
                    }
                }
            }


            return resultado;




        }


        internal int[] quickSort(int numero1, int numero2, int numero3)
        {
            //Declaramos una variable y gradamos en un array los valores que recibimos
            var resultado = new[] { numero1, numero2, numero3};

            int left = 0;
            int right =  resultado.Length-1;
            int i = left;
            int j = right;

            var pivot = resultado[(left + right) / 2];

            while (i <= j)
            {
                while (resultado[i] < pivot)
                    i++;

                while (resultado[j] > pivot)
                    j--;

                if (i <= j)
                {
                    var tmp = resultado[i];
                    resultado[i] = resultado[j];
                    resultado[j] = tmp;

                    i++;
                    j--;
                }
            }



            return resultado;
        }

       /* internal int[] heapSort(int numero1, int numero2, int numero3)
        {
            //Declaramos una variable y gradamos en un array los valores que recibimos
            var resultado = new[] { numero1, numero2, numero3 };

          

            return resultado;
        }
        */
    }


}