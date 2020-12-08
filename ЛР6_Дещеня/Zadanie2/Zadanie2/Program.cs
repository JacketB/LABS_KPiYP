using System;
using System.Globalization;

namespace Zadanie2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк ");
             int n = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов ");
             int m = int.Parse(Console.ReadLine());
            int[,] x = new int [n,m];
            int[,] y = new int[n, m];
            int tempN = 0;
           
            Random ran = new Random();
           
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    x[i, j] = ran.Next(-10, 5);
                    Console.Write("{0}\t", x[i, j]);
                }
                Console.WriteLine();

            }
            Console.ResetColor();
            for (int i = 0; i < n; i++)
            {
                if (x[i, m - 1] > 0)
                {

                    tempN++;
                    for (int j = 0; j < n; j++)
                    {
                        y[tempN, j] = x[i, j];
                    }
                    
                }
                
            }
            for (int j = 0; j < m; j++)
            {
                y[0, j] = y[ran.Next(1, tempN), j];
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Измененная матрица");
            for (int i = 0; i < tempN+1; i++)
            {
                
                for (int j = 0;  j < m; j++)
                { 
                    Console.Write("{0}\t", y[i, j]);
                }
                Console.WriteLine();
                
            }
            Console.Write("\n");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("          \n" +
                          "          \n");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("          \n" +
                          "          \n");
            Console.ResetColor();
            Console.ReadKey(true);
        }
    }
}
