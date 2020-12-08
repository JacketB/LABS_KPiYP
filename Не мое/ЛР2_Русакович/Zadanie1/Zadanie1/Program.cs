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
            string buf;
            Console.Write("Введите х - ");
            buf = Console.ReadLine();
            double x = Convert.ToDouble(buf);

            Console.Write("Введите y - ");
            buf = Console.ReadLine();
            double y = Convert.ToDouble(buf);

            Console.Write("Введите z - ");
            buf = Console.ReadLine();
            double z = Convert.ToDouble(buf);

            double b = Math.Exp(x-1) + Math.Sin(y);

            Console.WriteLine("Результат = " + Math.Round(b,2));
        }
    }
}
