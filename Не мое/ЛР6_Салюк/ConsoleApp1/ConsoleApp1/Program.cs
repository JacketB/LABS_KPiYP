using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            Console.WriteLine("Введите длину массива - ");
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                mas[i] = ran.Next(-15, 15);
                Console.Write("{0} ", mas[i]);
            }

            Console.WriteLine("\nИзмененный массив - ");
            for (int i = 0; i < n; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    Console.Write("{0} ", mas[i]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (mas[i] % 2 != 0)
                {
                    Console.Write("{0} ", mas[i]);
                }
            }
            Console.ReadKey(true);

        }
    }
}
