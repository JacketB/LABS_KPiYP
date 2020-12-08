using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        
        static void f1(double x, out double y)
        {
            y = 1 / (Math.Pow(x, 2) * (x + 1.3));
        }
        static void f2(double x, out double y1)
        {
            y1 = x * Math.Cos(x / 5) * Math.Sin(x / 10);
        }
        static void f3(double x, out double y2)
        {
            y2 = (x - 6.5) * (x + 2);
        }
        static void Main(string[] args)
        {
            double x, y,y1,y2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===============");
            Console.Write("|");
            Console.ResetColor();
            Console.Write("Введите x = ");
            x = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===============");
            Console.ResetColor();
            f1(x, out y);
            f2(x, out y1);
            f3(x, out y2);
            Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("f1 = ");
            Console.ResetColor();
                    Console.WriteLine(Math.Round(y, 2));

            Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("f2 = ");
            Console.ResetColor();
                    Console.WriteLine(Math.Round(y1, 2));

            Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("f3 = ");
            Console.ResetColor();
                    Console.WriteLine(Math.Round(y2, 2));
          
            Console.WriteLine("\n \nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();
        }
    }
}
