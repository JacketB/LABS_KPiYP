using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClass2
{
    public class Reshenie
    {
        double x;
        double y;
        double y1;
        double y2;
        public double f1
        {
            get
            {
                return Math.Round((1 / (Math.Pow(x, 2) * (x + 1.3))),2);
            }
        }
        public double f2
        {
            get
            {
                return Math.Round((x * Math.Cos(x / 5) * Math.Sin(x / 10)),2);
            }
        }
        public double f3
        {
            get
            {
                return Math.Round(((x - 6.5) * (x + 2)),2);
            }
        }
        public Reshenie(double x1)
        {
            x = x1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===============");
            Console.Write("|");
            Console.ResetColor();
            Console.Write("Введите x = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===============");
            Console.ResetColor();
            Reshenie A = new Reshenie(x1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("f1 = ");
            Console.ResetColor();
            Console.WriteLine(A.f1);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("f2 = ");
            Console.ResetColor();
            Console.WriteLine(A.f2);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("f3 = ");
            Console.ResetColor();
            Console.WriteLine(A.f3);

            Console.WriteLine("\n \nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();
        }
    }
}
