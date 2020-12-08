using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("\n\n\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("      ==================================================\n " +
                              "     |          <Условия решения выражения>           |\n " +
                              "     |                                                |\n " +
                              "     |    1. x больше либо равно 5 и х не равно 9.    |\n " +
                              "     |    2. x меньше либо равно 1.                   |\n " +
                              "     |    3. условие не совпалает с пунктом 1 и 2     |\n" +
                              "      ==================================================\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("      ===============");
            Console.Write("      |Введите Х - " );
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("      ===============");
            Console.ResetColor();

                    Console.WriteLine("");
            if (x >=5 && x != 9)
            {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("      ================================================");
                    Console.Write("      |Ваше число больше либо равно 5 и х не равно 9.|\n");

                x = 8 * x + 1;

                    Console.WriteLine("      |Результат вычисления = {0}                     |", x );
                    Console.WriteLine("      ================================================\n");
                    Console.ResetColor();
            }
            else if (x <= 1)
            {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("          ===================================");
                    Console.WriteLine("          | Ваше число меньше либо равно 1. |");

                x = Math.Pow(x, 2) + Math.Abs(x);

                    Console.WriteLine("          | Результат вычисления = {0}        |",x);
                    Console.WriteLine("          ===================================\n");
                    Console.ResetColor();
            }
            else
            {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("          ==========================================");
                    Console.WriteLine("          |Ваше число не совпалает с пунктом 1 и 2.|");

                x = Math.Pow(x,3) + Math.Sqrt(x);

                    Console.WriteLine("          |Результат вычисления = {0}               |", x );
                    Console.WriteLine("          ==========================================\n");
                    Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("      Д");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("л");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("я ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("п");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("р");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("о");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("д");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("о");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("л");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("ж");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("е");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("н");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("и");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("я ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("н");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("а");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("ж");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("м");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("и");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("т");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("е ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("л");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("ю");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("б");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("у");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("ю ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("к");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("л");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("а");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("в");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("и");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ш");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("у ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(". ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(". ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(".");
            Console.ReadKey();
        }
    }
}
