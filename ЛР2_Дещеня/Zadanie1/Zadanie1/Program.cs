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
            Console.Write("Введите х ");
            buf = Console.ReadLine();
            double x = Convert.ToDouble(buf);

            Console.Write("Введите y ");
            buf = Console.ReadLine();
            double y = Convert.ToDouble(buf);

            Console.Write("Введите z ");
            buf = Console.ReadLine();
            double z = Convert.ToDouble(buf);

            double b = Math.Abs(x - y) * ((Math.Pow(Math.Sin(z), 2)) + Math.Tan(z));

            Console.WriteLine("Результат = " + Math.Round(b,2));
        }
    }
}
