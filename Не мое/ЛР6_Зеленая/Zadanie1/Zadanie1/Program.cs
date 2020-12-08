using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Size = new int();
            while (Size <= 2)//Мигимум 3 элемента, дабы не изменять 1 и 3 элемент(т.е. 1 и посл. элемент)
            {
                Console.WriteLine("Введите размерность массива:");
                Size = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (Size <= 0) Console.WriteLine("Введено не верное значение размерности!\nПовтор попытки...");
            }
            int[] M = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                Console.Write("[{0,2}] = ", (i + 1));
                M[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 1; i < Size; i += 2)
            {
                M[i] += M[Size - 1];
            }
            for (int i = 0; i < Size; i++) Console.WriteLine("[{0,2}] = {1,3}", (i + 1), M[i]);
            Console.ReadKey();
        }
    }
}