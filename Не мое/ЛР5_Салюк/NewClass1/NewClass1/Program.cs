using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClass1
{
    public class Reshenie
    {
        double R;
        double r;
        public double resh
        {
            get
            {
                return Math.Round( Math.PI * (Math.Pow(R, 2) - Math.Pow(r, 2)),2);
            }
        }
        public Reshenie(double R1, double r1)
        {
            R = R1;
            r = r1;
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
            Console.Write("Введите R - ");
            double R1 = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("|");
            Console.ResetColor();
            Console.Write("Введите r - ");
            double r1 = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===============");
            Console.ResetColor();
            Reshenie s = new Reshenie(r1, R1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Площадь окружности равна = {0}\n", s.resh);
            Console.ResetColor();
            Console.WriteLine("Для продолжения нажмите любую клавишу . . .");
            Console.ReadKey(true);
        }
    }
}
