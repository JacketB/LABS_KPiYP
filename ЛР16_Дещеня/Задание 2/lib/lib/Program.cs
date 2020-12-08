using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    class Program
    {
        static void f1(double x, double y)
        {
            y = 1 / (Math.Pow(x, 2) * (x + 1.3));
        }
        static void f2(double x, double y1)
        {
            y1 = x * Math.Cos(x / 5) * Math.Sin(x / 10);
        }
        static void f3(double x, double y2)
        {
            y2 = (x - 6.5) * (x + 2);
        }
        static void Main(string[] args)
        {

        }
    }
}
