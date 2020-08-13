using System;
using System.IO;
using System.Threading.Tasks;

namespace Matematica.Tests
{
    internal class Calculadora
    {
        internal int[,] Multiplicar(int[,] matrizA, int[,] matrizB)
        {
            int matACols = matrizA.GetLength(1);
            int matBCols = matrizB.GetLength(1);
            int matARows = matrizA.GetLength(0);
            int[,] resultado = new int[matARows, matBCols];

            for (int i = 0; i < matARows; i++)
            {
                for (int j = 0; j < matBCols; j++)
                {
                    int temp = 0;
                    for (int k = 0; k < matACols; k++)
                    {
                        temp += matrizA[i, k] * matrizB[k, j];
                    }
                    resultado[i, j] = temp;
                }
            }
            return resultado;
        }

        internal int[,] MultiplicarParalelo(int[,] matrizA, int[,] matrizB)
        {
            int matACols = matrizA.GetLength(1);
            int matBCols = matrizB.GetLength(1);
            int matARows = matrizA.GetLength(0);
            int[,] resultado = new int[matARows, matBCols];
            Parallel.For(0, matARows, i =>
            // for (int i = 0; i < matARows; i++)
            {
                for (int j = 0; j < matBCols; j++)
                {
                    int temp = 0;
                    for (int k = 0; k < matACols; k++)
                    {
                        temp += matrizA[i, k] * matrizB[k, j];
                    }
                    resultado[i, j] = temp;
                }
            });

            return resultado;
        }

        internal static int[,] CrearMatriz(int filas, int columnas)
        {
            var generador = new Random();
            int[,] resultado = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {

                for (int j = 0; j < columnas; j++)
                {
                    resultado[i, j] = generador.Next(10, 90);
                }
            }

            return resultado;
        }

        internal void Pasar(string path1, string path2)
        {
            string[] list = Directory.GetFiles(path1);

            int i = 1;
            foreach (var archivo in list)
            {
                File.Copy(archivo, path2 + "imagen" + i + ".jpg");
                i++;
            }
        }

        internal void PasarMasRapido(string path1, string path2)
        {
            string[] list = Directory.GetFiles(path1);
            Random r = new Random(1000000);

            Parallel.ForEach(list, (archivo) =>
            {
                
                int i = r.Next();
                File.Copy(archivo, path2 + "imagen" + i + ".jpg");

            });
    }
    }



}