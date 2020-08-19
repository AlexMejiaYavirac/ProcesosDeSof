using System;

namespace OrdenamientosParametrizables
{
	public class MainClass
	{
		public static void Main(string[] args)
		{
			//int[] entrada = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

			//double[] entrada = new double[] { 2.22, 0.5, 2.7, -1.0, 11.2 };

			string[] entrada = new string[] { "Red", "White", "Black", "Green", "Orange" };

			Console.WriteLine("Arreglo Original");
			Console.WriteLine("");
			printArray(entrada);
			Console.WriteLine("\n");
			Console.WriteLine("Arreglo Ordenado");
			Console.WriteLine("");
			OrdenarBubble(entrada);
			//OrdenarShell(entrada);
			printArray(entrada);


		}

		public static void OrdenarBubble<T>(T[] entrada) where T : IComparable<T>//T va hacer variable
		{
			int l = entrada.Length;

			for (int i = 0; i < l; i++)
			{
				for (int j = 0; j < l - 1; j++)
				{
					if (entrada[j].CompareTo(entrada[j + 1]) > 0) //CompaeTo = > is equal a>b pero sirve para cuaquier to[os de dato, comprar cual de los dos es mayor
					{
						T temp = entrada[j];					//Variable temporal  adaptado a tipos de varibale T
						entrada[j] = entrada[j + 1];
						entrada[j + 1] = temp;
					}
				}
			}
		}

		public static void OrdenarShell<T>(T[] entrada) where T : IComparable<T>
		{
			int salto = entrada.Length / 2;

			while (salto >= 1) //Saltos hasta 1
			{
				salto /= 2;
				for (int i = 0; i < entrada.Length - salto; i++)
				{
					if (entrada[i].CompareTo(entrada[i + salto]) > 0)
					{
						T tmp = entrada[i + salto];
						entrada[i + salto] = entrada[i];
						entrada[i] = tmp;
					}
					for (int j = 0; j <= i; j++)
					{
						if (entrada[j].CompareTo(entrada[j + salto]) > 0)
						{
							T tmp = entrada[j + salto];		
							entrada[j + salto] = entrada[j];
							entrada[j] = tmp;
						}
					}
				}
			}
		}

		private static void printArray<T>(T[] array)
		{

			foreach (T t in array)
			{
				Console.Write(' ' + t.ToString() + ' ');
			}

		}
	}
}




