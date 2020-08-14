using System;
using System.Diagnostics;
using System.Threading;

namespace Carrera
{
    class Program
    {

        public static void Competidor()
        {
            int nt = 0;
            while (nt <= 10)
            {
                Random rnd = new Random();
              //  int pasos = rnd.Next(1, 3);
                Console.WriteLine(" | 1 |   |   |   |   |   |   |   |");
                nt += 1;
                Thread.Sleep(1000);//Para que duerma
            }


        }

        public static void Competidor2()
        {

            int nt = 0;
            while (nt <= 10)
            {
                Random rnd = new Random();
             //   int pasos = rnd.Next(1, 3);
                Console.WriteLine(" |   | 2 |   |   |   |   |   |   |");
                nt += 1;
                Thread.Sleep(1000);
            }


        }

        public static void Competidor3()
        {

            int nt = 0;
            while (nt <= 10)
            {
                Random rnd = new Random();
          //      int pasos = rnd.Next(1, 3);
                Console.WriteLine(" |   |   | 3 |   |   |   |   |   |");
                nt += 1;
                Thread.Sleep(1000);
            }


        }


        public static void Competidor4()
        {

            int nt = 0;
            while (nt <= 10)
            {
                Random rnd = new Random();
             //   int pasos = rnd.Next(1, 3);
                Console.WriteLine(" |   |   |   | 4 |   |   |   |   |");
                nt += 1;
                Thread.Sleep(1000);
            }


        }



        public static void Competidor5()
        {

            int nt = 0;
            while (nt <= 10)
            {
                Random rnd = new Random();
             //   int pasos = rnd.Next(1, 3);
                Console.WriteLine(" |   |   |   |   | 5 |   |   |   |");
                nt += 1;
                Thread.Sleep(1000);
            }


        }



        public static void Competidor6()
        {

            int nt = 0;
            while (nt <= 10)
            {
                Random rnd = new Random();
             // int pasos = rnd.Next(1, 3);
                Console.WriteLine(" |   |   |   |   |   | 6 |   |   |");
                nt += 1;
                Thread.Sleep(1000);
            }


        }



        public static void Competidor7()
        {

            int nt = 0;
            while (nt <= 10)
            {
                Random rnd = new Random();
           //   int pasos = rnd.Next(1, 3);
                Console.WriteLine(" |   |   |   |   |   |   | 7 |   |");
                nt += 1;
                Thread.Sleep(1000);
            }


        }



        public static void Competidor8()
        {

            int nt = 0;
            while (nt <= 10)
            {
                Random rnd = new Random();
            //  int pasos = rnd.Next(1, 3);
                Console.WriteLine(" |   |   |   |   |   |   |   | 8 |");
                nt += 1;
                Thread.Sleep(1000);
            }


        }


    


        static void Main(string[] args)
        {
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("Carrera del semestre");
            //Ejecutar en hilos 
            Thread corredor1 = new Thread(new ThreadStart(Competidor));
            Thread corredor2 = new Thread(new ThreadStart(Competidor2));
            Thread corredor3 = new Thread(new ThreadStart(Competidor3));
            Thread corredor4 = new Thread(new ThreadStart(Competidor4));
            Thread corredor5 = new Thread(new ThreadStart(Competidor5));
            Thread corredor6 = new Thread(new ThreadStart(Competidor6));
            Thread corredor7 = new Thread(new ThreadStart(Competidor7));
            Thread corredor8 = new Thread(new ThreadStart(Competidor8));

      
            corredor1.Start();
            corredor2.Start();
            corredor3.Start();
            corredor4.Start();
            corredor5.Start();
            corredor6.Start();
            corredor7.Start();
            corredor8.Start();
           

            //Competidor();
            //Competidor2();
        }
    }
} 
