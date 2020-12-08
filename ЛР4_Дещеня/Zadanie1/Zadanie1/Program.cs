using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{ 
    class Program
    {
       
        static void radius(double R, double r, out double S )
        {
           
            S = Math.PI * (Math.Pow(R, 2) - Math.Pow(r, 2));
        }
        static void Main(string[] args)
        {
            double S;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===============");
            Console.Write("|");
            Console.ResetColor();
            Console.Write("Введите R - ");
            double R = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("|");
            Console.ResetColor();
            Console.Write("Введите r - ");
            double r = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===============");
            Console.ResetColor();
            radius(R, r, out S);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Площадь окружности равна = {0}\n", Math.Round(S,2));
            Console.ResetColor();
            Console.WriteLine("Для продолжения нажмите любую клавишу . . .");
            Console.ReadKey(true);
        }
     
    }
}
