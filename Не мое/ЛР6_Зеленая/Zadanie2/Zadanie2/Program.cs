using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int[,] x = new int[n, m];
            int[] y = new int[n];
            int[,] izm = new int[n, m];
            int tempN = 0;
            int sum;
            Random ran = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    
                    x[i, j] = ran.Next(-10, 5);
                    Console.Write("{0}\t", x[i, j]);
                }
                Console.WriteLine();

            }
            Console.WriteLine("Сумма элементов столбцов:");
            for (int j = 0; j < n; j++)
            {
                sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += x[i,j];
                }
                
                Console.Write("{0}\t",sum);
            }
            for (int j = 0; j < n; j++)
            {
                int  min = 0;
                for (int i = 0; i < n; i++)
                {
                    if (x[min,j] > x[i,j])
                    {
                        min = i;
                    }
                }
                y[j] = x[min,j];
            }
            Console.WriteLine("\nМинимальные элементы столбцов матрицы");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}\t",y[i]);
            }
            Console.WriteLine("\nИзмененная матрица");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (y[j] < 0)
                    {
                        izm[i, j] = y[j];
                    }
                    Console.WriteLine(izm[i, j]);
                    
                }
                break;  
            }
            
            Console.ReadKey(true);
        }
    }
}
