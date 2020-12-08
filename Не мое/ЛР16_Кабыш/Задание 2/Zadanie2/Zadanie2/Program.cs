using System;
using ClassLibrary1;
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
            y = functions.fx1(x);
            Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("f1 = ");
            Console.ResetColor();
                    Console.WriteLine(Math.Round(y, 2));
            y1 = functions.fx2(x);
            Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("f2 = ");
            Console.ResetColor();
                    Console.WriteLine(Math.Round(y1, 2));
            y2 = functions.fx3(x);
            Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("f3 = ");
            Console.ResetColor();
                    Console.WriteLine(Math.Round(y2, 2));
          
            Console.WriteLine("\n \nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();
        }
    }
}
