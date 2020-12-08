using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{
    class Program
    {
        

        delegate double funk(double x, double res);
        static void Main(string[] args)
        {
            double result  = 1;
            Console.Write("Введите х - ");
            double x = double.Parse(Console.ReadLine());
            funk fnk = new funk(Fx1);
            funk res;
            fnk(x, result);
            for (int i = 1; i < x; i++)
            {
                res = (double k, double sum) => sum *= k * (1/x);
                
                Console.WriteLine("Модифицированная функция произведения: " + Convert.ToString(Math.Round(res(i - (x-2)*(-1), result), 2)));
                break;
            }
           
            Console.ReadKey();
        }
        static double Fx1(double x, double res)
        {
            double sum = 0;
            double fx = 0;
            for (int i = 0; i < x; i++)
            {
                if (i %2 == 0)
                {
                   sum += i;
                }
            }
            Console.WriteLine("Сумма четных чисел до Х = {0}", sum);
            fx = (1/x) * sum;
            Console.WriteLine("Функция для суммы( (1/x) * sum) ) = {0}", Math.Round(fx,2));
            return fx;
        }
        
    }
}
