using Microsoft.VisualBasic;
using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Массив");

            Random rnd = new Random();
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rnd.Next(10);
                
            }
            Console.WriteLine(String.Join(" ", arr));

            int j = 1;
            while (j < arr.Length && (arr[j] - arr[j - 1]) % 2 != 0) ++j;

            Console.WriteLine("\n{0}", j == arr.Length ? 0 : j + 1); // Слова не нужны. Только 0 или номер элемента.
            //j + 1 потому, что порядковый номер (нумерация с 1, а индексация с 0)
            Console.ReadKey(true);
        }
    }
}
