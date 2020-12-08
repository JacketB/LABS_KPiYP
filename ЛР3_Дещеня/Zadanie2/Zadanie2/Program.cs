using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, x1, x2, dx, a, b;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" <Введите х начальное - ");
                x1 = double.Parse(Console.ReadLine());

            Console.Write(" <Введите х конечное - ");
                x2 = double.Parse(Console.ReadLine());

            Console.Write(" <Введите шаг - ");
                dx = double.Parse(Console.ReadLine());

            Console.Write(" <Введите a - ");
                a = double.Parse(Console.ReadLine());

            Console.Write(" <Введите b - ");
                b = double.Parse(Console.ReadLine());
            Console.Write("\n");
            x = x1;
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("   Результат:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     =====");
            while (x1 <= x2)
            {
                double y = (Math.Pow(Math.Atan(a * x), 2))/(b + x*0.5);
                x = x1 + dx;
                x1 += dx;
                Console.Write("    |{0}", Math.Round(y,3) + "|\n");
            }
            Console.WriteLine("     =====\n");
            Console.ReadKey();
        }
    }
}
